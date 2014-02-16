
#Procedimiento almacenado para iniciar la simulacion
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `iniSimulacion`()
BEGIN
	DECLARE fechaFin DATE;
	DECLARE totalServicios INT;
	DECLARE numServicio INT;

	SET fechaFin = '2004/01/05';
	
	repeat
		SET totalServicios = RAND(200,250);
		SET numServicio = 0;
		
		WHILE numServicio < totalServicios DO
			INSERT INTO Ventas(id_empleado,fecha,iva,total)#Se crea una venta
			VALUES(
				(SELECT e.id_empleado FROM Empleados e WHERE tipo_empleado=5 ORDER BY RAND() LIMIT 1),
				@fechaAct,0.16,0.0);
		END WHILE;

		set @fechaAct = DATE_ADD(@fechaAct, INTERVAL 1 DAY);
		set cont = cont + 1;
		until @fechaAct = fechaFin		
	end repeat;

	set @fechaAct = '2004/01/01';#Se reinicia la fecha inicial
END

DELIMITER $
CREATE TRIGGER crearDetalleVenta AFTER INSERT ON Ventas 
FOR EACH ROW 
BEGIN
	DECLARE idProducto INT;
	DECLARE precio DECIMAL;
	DECLARE cantidad INT;

	#Se recupera una lista de productos en forma aleatoria
	DECLARE productos cursor for 
		SELECT id_articulo,precio
		FROM Inventarios
		WHERE tipo_articulo = 'Producto'
		ORDER BY RAND() LIMIT 5;
	
	#Se recorre la lista de productos
	OPEN productos;	
	read_loop: LOOP
	FETCH productos INTO idProducto,precio;
		SET cantidad = RAND(1,5);
		INSERT INTO Detalle_Venta(NEW.id_venta,idProducto,cantidad,cantidad*precio);
	end LOOP;
	CLOSE productos;
END $

DELIMITER $
CREATE TRIGGER actualizaStock AFTER INSERT ON detalle_venta 
FOR EACH ROW 
BEGIN
	#Se actualiza el stock del articulo(Producto|Materia Prima)
	UPDATE inventarios SET stock = stock - NEW.cantidad 
	WHERE inventarios.id_articulo = NEW.id_articulo;

	#Se actualiza el Costo Total de la venta asociada al detalle
	UPDATE Ventas SET total = total + ((NEW.subtotal*iva) + NEW.subtotal)
	WHERE id_venta = NEW.id_venta; 
END $

DELIMITER $
CREATE TRIGGER crearOrdenCompraProduccion AFTER UPDATE ON inventarios
FOR EACH ROW
BEGIN	
	DECLARE cantPro INT;
	
	SET cantPro = RAND(1,10);
	IF NEW.stock <= NEW.stock_minimo THEN
		IF NEW.tipo_articulo = 'Productos' THEN
			#Se crea una orden de produccion con el producto actual
			INSERT INTO ordenes_produccion(id_empleado,id_articulo,fecha_inicio,fecha_entrega,cantidad)
			VALUES(
					(SELECT e.id_empleado FROM empleados e WHERE tipo_empleado=1 ORDER BY RAND() LIMIT 1),
					NEW.id_articulo,
					"2014,01,01",
					"2014,01,01",
					cantPro
			);
			CALL crearOrdenRequisicion(NEW.id_articulo,cantPro);
		ELSE
			#se crea una orden de compra para la materia prima actual
			INSERT INTO ordenes_compra(id_empleado,id_proveedor,fecha_pedido,fecha_pago,costo_total)
			VALUES(
					(SELECT e.id_empleado FROM empleados e WHERE tipo_empleado=2 ORDER BY RAND() LIMIT 1),
					NEW.id_proveedor,
					"2014,01,01",
					"2014,01,01",
					0
			);
			CALL crearDetalleCompra(NEW.id_articulo,NEW.precio);
			CALL crearMovimiento(NEW.id_articulo,'Entrada_M');
		END IF;
	END IF;
END $


DELIMITER $$
DROP PROCEDURE IF EXISTS `si_inventarios`.`crearDetalleCompra`$$
CREATE PROCEDURE `si_inventarios`.`crearDetalleCompra` (IN idArticulo INT,IN precio DECIMAL)
BEGIN
	DECLARE idCompra INT;
	DECLARE cant DECIMAL;
	
	SET cant = RAND(1,10);
	
	#Se recupera el id de la utlima compra
	SELECT id_orden_compra INTO idCompra
	FROM ordenes_compra
	ORDER BY id_orden_compra DESC LIMIT 1;
	
	#Se crea el detalle de la compra
	INSERT INTO detalle_compra(id_orden_compra,id_articulo,cantidad,subtotal)
	VALUES(idCompra,idArticulo,cant,cant*precio);

	#Se actualiza el costo total de la orden de compra
	UPDATE Ordenes_Compra SET costo_total = cant*precio
	WHERE id_orden_compra = idCompra;
END$$

DELIMITER $$
DROP PROCEDURE IF EXISTS `si_inventarios`.`crearMovimiento`$$
CREATE PROCEDURE `si_inventarios`.`crearMovimiento` (IN idArticulo INT,IN tipoMovimiento VARCHAR(20),IN cant INT)
BEGIN
	DECLARE idMov INT;

	#Se inserta un movimiento
	INSERT INTO movimientos(id_empleado,fecha,tipo_movimiento)
	VALUES(
			(SELECT e.id_empleado FROM empleados e WHERE tipo_empleado=3 ORDER BY RAND() LIMIT 1),
			'2014/01/01',
			tipoMovimiento
	);

	#Se recupera el id del ultimo movimiento
	SELECT id_movimiento INTO idMov
	FROM movimientos
	ORDER BY id_movimiento DESC LIMIT 1;

	#Se crea el detalle del Movimiento
	INSERT INTO detalle_movimiento(id_movimiento,id_articulo,cantidad)
	VALUES(idMov,idArticulo,cant);
END$$

DELIMITER $
CREATE TRIGGER actStock_Movimientos AFTER INSERT ON detalle_movimiento 
FOR EACH ROW 
BEGIN
	DECLARE tipoMov VARCHAR(20);
	
	#Se obtiene el tipo de movimiento
	SELECT M.tipo_movimiento INTO tipoMov
	FROM movimientos M
	WHERE M.id_moviento = NEW.id_movimiento;
	
	#Se checa que tipo de movimiento se realizo
	IF tipoMov = 'Entrada_M'THEN
		UPDATE inventarios SET stock = stock + NEW.cantidad
		WHERE inventarios.id_articulo = NEW.id_articulo;
	ELSE
		IF tipoMov = 'Salida_M' THEN
			UPDATE inventarios SET stock = stock - NEW.cantidad
			WHERE inventarios.id_articulo = NEW.id_articulo;
		END IF;
	END IF;
END $

DELIMITER $$
DROP PROCEDURE IF EXISTS `si_inventarios`.`crearOrdenRequisicion`$$
CREATE PROCEDURE `si_inventarios`.`crearOrdenRequisicion` (IN idArticulo INT,IN cantidadPro INT)
BEGIN
		
	DECLARE id_ordPro INT;
	DECLARE id_materia INT;
	DECLARE cant INT;
	DECLARE materia cursor for SELECT id_materia, cantidad FROM materiaporproducto WHERE id_producto = idArticulo;	
	
	#Se obtiene el id de la orden de produccion
	SELECT id_orden_produccion INTO id_ordPro FROM ordenes_produccion
	ORDER BY id_orden_produccion DESC LIMIT 1;

	#Se crear la orden de requisicion del material
	INSERT INTO requisiciones_material(id_orden_produccio,id_empleado,fecha)
	VALUES(
			id_ordPro,
			(SELECT id_empleado FROM empleados WHERE id_tipo_empleado = 3 ORDER BY RAND() LIMIT 1),
			'2014/01/01'
	);
	
	#Se recorre la tabla de las materia prima
	open materia;	
	read_loop: loop
	fetch materia into id_materia,cant;
		CALL crearMovimiento(NEW.id_articulo,'Salida_M',cant*cantidadPro);
	end loop;
	close materia;
END$$

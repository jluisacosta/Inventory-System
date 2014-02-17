
DROP TRIGGER `si_inventarios`.`crearDetalleVenta`;
DELIMITER $
CREATE TRIGGER crearDetalleVenta AFTER INSERT ON Ventas 
FOR EACH ROW 
BEGIN
	DECLARE idProducto INT;
	DECLARE prec DECIMAL;
	DECLARE cantidad INT;
	DECLARE vb_termina BOOL DEFAULT FALSE;
	DECLARE total_neto DECIMAL;

	#Se recupera una lista de productos en forma aleatoria
	DECLARE productos CURSOR FOR
		SELECT id_articulo,precio
		FROM Inventarios
		WHERE tipo_articulo = 'Producto'
		ORDER BY RAND() LIMIT 5;

	DECLARE CONTINUE HANDLER FOR SQLSTATE '02000' SET vb_termina = TRUE;
	SET total_neto = 0;
	
	OPEN productos;
	Recorre_Cursor: LOOP
		FETCH productos INTO idProducto,prec;
			IF vb_termina THEN
				LEAVE Recorre_Cursor;
			END IF;
			SET cantidad = ROUND(1 + (RAND() * 5));
			INSERT INTO Detalle_Venta(id_venta,id_articulo,cantidad,subtotal) VALUES(NEW.id_venta,idProducto,cantidad,cantidad*prec);
			SET total_neto = total_neto + (cantidad*prec);
	END LOOP;
	CLOSE productos;
	
	SET @totalVenta = total_neto + (total_neto*(16.0/100.0));
	SET @idVenta = NEW.id_venta;
END $
DELIMITER ;

DROP TRIGGER `si_inventarios`.`actualizaStock`;
DELIMITER $
CREATE TRIGGER actualizaStock AFTER INSERT ON Detalle_Venta 
FOR EACH ROW 
BEGIN
	#Se actualiza el stock del articulo(Producto|Materia Prima)
	UPDATE Inventarios SET stock = stock - NEW.cantidad 
	WHERE id_articulo = NEW.id_articulo;
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

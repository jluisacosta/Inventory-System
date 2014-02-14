
DROP TRIGGER IF EXISTS actualizaStock;

DELIMITER $
CREATE TRIGGER actualizaStock AFTER INSERT ON detalle_venta 
FOR EACH ROW 
BEGIN
	UPDATE inventarios SET stock = stock - NEW.cantidad 
	WHERE inventarios.id_articulo = NEW.id_articulo;
END $

DELIMITER $
CREATE TRIGGER crearOrdenCompraProduccion AFTER UPDATE ON inventarios
FOR EACH ROW
BEGIN	
	IF NEW.stock <= NEW.stock_minimo THEN
		IF NEW.tipo_articulo = 'Productos' THEN
			#Se crea una orden de produccion con el producto actual
			INSERT INTO ordenes_produccion(id_empleado,id_articulo,fecha_inicio,fecha_entrega,cantidad)
			VALUES(
					(SELECT e.id_empleado FROM empleados e WHERE tipo_empleado=1 ORDER BY RAND() LIMIT 1),
					NEW.id_articulo,
					"2014,01,01",
					"2014,01,01",
					RAND(1,10)
			);

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
END$$

DELIMITER $$
DROP PROCEDURE IF EXISTS `si_inventarios`.`crearMovimiento`$$
CREATE PROCEDURE `si_inventarios`.`crearMovimiento` (IN idArticulo INT,IN tipoMovimiento VARCHAR(20))
BEGIN
	DECLARE idMov INT;
	DECLARE cant INT;

	SET cant = RAND(1,10);

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
CREATE PROCEDURE `si_inventarios`.`crearOrdenRequisicion` (IN idOrdenPro INT,IN idArticulo INT,IN cantidad INT)
BEGIN
	
	#Se crear la orden de requisicion del material
	INSERT INTO requisiciones_material(id_orden_produccio,id_empleado,fecha)
	VALUES(
			idOrdenProd,
			(SELECT id_empleado FROM empleados WHERE id_tipo_empleado = 3 ORDER BY RAND() LIMIT 4),
			'2014/01/01'
	);

END$$






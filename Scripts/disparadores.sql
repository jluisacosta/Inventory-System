
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
	DECLARE cantPro INT DEFAULT ROUND(1 + RAND()*10);

	#Se recupera una lista de productos en forma aleatoria
	DECLARE listProductos CURSOR FOR
		SELECT id_producto,precio
		FROM Productos
		ORDER BY RAND() LIMIT cantPro;
	 
	DECLARE CONTINUE HANDLER FOR SQLSTATE '02000' SET vb_termina = TRUE;
	SET total_neto = 0;
	
	OPEN listProductos;
	Recorre_Cursor: LOOP
		FETCH listProductos INTO idProducto,prec;
			IF vb_termina THEN
				LEAVE Recorre_Cursor;
			END IF;
			SET cantidad = ROUND(1 + (RAND() * 5));
			INSERT INTO Detalle_Venta(id_venta,id_articulo,cantidad,subtotal) VALUES(NEW.id_venta,idProducto,cantidad,cantidad*prec);
			SET total_neto = total_neto + (cantidad*prec);
			
	END LOOP;
	CLOSE listProductos;
	
	SET @totalVenta = total_neto + (total_neto*(16.0/100.0));
	SET @idVenta = NEW.id_venta;
END $
DELIMITER ;

DROP TRIGGER `si_inventarios`.`actualizaStock`;
DELIMITER $
CREATE TRIGGER actualizaStock AFTER INSERT ON Detalle_Venta 
FOR EACH ROW 
BEGIN
	#Se actualiza el stock del Producto
	UPDATE Inventarios SET stock = stock - NEW.cantidad 
	WHERE id_articulo = NEW.id_articulo;
END $
DELIMITER ;

DROP TRIGGER `si_inventarios`.`crearOrdenCompraProduccion`;
DELIMITER $
CREATE TRIGGER crearOrdenCompraProduccion AFTER UPDATE ON Inventarios
FOR EACH ROW
BEGIN	
	DECLARE cantPro INT DEFAULT ROUND(1 + (RAND() * 10));
	
	IF NEW.stock <= NEW.stock_minimo THEN
		IF NEW.tipo_articulo = 'Producto' THEN
			#Se crea una orden de produccion con el producto actual
			INSERT INTO Ordenes_Produccion(id_empleado,id_articulo,fecha_inicio,fecha_entrega,cantidad)
			VALUES(
					(SELECT id_empleado FROM Empleados WHERE id_tipo_empleado = 2 ORDER BY RAND() LIMIT 1),
					NEW.id_articulo,
					@fechaAct,
					@fechaAct,
					cantPro
			);
			CALL crearOrdenRequisicion(NEW.id_articulo,cantPro);
		/*ELSE
			#se crea una orden de compra para la materia prima actual
			INSERT INTO Ordenes_Compra(id_empleado,id_proveedor,fecha_pedido,fecha_pago,costo_total)
			VALUES(
					(SELECT id_empleado FROM Empleados WHERE id_tipo_empleado= 5 ORDER BY RAND() LIMIT 1),
					NEW.id_proveedor,
					@fechaAct,
					@fechaAct,
					0
			);
			CALL crearDetalleCompra(NEW.id_articulo,NEW.precio);
			CALL crearMovimiento(NEW.id_articulo,'Entrada_M');*/
		END IF;
	END IF;
END $

DROP TRIGGER `si_inventarios`.`actStock_Movimientos`
DELIMITER $
CREATE TRIGGER actStock_Movimientos AFTER INSERT ON Detalle_Movimiento 
FOR EACH ROW 
BEGIN
	DECLARE tipoMov VARCHAR(20);

	#Se obtiene el tipo de movimiento
	SELECT tipo_movimiento INTO tipoMov 
	FROM Movimientos
	WHERE id_movimiento = NEW.id_movimiento;
	
	#Se checa que tipo de movimiento se realizo
	IF tipoMov = 'Entrada_M'THEN
		UPDATE Inventarios SET stock = stock + NEW.cantidad
		WHERE id_articulo = NEW.id_articulo;
	ELSE
		IF tipoMov = 'Salida_M' THEN
			UPDATE Inventarios SET stock = stock - NEW.cantidad
			WHERE id_articulo = NEW.id_articulo;
		END IF;
	END IF;
END $




DROP PROCEDURE `si_inventarios`.`agregaProveedores`
DELIMITER $
CREATE procedure agregaProveedores()
BEGIN
	DECLARE idProv INT;
	DECLARE idart INT;
	DECLARE vb_termina BOOL;

	#Se recupera una lista de productos en forma aleatoria
	DECLARE materias CURSOR FOR
		SELECT id_articulo
		FROM Inventarios
		WHERE tipo_articulo = 'MateriaPrima';

	DECLARE CONTINUE HANDLER FOR SQLSTATE '02000' SET vb_termina = TRUE;
	
	OPEN materias;
	Recorre_Cursor: LOOP
		FETCH materias INTO idart;
			IF vb_termina THEN
				LEAVE Recorre_Cursor;
			END IF;
			SET idProv = (SELECT id_proveedor FROM Proveedores ORDER BY RAND() LIMIT 1);
			UPDATE Inventarios SET id_proveedor = idProveedor WHERE id_articulo = idart;
			
	END LOOP;
	CLOSE materias;
END $
DELIMITER ;

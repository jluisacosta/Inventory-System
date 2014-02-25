
DELIMITER $
DROP TRIGGER IF EXISTS `si_inventarios`.`crearDetalleVenta`$
CREATE TRIGGER crearDetalleVenta AFTER INSERT ON Ventas 
FOR EACH ROW 
BEGIN
	DECLARE idProducto INT;
	DECLARE prec DECIMAL;
	DECLARE cantidad INT;
	DECLARE vb_termina BOOL DEFAULT FALSE;
	DECLARE total_neto DECIMAL;
	DECLARE cantPro INT DEFAULT ROUND(1 + RAND()*5);

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
			SET cantidad = ROUND(1 + (RAND() * 3));
			INSERT INTO Detalle_Venta(id_venta,id_producto,cantidad,subtotal) VALUES(NEW.id_venta,idProducto,cantidad,cantidad*prec);
			SET total_neto = total_neto + (cantidad*prec);
	END LOOP;
	CLOSE listProductos;
	
	SET @totalVenta = total_neto + (total_neto*(16.0/100.0));
	SET @idVenta = NEW.id_venta;
END $
DELIMITER ;

DELIMITER $
DROP TRIGGER IF EXISTS `si_inventarios`.`act_stock_producto` $
CREATE TRIGGER act_stock_producto AFTER INSERT ON Detalle_Venta 
FOR EACH ROW 
BEGIN
	#Se actualiza el stock del Producto
	UPDATE Productos SET stock = stock - NEW.cantidad WHERE id_producto = NEW.id_producto;
	IF @actStockProducto = TRUE THEN
		UPDATE Productos SET stock = stock + @cantPro 
		WHERE id_producto = NEW.id_producto;
		SET @actStockProducto = FALSE;
	END IF;
END $
DELIMITER ;

DELIMITER $
DROP TRIGGER IF EXISTS`si_inventarios`.`crearOrdenProduccion` $
CREATE TRIGGER crearOrdenProduccion AFTER UPDATE ON Productos
FOR EACH ROW
BEGIN	

	IF NEW.stock <= NEW.stock_minimo THEN
		SET @cantPro = ROUND( NEW.stock_minimo + ( RAND() * (NEW.stock_maximo-NEW.stock_minimo)) );
		#Se crea una orden de produccion con el producto actual
		INSERT INTO Ordenes_Produccion(id_empleado,id_producto,fecha_inicio,fecha_entrega,cantidad)
		VALUES(
				(SELECT id_empleado FROM Empleados WHERE id_tipo_empleado = 3 ORDER BY RAND() LIMIT 1),
				NEW.id_producto,
				@fechaAct,
				@fechaAct,
				@cantPro
		);
		CALL crearOrdenRequisicion(NEW.id_producto,@cantPro);
		CALL crearOrdenCompra();
		SET @actStockProducto = TRUE;
	END IF;
END$
DELIMITER ;

/*
DELIMITER $
DROP PROCEDURE IF EXISTS `si_inventarios`.`agregaProveedores` $
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
*/
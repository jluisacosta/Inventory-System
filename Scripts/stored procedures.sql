DROP PROCEDURE `si_inventarios`.`iniSimulacion`;
DELIMITER $$
CREATE PROCEDURE `iniSimulacion`()
BEGIN
	DECLARE fechaFin DATE;
	DECLARE totalServicios INT;
	DECLARE numServicio INT;

	SET fechaFin = '2004/01/03';

	repeat
		SET totalServicios = ROUND(1 + (RAND() * 5));
		SET numServicio = 0;
		
		#Se llevan a cabo los servicios de ventas
		WHILE numServicio < totalServicios DO
			INSERT INTO Ventas(id_empleado,fecha,iva,total)#Se crea una venta
			VALUES(
				(SELECT e.id_empleado FROM Empleados e WHERE id_tipo_empleado = 1 ORDER BY RAND() LIMIT 1),
				@fechaAct,16.0,0.0);
			
			SET numServicio = numServicio + 1;
			UPDATE Ventas SET total = @totalVenta WHERE id_venta = @idVenta;
			
			IF RAND() < 0.30 THEN
				INSERT INTO Facturas(id_venta,id_cliente)VALUES(@idVenta,
				(SELECT id_cliente FROM Clientes ORDER BY RAND() LIMIT 1));
			END IF;

		END WHILE;

		set @fechaAct = DATE_ADD(@fechaAct, INTERVAL 1 DAY);
		until @fechaAct = fechaFin		
	end repeat;
	set @fechaAct = '2004/01/01';#Se reinicia la fecha inicial
END$$

DELIMITER $$
DROP PROCEDURE IF EXISTS `si_inventarios`.`crearOrdenRequisicion`$$
CREATE PROCEDURE `si_inventarios`.`crearOrdenRequisicion` (IN idArticulo INT,IN cantidadPro INT)
BEGIN
		
	DECLARE id_ordPro INT;
	DECLARE id_materia INT;
	DECLARE cant INT;
	DECLARE idEmp INT;
	DECLARE vb_termina BOOL;	
	DECLARE materia cursor for SELECT id_materia, cantidad FROM MateriaPorProducto WHERE id_producto = idArticulo;	
	
	DECLARE CONTINUE HANDLER FOR SQLSTATE '02000' SET vb_termina = TRUE;
	
	#Se obtiene el id de la orden de produccion
	SELECT id_orden_produccion INTO id_ordPro FROM Ordenes_Produccion
	ORDER BY id_orden_produccion DESC LIMIT 1;

	SET idEmp = (SELECT id_empleado FROM Empleados WHERE id_tipo_empleado = 3 ORDER BY RAND() LIMIT 1);
	
	#Se crear la orden de requisicion del material
	INSERT INTO Requisiciones_Material(id_orden_produccion,id_empleado,fecha) VALUES(id_ordPro,idEmp,@fechaAct);
	
	#Se recorre la tabla de las materia prima
	OPEN materia;	
	Recorre_Cursor: LOOP
			IF vb_termina THEN
				LEAVE Recorre_Cursor;
			END IF;
	FETCH materia into id_materia,cant;
		
		CALL crearMovimiento(idArticulo,'Salida_M',cant*cantidadPro,idEmp);
	end LOOP;
	CLOSE materia;
END$$

DROP PROCEDURE IF EXISTS `si_inventarios`.`crearMovimiento`$$
DELIMITER $$
CREATE PROCEDURE `si_inventarios`.`crearMovimiento` (IN idArticulo INT,IN tipoMovimiento VARCHAR(20),IN cant INT,IN idEmp INT)
BEGIN
	DECLARE idMov INT;

	#Se inserta un movimiento
	INSERT INTO Movimientos(id_empleado,fecha,tipo_movimiento)VALUES(idEmp,@fechaAct,tipoMovimiento);

	#Se recupera el id del ultimo movimiento
	SELECT id_movimiento INTO idMov FROM Movimientos ORDER BY id_movimiento DESC LIMIT 1;

	#Se crea el detalle del Movimiento
	INSERT INTO Detalle_Movimiento(id_movimiento,id_articulo,cantidad) VALUES(idMov,idArticulo,cant);
END$$






DROP PROCEDURE IF EXISTS `si_inventarios`.`crearDetalleCompra`$$
DELIMITER $$
CREATE PROCEDURE `si_inventarios`.`crearDetalleCompra` (IN idArticulo INT,IN precio DECIMAL)
BEGIN
	DECLARE idCompra INT;
	DECLARE cant DECIMAL;
	
	SET cant = (1 + RAND()*10);
	
	#Se recupera el id de la utlima compra
	SELECT id_orden_compra INTO idCompra
	FROM Ordenes_Compra
	ORDER BY id_orden_compra DESC LIMIT 1;
	
	#Se crea el detalle de la compra
	INSERT INTO Detalle_Compra(id_orden_compra,id_articulo,cantidad,subtotal)
	VALUES(idCompra,idArticulo,cant,cant*precio);

	#Se actualiza el costo total de la orden de compra
	UPDATE Ordenes_Compra SET costo_total = cant*precio
	WHERE id_orden_compra = idCompra;
END$$
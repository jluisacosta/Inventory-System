DELIMITER $$
DROP PROCEDURE IF EXISTS `si_inventarios`.`iniSimulacion` $$
CREATE PROCEDURE `iniSimulacion`()
BEGIN
	DECLARE fechaFin DATE;
	DECLARE totalServicios INT;
	DECLARE numServicio INT;

	SET fechaFin = '2004/01/02';

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
CREATE PROCEDURE `si_inventarios`.`crearOrdenRequisicion` (IN idProduc INT,IN cantidadPro INT)
BEGIN
		
	DECLARE idOrdPro INT;
	DECLARE idMateria INT;
	DECLARE cant DECIMAL(5,5);
	DECLARE idEmp INT;
	DECLARE idMov INT;
	DECLARE vb_termina BOOL DEFAULT FALSE;	
	
	DECLARE materias_primas cursor for SELECT id_materia, cantidad FROM MateriaPorProducto WHERE id_producto = idProduc;	
	DECLARE CONTINUE HANDLER FOR SQLSTATE '02000' SET vb_termina = TRUE;
	
	#Se recupera el ID del ultimo registro insertado en las ordenes de produccio
	SELECT DISTINCT LAST_INSERT_ID() INTO idOrdPro FROM Ordenes_Produccion;

	#Se obtiene el Id del Empleado
	SELECT id_empleado INTO idEmp
	FROM Empleados 
	WHERE id_tipo_empleado = 4 ORDER BY RAND() LIMIT 1;

	#Se crear la orden de requisicion del material
	INSERT INTO Requisiciones_Material(id_orden_produccion,id_empleado,fecha) VALUES(idOrdPro,idEmp,@fechaAct);
	
	#Se crea un movimiento para simular la salida de la materia prima necesaria para el producto a produccir
	INSERT INTO Movimientos(id_empleado,fecha,tipo_movimiento) VALUES(idEmp,@fechaAct,"Salida");
	
	#Se recupera el ID del movimiento insertado
	SELECT DISTINCT LAST_INSERT_ID() INTO idMov FROM Movimientos;

	#Se recorre la lista de materia prima necesaria para el producto
	OPEN materias_primas;	
	Recorre_Cursor: LOOP
		FETCH materias_primas into idMateria,cant;
			IF vb_termina THEN
				LEAVE Recorre_Cursor;
			END IF;
			INSERT INTO Detalle_Movimiento(id_movimiento,id_materia_prima,cantidad)VALUES(idMov,idMateria,cant*cantidadPro/*CAST((cant*cantidadPro) AS DECIMAL)*/);
			#CALL crearMovimiento(idArticulo,'Salida_M',cant*cantidadPro,idEmp);
	end LOOP;
	CLOSE materias_primas;
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
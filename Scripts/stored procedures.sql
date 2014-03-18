DELIMITER $$
DROP PROCEDURE IF EXISTS `si_inventarios`.`iniSimulacion` $$
CREATE PROCEDURE `iniSimulacion`()
BEGIN
	DECLARE fechaFin DATE;
	DECLARE totalServicios INT;
	DECLARE numServicio INT;
	DECLARE count INT DEFAULT 1;
	SET fechaFin = '2014/01/02';

	repeat
		SET totalServicios = ROUND(200 + (RAND() * 250));
		SET numServicio = 0;

		#Se asignas los proveedores de la materia prima
		IF MOD(YEAR(@fechaAct),2) = 1 THEN
			IF @bandAux = 0 THEN 
				CALL agregaProveedores(count);
				SET @bandAux = TRUE;
				SET count = count + 1;
			END IF;
		ELSE 
			SET @bandAux = FALSE;
		END IF;

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
	#set @fechaAct = '2004/01/01';#Se reinicia la fecha
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
			CALL act_stock_materia_prima(idMateria,'Salida',cant*cantidadPro);
	end LOOP;
	CLOSE materias_primas;
END$$

DROP PROCEDURE IF EXISTS `si_inventarios`.`act_stock_materia_prima`$$
DELIMITER $$
CREATE PROCEDURE `si_inventarios`.`act_stock_materia_prima` (IN idMateria INT,IN tipoMovimiento VARCHAR(20),IN cant INT)
BEGIN
	IF tipoMovimiento = 'Salida' THEN
		UPDATE Materias_Primas SET stock = stock - cant WHERE id_materia = idMateria;
	ELSE
		UPDATE Materias_Primas SET stock = stock + cant WHERE id_materia = idMateria;
	END IF;
END$$

DELIMITER $$
DROP PROCEDURE IF EXISTS `si_inventarios`.`crearOrdenCompra`$$
CREATE PROCEDURE `si_inventarios`.`crearOrdenCompra` ()
BEGIN
	DECLARE idOrdComp INT;
	DECLARE idMov INT;
	DECLARE idEmp INT;
	DECLARE idPro INT;
	DECLARE idMat INT;
	DECLARE prec DECIMAL(10,2);
	DECLARE cant INT;
	DECLARE stockMin INT;
	DECLARE stockMax INT;
	DECLARE costoNeto DECIMAL(8,2) DEFAULT 0.0;
	#DECLARE band BOOL DEFAULT FALSE;
	DECLARE vb_termina BOOL DEFAULT FALSE;	
	

	DECLARE materias_primas cursor for SELECT id_materia, id_proveedor, precio, stock_minimo, stock_maximo 
	FROM Materias_Primas 
	WHERE stock <= stock_minimo;	
	
	DECLARE CONTINUE HANDLER FOR SQLSTATE '02000' SET vb_termina = TRUE;
	
	#Se obtiene el ID del empleado
	SELECT id_empleado INTO idEmp FROM Empleados WHERE id_tipo_empleado = 5 ORDER BY RAND() LIMIT 1;
	
	#Se recorre la lista de materia prima
	OPEN materias_primas;	
	Recorre_Cursor: LOOP
		FETCH materias_primas into idMat,idPro,prec,stockMin,stockMax;
			IF vb_termina THEN
				LEAVE Recorre_Cursor;
			END IF;
			#IF band = FALSE THEN
				#Se crear la orden de Compra
			INSERT INTO Ordenes_Compra(id_empleado,id_proveedor,fecha_pedido,costo_total) VALUES(idEmp,idPro,@fechaAct,0.0);
			#Se recupera el id de la orden de compra
			SELECT DISTINCT LAST_INSERT_ID() INTO idOrdComp FROM Ordenes_Compra;
			#Se crear un movimiento de tipo entrada
			INSERT INTO Movimientos(id_empleado,fecha,tipo_movimiento)VALUES(idEmp,@fechaAct,'Entrada');
			#Se recupera el id del Movimiento
			SELECT DISTINCT LAST_INSERT_ID() INTO idMov FROM Movimientos;
			#	SET band = TRUE;
			#END IF;
			SET cant = ROUND(stockMin + ( 1 + RAND() * (stockMax-stockMin)));

			INSERT INTO Detalle_Compra(id_orden_compra,id_materia_prima,cantidad,subtotal)
			VALUES(idOrdComp,idMat,cant,cant*prec);
			
			INSERT INTO Detalle_Movimiento(id_movimiento,id_materia_prima,cantidad)VALUES(idMov,idMat,cant);
			CALL act_stock_materia_prima(idMat,'Entrada',cant);
			SET costoNeto = costoNeto + (cant*prec);
			#Se agrega el costo total de la orden de compra
			UPDATE Ordenes_Compra SET costo_total = costoNeto WHERE id_orden_compra = idOrdComp;
	end LOOP;
	CLOSE materias_primas;
END$$

DELIMITER $
DROP PROCEDURE IF EXISTS `si_inventarios`.`agregaProveedores` $
CREATE procedure agregaProveedores(IN numRot INT)
BEGIN
	DECLARE idProv INT;
	DECLARE idMat INT;
	DECLARE vb_termina BOOL;

	#Se recupera una lista de productos en forma aleatoria
	DECLARE materias CURSOR FOR SELECT id_materia FROM Materias_Primas;
	DECLARE CONTINUE HANDLER FOR SQLSTATE '02000' SET vb_termina = TRUE;
	
	OPEN materias;
	Recorre_Cursor: LOOP
		FETCH materias INTO idMat;
			IF vb_termina THEN
				LEAVE Recorre_Cursor;
			END IF;

			#Se obtiene el id del proveedor
			SELECT id_proveedor INTO idProv
			FROM Proveedores 
			WHERE id_proveedor BETWEEN ((numRot*10)-10)+1 AND (numRot* 10)
			ORDER BY RAND() LIMIT 1;

			UPDATE Materias_Primas SET id_proveedor = idProv WHERE id_materia = idMat;
	END LOOP;
	CLOSE materias;
END $
DELIMITER ;

DELIMITER $
DROP PROCEDURE IF EXISTS `si_inventarios`.`agregarFechasFacturas` $
CREATE procedure agregarFechasFacturas()
BEGIN
	DECLARE idFact INT;
	DECLARE fechaVenta DATE;
	DECLARE vb_termina BOOL;

	#Se recupera una lista de productos en forma aleatoria
	DECLARE facturas CURSOR FOR 
		select F.id_factura,V.fecha
		from Ventas v inner join Facturas F on (v.id_venta = F.id_venta);
	
	DECLARE CONTINUE HANDLER FOR SQLSTATE '02000' SET vb_termina = TRUE;
	
	OPEN facturas;
	Recorre_Cursor: LOOP
		FETCH facturas INTO idFact,fechaVenta;
			IF vb_termina THEN
				LEAVE Recorre_Cursor;
			END IF;
			UPDATE Facturas SET fecha = fechaVenta WHERE id_factura = idFact;
	END LOOP;
	CLOSE facturas;
END $
DELIMITER ;


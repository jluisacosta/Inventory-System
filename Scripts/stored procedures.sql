DELIMITER $$
CREATE PROCEDURE `iniSimulacion`()
BEGIN
	DECLARE fechaFin DATE;
	DECLARE totalServicios INT;
	DECLARE numServicio INT;

	SET fechaFin = '2004/01/05';

	repeat
		SET totalServicios = ROUND(1 + (RAND() * 5));
		SET numServicio = 0;
		
		WHILE numServicio < totalServicios DO
			INSERT INTO Ventas(id_empleado,fecha,iva,total)#Se crea una venta
			VALUES(
				(SELECT e.id_empleado FROM Empleados e WHERE id_tipo_empleado = 1 ORDER BY RAND() LIMIT 1),
				@fechaAct,16.0,0.0);
			SET numServicio = numServicio + 1;
		END WHILE;

		set @fechaAct = DATE_ADD(@fechaAct, INTERVAL 1 DAY);
		until @fechaAct = fechaFin		
	end repeat;
	set @fechaAct = '2004/01/01';#Se reinicia la fecha inicial
END


SET SQL_SAFE_UPDATES=0;

SET @cantPro = 0;
SET @actStockProducto = FALSE;
SET @idVenta = 0;
SET @totalVenta = 0;

SET @fechaAct = '2004/01/01';
SET @bandAux = TRUE;

call iniSimulacion();
#SELECT MOD(YEAR(@fechaAct), 2);


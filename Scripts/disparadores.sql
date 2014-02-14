
DROP TRIGGER IF EXISTS actualizaStock;

DELIMITER $
CREATE TRIGGER actualizaStock AFTER INSERT ON detalle_venta 
FOR EACH ROW 
BEGIN
	UPDATE inventarios SET stock = stock - NEW.cantidad 
	WHERE inventarios.id_articulo = NEW.id_articulo;
END $

DELIMITER $
CREATE TRIGGER crearOrdenProduccion AFTER UPDATE ON inventarios
FOR EACH ROW
BEGIN	
	IF NEW.stock <= NEW.stock_minimo THEN
		IF NEW.tipo_articulo = 'Productos' THEN
			#Se crea una orden de produccion con el producto actual
			INSERT INTO ordenes_produccion(id_empleado,id_articulo,fecha_inicio,fecha_entrega,cantidad)
			VALUES(
					(SELECT e.id_empleado FROM empleados e WHERE tipo_empleado=1),
					NEW.id_articulo,
					"2014,01,01",
					"2014,01,01",
					RAND(1,10)
			);
		ELSE
			#se crea una orden de compra para la materia prima actual
			INSERT INTO ordenes_compra(id_empleado,id_proveedor,fecha_pedido,fecha_pago,costo_total)
			VALUES(
					(SELECT e.id_empleado FROM empleados e WHERE tipo_empleado=2),
					NEW.id_proveedor,
					"2014,01,01",
					"2014,01,01",
					0
			); 
			CALL crearDetalleCompra(NEW.id_articulo,NEW.precio);
			CALL crearMovimiento(NEW.id_articulo,"Entrada_M");
		END IF;
	END IF;
END $





DROP TRIGGER IF EXISTS actualizaStock;

CREATE TRIGGER actualizaStock AFTER INSERT ON detalle_venta 
FOR EACH ROW
	UPDATE inventarios SET stock = stock - NEW.cantidad 
	WHERE inventarios.id_articulo = NEW.id_articulo


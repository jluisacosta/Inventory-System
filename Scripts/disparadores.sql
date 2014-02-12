
DROP TRIGGER IF EXISTS actualizaStock;

CREATE TRIGGER actualizaStock AFTER INSERT ON detalle_venta 
FOR EACH ROW
	UPDATE inventarios SET stock = stock - NEW.cantidad 
	WHERE inventarios.id_articulo = NEW.id_articulo;


CREATE TRIGGER crearOrdenProduccion AFTER UPDATE ON inventarios
FOR EACH ROW
	
	id_empleado 
	id_articulo 
	fecha_inicio 
	fecha_entrega
	cantidad RaND()

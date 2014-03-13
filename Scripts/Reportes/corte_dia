select e.id_empleado,e.nombre,v.fecha,p.nombre,p.categoria,dv.cantidad,dv.subtotal
from Empleados e,Ventas v,Detalle_Venta dv,Productos p
where e.id_empleado = v.id_empleado
and v.id_venta = dv.id_venta
and dv.id_producto = p.id_producto
and v.fecha = '2004/01/02'

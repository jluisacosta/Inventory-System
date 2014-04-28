select e.id_empleado,e.nombre,count(v.id_venta),v.total
from Empleados e,Ventas v
where e.id_empleado = v.id_empleado
and v.id_venta = dv.id_venta
and dv.id_producto = p.id_producto
and v.fecha = '2004/01/02'

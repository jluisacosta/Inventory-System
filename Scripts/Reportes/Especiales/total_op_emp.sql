
3.- Total de ordenes de produccion hechas por un empleado en especi­fico para un determinado producto en un 
     rango de fecha. 
    (Datos del empleado,producto,fecha,cantidad)

select e.id_empleado,e.nombre,p.id_producto,concat(p.categoria,' de ',p.nombre) as producto,count(op.id_empleado) as ordenes
from ordenes_produccion op, empleados e, productos p
where op.id_empleado = e.id_empleado 
and op.id_producto = p.id_producto
and op.id_empleado = 22
and op.id_producto = 6
and op.fecha_inicio >= '2004/01/02' and op.fecha_inicio < '2005/03/03'
group by op.id_empleado


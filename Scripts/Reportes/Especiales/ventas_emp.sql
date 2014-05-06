
select e.id_empleado,e.nombre,count(v.id_venta) as n_ventas,v.total
from Empleados e,Ventas v
where e.id_empleado = v.id_empleado
and v.fecha >= '2004/01/01'
and v.fecha <= '2004/01/01'
group by e.id_empleado
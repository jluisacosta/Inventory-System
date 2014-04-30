
select op.id_orden_produccion,op.fecha_inicio, e.id_empleado, e.nombre as empleado, p.nombre as produto,op.cantidad,
mp.id_materia, mp.nombre,mp.stock,op.cantidad * mpp.cantidad as cant, mp.unidad
from ordenes_produccion op, productos p, materias_primas mp, materiaporproducto mpp, empleados e
where op.id_producto = p.id_producto
and p.id_producto = mpp.id_producto
and mpp.id_materia = mp.id_materia
and op.id_empleado = e.id_empleado
and op.id_orden_produccion =  50000

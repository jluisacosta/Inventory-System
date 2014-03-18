

select e.id_empleado,e.nombre,m.tipo_movimiento,mp.nombre,dm.cantidad,m.fecha
from Empleados e,Movimientos m,Detalle_Movimiento dm,Materias_Primas mp
where e.id_empleado = m.id_empleado
and m.id_movimiento = dm.id_movimiento
and dm.id_materia_prima = mp.id_materia
and m.fecha = '2004/01/01'

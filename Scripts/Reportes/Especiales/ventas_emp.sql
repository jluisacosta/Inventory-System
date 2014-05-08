
select e.id_empleado,e.nombre,count(v.id_venta) as n_ventas,v.total
from Empleados e,Ventas v
where e.id_empleado = v.id_empleado
and v.fecha >= '2004/01/01'
and v.fecha <= '2004/01/01'
group by e.id_empleado


select * from usuarios
select * from empleados

INSERT INTO Empleados(id_usuario,id_tipo_empleado,nombre,fecha_nacimiento,direccion,telefono,email,departamento)VALUES(1,1,'Hayfa Burns Mccullough','17/03/1982','661-5287 Vulputate Street','061-358-2765','Etiam.imperdiet.dictum@sedtortorInteger.edu','Ventas')

select * from tipos_empleados

update Clientes set ciudad = 'Mexico', cp = 12135 where id_cliente = 300

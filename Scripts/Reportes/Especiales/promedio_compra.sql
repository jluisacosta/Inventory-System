
4.- Obtener el promedio de compra en cada visita de todos los clientes, en un rango de fecha
    ordenar por promedio

select v.id_venta,c.id_cliente,c.razon_social,c.rfc,c.telefono,c.email, AVG(v.total) promedio
from clientes c, facturas f, ventas v
where c.id_cliente = f.id_cliente
and f.id_venta = v.id_venta
and v.fecha >= '2004/01/02' and v.fecha < '2004/02/02'
group by f.id_cliente
order by promedio desc
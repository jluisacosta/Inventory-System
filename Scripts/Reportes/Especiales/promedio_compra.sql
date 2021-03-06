
4.- Obtener el promedio de compra en cada visita de todos los clientes, en un rango de fecha
    ordenar por promedio

select c.id_cliente,c.razon_social,c.rfc,c.telefono,c.email,count(v.id_venta) ventas,AVG(v.total) promedio
from clientes c, facturas f, ventas v
where c.id_cliente = f.id_cliente
and f.id_venta = v.id_venta
and v.fecha >= '2004/01/02' and v.fecha < '2004/02/02'
group by c.id_cliente
order by promedio desc

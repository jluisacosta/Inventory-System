select c.id_cliente,c.razon_social,c.telefono,c.email,count(c.id_cliente) as "Total de facturas"
from Clientes c, Ventas v, Facturas f
where v.id_venta = f.id_venta
and c.id_cliente = f.id_cliente
and v.fecha >= '2004/01/02' and v.fecha < '2005/01/02'
group by c.id_cliente
select c.id_cliente,c.razon_social,c.telefono,c.email,count(c.id_cliente) as "Total de facturas",
sum(v.total) as Subtotal,v.iva/100,(sum(v.total)*v.iva/100) as IVA_APLICADO,(sum(v.total)+(sum(v.total)*v.iva/100)) as Total
from Facturas f,Clientes c,Ventas v
where c.id_cliente = f.id_cliente
and v.id_venta = f.id_venta
and f.fecha >= '2004/01/01' and f.fecha <= '2006/01/05'
group by c.id_cliente;

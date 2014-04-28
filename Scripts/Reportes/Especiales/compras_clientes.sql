select c.id_cliente,c.rfc,c.razon_social,v.fecha,concat(p.categoria,' de ',p.nombre) as producto,dv.cantidad,dv.subtotal
from clientes c,facturas f,ventas v,detalle_venta dv,productos p
where c.id_cliente = f.id_cliente
and f.id_venta = v.id_venta
and v.id_venta = dv.id_venta
and dv.id_producto = p.id_producto
and v.fecha >= '2004/01/01'
and v.fecha <= '2004/01/02'
order by c.id_cliente 
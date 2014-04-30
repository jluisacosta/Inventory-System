

select f.id_factura, v.fecha, c.razon_social,c.direccion, c.cp,c.ciudad,c.telefono,concat(p.categoria,' de ',p.nombre) as concepto,dv.cantidad cant,p.precio pu, dv.subtotal as importe
from productos p,detalle_venta dv,clientes c, facturas f, ventas v
where p.id_producto = dv.id_producto
and c.id_cliente = f.id_cliente
and f.id_venta = v.id_venta
and v.id_venta = dv.id_venta
and f.id_factura = 100

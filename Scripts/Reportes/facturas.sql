
select f.id_factura, v.fecha, c.razon_social,c.rfc,c.ciudad,c.cp,c.direccion,c.telefono,c.email,p.id_producto as codigo,
concat(p.categoria,' de ',p.nombre) as concepto,dv.cantidad cant,p.precio pu, dv.subtotal as importe
from productos p,detalle_venta dv,clientes c, facturas f, ventas v
where p.id_producto = dv.id_producto 
and c.id_cliente = f.id_cliente 
and f.id_venta = v.id_venta 
and v.id_venta = dv.id_venta
and f.id_factura = 1557;


SELECT     f.id_factura, v.fecha, c.razon_social, c.rfc, c.ciudad, c.cp, c.direccion, c.telefono, c.email, p.id_producto AS codigo, CONCAT(p.categoria, ' de ', p.nombre)
			    AS concepto, dv.cantidad AS cant, p.precio AS pu, dv.subtotal AS importe
FROM         facturas f INNER JOIN clientes c ON (f.id_cliente = c.id_cliente)
                        INNER JOIN  ventas v ON (f.id_venta = v.id_venta) 
						INNER JOIN detalle_venta dv ON v.id_venta = dv.id_venta
						INNER JOIN productos p ON (p.id_producto = dv.id_producto) 
WHERE     (f.id_factura = 1557)

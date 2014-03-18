
select distinct(P.rfc),P.razon_social,P.direccion,P.telefono,P.email
from Ordenes_Compra OC,Proveedores P
where OC.id_proveedor = P.id_proveedor
and OC.fecha_pedido >= '2004/01/01' and OC.fecha_pedido < '2008/03/01'


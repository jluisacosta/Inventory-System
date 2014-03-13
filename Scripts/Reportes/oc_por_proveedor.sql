select P.id_proveedor,P.razon_social, count(*), sum(costo_total) as Total 
from Ordenes_Compra OC,Proveedores P
where OC.id_proveedor = P.id_proveedor
and OC.fecha_pedido >= '2004/01/01' and OC.fecha_pedido < '2005/03/01'
group by id_proveedor

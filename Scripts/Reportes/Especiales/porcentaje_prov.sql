use si_inventarios;

select mp.id_materia,mp.nombre,p.razon_social,count(mp.id_materia) as ordenes,sum(oc.costo_total) as Total
from materias_primas mp, ordenes_compra oc, detalle_compra dc, proveedores p
where mp.id_materia = dc.id_materia_prima 
and oc.id_orden_compra = dc.id_orden_compra
and oc.id_proveedor = p.id_proveedor
and oc.fecha_pedido >= '2004/01/02' and oc.fecha_pedido < '2004/02/02'
group by oc.id_proveedor
order by Total desc limit 10
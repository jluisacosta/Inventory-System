

select p.id_producto,concat(p.categoria,' de ',p.nombre) as Producto,sum(dv.cantidad) as "Cantidad", sum(dv.subtotal) as "Total" 
from Productos p,Ventas v,Detalle_Venta dv
where p.id_producto = dv.id_producto
and v.id_venta = dv.id_venta
and v.fecha >= '2004/01/02' and v.fecha < '2004/02/02'
group by p.id_producto
order by "Total" desc limit 10



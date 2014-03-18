
select c.id_cliente,c.razon_social,c.telefono,c.email,count(c.id_cliente) as "Total de facturas"
from Clientes c, Ventas v, Facturas f
where v.id_venta = f.id_venta
and c.id_cliente = f.id_cliente
and v.fecha >= '2004/01/01' and v.fecha <= '2004/01/01'
group by c.id_cliente;

select c.id_cliente,c.razon_social,c.telefono,c.email,count(c.id_cliente) as "Total de facturas"
from Facturas f,Clientes c
where c.id_cliente = f.id_cliente
group by c.id_cliente;

/*Copia fechas de la tabla ventas a la tabla facturas*/
update Facturas Set fecha = F.fecha
	where id_factura in (
		select F.id_factura,V.fecha
		from Ventas v inner join Facturas F on (v.id_venta = F.id_venta)
		);

select * from ventas

alter table facturas
add column fecha date null;
select * from facturas

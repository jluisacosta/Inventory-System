
insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,tipo_articulo,unidad) values
				(null,'MP','Leche','Ultrapasteurizada',12.90,50,10,40,'2013/01/01','MateriaPrima','Litros');


insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,tipo_articulo,unidad) values
				(null,'MP','Harina','Harina blanca',11.20,50,10,30,'2013/01/01','MateriaPrima','Kilogramos');

insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,tipo_articulo,unidad) values
				(null,'MP','Huevo','18 piezas',32.20,50,15,40,'2013/01/01','MateriaPrima','Paquete');

insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,tipo_articulo,unidad) values
				(null,'MP','Crema chatillí','5kg por carton',75.00,8,4,15,'2013/01/01','MateriaPrima','Carton');

insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,tipo_articulo,unidad) values
				(null,'MP','Azucar','Azucar morena agranel',14.90,80,20,90,'2013/01/01','MateriaPrima','Kilogramos');

insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,tipo_articulo,unidad) values
				(null,'MP','Mantequilla','Con sal', 93.00,50,30,80,'2013/01/01','MateriaPrima','Kilogramo');

insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,tipo_articulo,unidad) values
				(null,'MP','Levadura','Royal',,5,2,6,'2013/01/01','MateriaPrima','Kilogramos');


insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,tipo_articulo,unidad) values
				(null,'MP','Cacao','Royal',,5,2,6,'2013/01/01','MateriaPrima','Kilogramos');


insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,tipo_articulo,unidad) values
				(null,'MP','Chocolate','Royal',60.00,5,2,6,'2013/01/01','MateriaPrima','Kilogramo');



cacao
nuez
vainilla
chocolate


select * from Inventarios
where categoria = 'Pasteles';

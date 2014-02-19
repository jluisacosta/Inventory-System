

insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,fecha_ingreso,tipo_articulo,unidad) 
values	(null,'Pasteles','Fresa','Hecho de leche',120,5,2,10,'2013/01/01','Producto','Pieza');

insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,fecha_ingreso,tipo_articulo,unidad) values
				(null,'Pasteles','Vainilla','Hecho de leche',127,5,2,10,'2013/01/01','Producto','Pieza');

insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,fecha_ingreso,tipo_articulo,unidad) values
				(null,'Pasteles','Chocolate','Hecho de leche',120,5,2,10,'2013/01/01','Producto','Pieza');

insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,fecha_ingreso,tipo_articulo,unidad) values
				(null,'Pasteles','Nuez','Hecho de leche',100,5,1,10,'2013/01/01','Producto','Pieza');

insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,fecha_ingreso,tipo_articulo,unidad) values
				(null,'Pasteles','Selva Negra','Pan seco',130,5,3,10,'2013/01/01','Producto','Pieza');

insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,fecha_ingreso,tipo_articulo,unidad) values
				(null,'Pasteles','Suizo','Pan seco',140,5,3,10,'2013/01/01','Producto','Pieza');

insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,fecha_ingreso,tipo_articulo,unidad) values
				(null,'Galletas','Chocolate','Con chispas',20,10,4,20,'2013/01/01','Producto','Paquete');

insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,fecha_ingreso,tipo_articulo,unidad) values
				(null,'Galletas','Glaseadas','Con Nuez',28,12,5,20,'2013/01/01','Producto','Paquete');

insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,fecha_ingreso,tipo_articulo,unidad) values
				(null,'Galletas','Vainilla','...',17,8,3,20,'2013/01/01','Producto','Paquete');

insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,fecha_ingreso,tipo_articulo,unidad) values
				(null,'Muffins','Chocolate','Con chispas de chocolate blanco',15,5,2,15,'2013/01/01','Producto','Pieza');

insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,fecha_ingreso,tipo_articulo,unidad) values
				(null,'Muffins','Amapola','De la buena',18,10,5,15,'2013/01/01','Producto','Pieza');

insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,fecha_ingreso,tipo_articulo,unidad) values
				(null,'CupCakes','Red Velvet','Terciopelo Rojo',26,10,5,20,'2013/01/01','Producto','Pieza');

insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,fecha_ingreso,tipo_articulo,unidad) values
				(null,'Pays','Menta con Chocolate','Menta...',130,15,5,25,'2013/01/01','Producto','Pieza');

insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,fecha_ingreso,tipo_articulo,unidad) values
				(null,'Pays','Queso','Queso crema',25,15,5,25,'2013/01/01','Producto','Pieza');

insert into Inventarios(id_proveedor,categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,fecha_ingreso,tipo_articulo,unidad) values
				(null,'Pays','Limon','Limon dulce',22,12,4,25,'2013/01/01','Producto','Pieza');

set SQL_SAFE_UPDATES=0;

update Inventarios set stock = stock + 15;



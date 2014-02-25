/*
-- Query: SELECT * FROM si_inventarios.Inventarios
-- Date: 2014-02-19 17:33
*/
INSERT INTO `Productos` (`categoria`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES ('Pasteles','Fresa','Hecho de leche',120.00,13,2,10,'2013-01-01','Pieza');
INSERT INTO `Productos` (`categoria`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES ('Pasteles','Vainilla','Hecho de leche',127.00,15,2,10,'2013-01-01','Pieza');
INSERT INTO `Productos` (`categoria`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES ('Pasteles','Chocolate','Hecho de leche',120.00,6,2,10,'2013-01-01','Pieza');
INSERT INTO `Productos` (`categoria`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES ('Pasteles','Nuez','Hecho de leche',100.00,9,1,10,'2013-01-01','Pieza');
INSERT INTO `Productos` (`categoria`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES ('Pasteles','Selva Negra','Pan seco',130.00,15,3,10,'2013-01-01','Pieza');
INSERT INTO `Productos` (`categoria`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES ('Pasteles','Suizo','Pan seco',140.00,15,3,10,'2013-01-01','Pieza');
INSERT INTO `Productos` (`categoria`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES ('Galletas','Chocolate','Con chispas',20.00,15,4,20,'2013-01-01','Paquete');
INSERT INTO `Productos` (`categoria`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES ('Galletas','Glaseadas','Con Nuez',28.00,21,5,20,'2013-01-01','Paquete');
INSERT INTO `Productos` (`categoria`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES ('Galletas','Vainilla','...',17.00,22,3,20,'2013-01-01','Paquete');
INSERT INTO `Productos` (`categoria`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES ('Muffins','Chocolate','Con chispas de chocolate blanco',15.00,10,2,15,'2013-01-01','Pieza');
INSERT INTO `Productos` (`categoria`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES ('Muffins','Amapola','De la buena',18.00,14,5,15,'2013-01-01','Pieza');
INSERT INTO `Productos` (`categoria`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES ('CupCakes','Red Velvet','Terciopelo Rojo',26.00,20,5,20,'2013-01-01','Pieza');
INSERT INTO `Productos` (`categoria`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES ('Pays','Menta con Chocolate','Menta...',130.00,25,5,25,'2013-01-01','Pieza');
INSERT INTO `Productos` (`categoria`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES ('Pays','Queso','Queso crema',25.00,20,5,25,'2013-01-01','Pieza');
INSERT INTO `Productos` (`categoria`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES ('Pays','Limon','Limon dulce',22.00,20,4,25,'2013-01-01','Pieza');

INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (20,'Leche','Ultrapasteurizada',12.90,50,10,40,'2013-01-01','Litros');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (22,'Harina','Harina blanca',11.20,50,10,30,'2013-01-01','Kilogramos');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (44,'Huevo','18 piezas',32.20,50,15,40,'2013-01-01','Kilogramos');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (1,'Crema chatillí','5kg por carton',75.00,40,10,25,'2013-01-01','Kilogramos');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (10,'Azucar','Azucar morena agranel',14.90,80,20,90,'2013-01-01','Kilogramos');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (28,'Mantequilla','Con sal',93.00,50,30,80,'2013-01-01','Kilogramos');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (33,'Levadura','Royal',17.45,5,2,6,'2013-01-01','Kilogramos');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (3,'Cacao','Hershys',45.76,5,2,6,'2013-01-01','Kilogramos');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (16,'Chocolate','Amargo',60.00,5,2,6,'2013-01-01','Kilogramos');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (33,'Nuez','Moscada',72.00,8,3,6,'2013-01-01','Kilogramos');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (7,'Vainilla','Extracto',33.80,5,1,2,'2013-01-01','Litros');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (21,'Piña','En almibar',38.89,4,1,2,'2013-01-01','Kilogramos');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (38,'Durazno','En almibar',43.50,4,1,2,'2013-01-01','Kilogramos');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (46,'Fresa','Pico de pàjaro',34.67,12,4,8,'2013-01-01','Kilogramos');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (15,'Queso crema','-------',79.00,8,3,6,'2013-01-01','Kilogramos');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (18,'Manzana','Red delicious',18.30,6,2,4,'2013-01-01','Kilogramos');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (12,'Menta','Extracto',130.00,2,1,1,'2013-01-01','Litros');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (28,'Azùcar glass','Ultrafina',13.45,4,2,2,'2013-01-01','Kilogramos');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (9,'Limon','Concentrado',65.00,3,1,2,'2013-01-01','Litros');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (36,'Semilla de amapola','Importada',67.80,2,1,1,'2013-01-01','Kilogramos');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (22,'Sal','La Fina',7.00,5,2,3,'2013-01-01','Kilogramos');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (22,'Bicarbonato de sodio','Puro',16.00,2,1,2,'2013-01-01','Kilogramos');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (36,'Chispas de chocolate','Semiamargo',37.00,4,2,3,'2013-01-01','Kilogramos');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (10,'Canela','En polvo',60.00,1,1,1,'2013-01-01','Kilogramos');
INSERT INTO `Materias_Primas` (`id_proveedor`,`nombre`,`descripcion`,`precio`,`stock`,`stock_minimo`,`stock_maximo`,`fecha_ingreso`,`unidad`) VALUES (32,'Colorante rojo','Para red velvet',27.50,1,1,1,'2013-01-01','Kilogramos');

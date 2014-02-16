
SET SQL_SAFE_UPDATES=0;

SET @fechaAct = '2004/01/01';
call iniSimulacion();
select @fechaAct;

select * from Ventas;
select * from Detalle_Venta;
select * from Empleados;
delete from Ventas;
delete from Detalle_Venta;

INSERT INTO Empleados (id_usuario,id_tipo_empleado,nombre,fecha_nacimiento,direccion,telefono,email,departamento) VALUES (1,1,"Aiko Carpenter Buchanan","1994-05-30 23:26:42","P.O. Box 222, 7211 Cras Road","002-049-7769","malesuada@lobortisClassaptent.com","Produccion");
INSERT INTO Detalle_Venta(id_venta,id_articulo,cantidad,subtotal) VALUES(1426,2,5,15.0);

select * from Tipos_Empleados;
select * from Usuarios

insert into Tipos_Empleados(nombre,descripcion)VALUES('Ventas','dsfs');
insert into Usuarios(user_login,user_password)VALUES('mike','mike');

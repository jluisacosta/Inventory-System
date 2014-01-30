
create table Proveedores
(
	id_proveedor serial not null,

	razon_social varchar(50) not null,
	rfc varchar(15) not null,
	contacto varchar(50) not null,
	ciudad varchar(50) not null,
	direccion varchar(50) not null, 
	telefono varchar(15) not null,
	email varchar(50) not null,

	constraint PK_PROV primary key(id_proveedor)
);


create table Empleados
(
	id_empleado serial not null,
	nombre varchar(50) not null,
	puesto varchar(50) not null,
	departamento varchar(50) not null,
	direccion varchar(50) not null,
	telefono varchar(15) not null,
	email varchar(50) not null,

	constraint PK_EMP primary key(id_empleado)
);

create table Clientes
(
	id_cliente serial not null,
	nombre varchar(50) not null,
	razon_social varchar(50) not null,
	rfc varchar(15) not null,
	direccion varchar(50) not null,
	telefono varchar(15) not null,
	email varchar(50) not null,

	constraint PK_CLI primary key(id_cliente)
);

create table Materias_Primas
(
	id_materia serial not null,
	nombre varchar(50) not null,
	estado varchar(20) not null,
	costo decimal(10,2) not null,
	existencia int not null,
	descripcion varchar(100) not null,

	constraint PK_MAT primary key(id_materia)
);

create table Productos
(
	id_producto serial not null,
	nombre varchar(50) not null,
	precio decimal(8,2) not null,
	descripcion varchar(100) not null,
	existencia int not null,

	constraint PK_PROD primary key(id_producto)
);

create table Materias_Primas_Por_Producto
(
	id_producto bigint not null,
	id_materia bigint not null,
	cantidad int not null,
	unidad varchar(10) not null,

	constraint FK_PROD foreign key(id_producto) references Productos(id_producto),
	constraint FK_MAT foreign key(id_materia ) references Materias_Primas(id_materia)
);


create table Ordenes_Compra
(
	id_orden_compra serial not null,
	fecha_pedido date not null,
	fecha_pago date not null,
	costo_total decimal(10,2) not null,
	
	id_empleado bigint not null,
	id_proveedor bigint not null,

	constraint PK_ORDEN_C primary key(id_orden_compra),
	constraint FK_EMP foreign key(id_empleado) references Empleados(id_empleado),
	constraint FK_PROV foreign key(id_proveedor) references Proveedores(id_proveedor)
);

create table Detalle_Ordenes_Compra
(
	id_orden_compra bigint not null,
	id_materia bigint not null,
	cantidad int not null,
	subtotal decimal(10,2) not null,

	constraint FK_ORD_C foreign key(id_orden_compra) references Ordenes_Compra(id_orden_compra),
	constraint FK_MAT foreign key(id_materia) references Materias_Primas(id_materia)
);

create table Ordenes_Produccion
(
	id_orden_produccion serial not null,
	fecha_inicio date not null,
	fecha_entrega date not null,
	id_empleado bigint not null,
	id_producto bigint not null,
	cantidad int not null,

	constraint PK_ORDEN_P primary key(id_orden_produccion),
	constraint FK_EMP foreign key(id_empleado) references Empleados(id_empleado),
	constraint FK_PROD foreign key(id_producto) references Productos(id_producto)
);

create table Requisiciones_Material
(
	id_requisicion serial not null,
	fecha date not null,
	id_orden_produccion bigint not null,
	id_empleado bigint not null,

	constraint PK_ORDEN_R primary key(id_requisicion),
	constraint FK_EMP foreign key(id_empleado) references Empleados(id_empleado),
	constraint FK_OR_PROD foreign key(id_orden_produccion) references Ordenes_Produccion(id_orden_produccion)
);

create table Ventas
(
	id_venta serial not null,
	fecha date not null,
	id_empleado bigint not null,
	iva decimal(8,2) not null,
	total decimal(10,2) not null,

	constraint PK_VENTA primary key(id_venta),
	constraint FK_EMP foreign key(id_empleado) references Empleados(id_empleado)
);

create table Detalle_Venta
(
	id_venta bigint not null,
	id_producto bigint not null,
	cantidad int not null,
	subtotal decimal(8,2) not null,

	constraint FK_VENT foreign key(id_venta) references Ventas(id_venta),
	constraint FK_PROD foreign key(id_producto) references Productos(id_producto)
);

create table Facturas
(
	id_factura serial not null,
	id_venta bigint not null,
	id_cliente bigint not null,
	
	constraint PK_FACT primary key(id_factura,id_venta,id_cliente),
	constraint FK_VNT foreign key(id_venta) references Ventas(id_venta),
	constraint FK_CLIENTE foreign key(id_cliente) references Clientes(id_cliente)
);

create table Proveedores_Materia_Prima
(
	id_proveedor bigint not null,
	id_materia bigint not null,

	constraint FK_PROV foreign key(id_proveedor) references Proveedores(id_proveedor),
	constraint FK_MAT foreign key(id_materia) references Materias_Primas(id_materia)
);

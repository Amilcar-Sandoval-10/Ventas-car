create database [Venta_car]
go
use Venta_car
go
--- Creando tabla de la empresa ---
create table Empresa(
Id_empresa int primary key identity (1,1) not null,
Nombre nvarchar (50) not null,
Direccion nvarchar (max) not null,
Telefono int not null,
--check(Telefono Like'[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)
go

--- Creando tabla de Empleado ---
Create Table Empleado (
Id_empleado int primary key identity (1,1) Not Null,
Id_empresa int foreign key references Empresa(Id_empresa) not null,
Nombre Nvarchar (30) Not Null,
Apellido Nvarchar (30) Not Null,
Inss Nvarchar (12) not Null,
Fecha_nac Nvarchar (15) Not Null,
Genero Char (1) not Null,
Direccion Nvarchar (Max) not Null,
No_cedula nvarchar (16) not null,
check (No_cedula like '[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][A-Z]'),
Telefono Nvarchar (15) not Null,
--check (Telefono like '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'),
Estado_civil Nvarchar (12) Not Null,
Email Nvarchar (80) not Null
)
go


--- Creando tabla de Usuario ---
Create Table Usuario (
Id_usuario int primary key identity (1,1) Not Null,
Id_empleado int foreign key references Empleado(Id_empleado) not null,
Usuario Nvarchar (20) Not Null,
Contraseña Nvarchar (20) Not Null,
Tipo_usuario Nvarchar (20) Not Null
)
go

--- Creando tabla de Inventario ---
create table Inventario(
Id_producto int primary key identity (1,1) not null,
Marca nvarchar(50) not null,
Modelo nvarchar(50) not null,
Precio float not null,
Stock_max int not null,
Stock_min int not null,
Stock int not null
)
go

--- Creando tabla de Clientes ---
create table Clientes
(
Id_cliente int primary key identity (1,1) not null,
No_cedula nvarchar (16) not null,
check (No_cedula like '[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][A-Z]'),
Nombre nvarchar (18) not null,
Apellido nvarchar (30) not null,
Telefono int not null,
--check (Telefono like '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'),
Direccion nvarchar (MAX) not null,
Ciudad nvarchar (25) not null,
Email nvarchar (MAX)not null
)
go


--- Creando tabla de Proveedores ---
create table Proveedores
(
Id_proveedor int primary key  identity (1,1)not null,
No_cedula nvarchar (16)not null,
--check (No_cedula like '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][A-Z]'),
Nombre nvarchar (18) not null,
Apellido nvarchar (18) not null,
Telefono_personal int not null,
--check (Telefono_personal like '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'),
Telefono_empresa int not null,
--check (Telefono_empresa like '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'),
Email nvarchar (MAX) not null
)
go

--- Creando tabla de compra ---

create table Compra(
Id_compra int primary key identity (1,1) not null,
Id_proveedor int references Proveedores(Id_proveedor) not null,
Id_Producto int references Inventario(Id_Producto) not null,
Fecha_compra nvarchar (20) not null,
Precio_compra float not null, 
cantidad int not null,
subtotal float not null,
Iva float not null,
Descuento float not null,
Stock float not null
)


--- Creando tabla de ventas ---
create table Venta
(
Id_venta int primary key identity (1,1) not null,
Id_producto int foreign key references Inventario (Id_producto) not null,
Id_cliente int foreign key references Clientes (Id_cliente) not null,
Fecha_venta nvarchar (20) not null,
Precio_venta float not null,
stock int not null,
Iva float not null,
Descuento float not null,
total float not null
)
go


--- CREANDO PROCEDIMIENTOS ALMACENADOS --- 

--- CREANDO PROCEDIMIENTOS ALMACENADOS PARA EMPRESA --- 
--Insertar Empresa 

if object_Id ('Insertar_Empresa') is not null
begin 
drop proc Insertar_Empresa
end
go

Create proc Insertar_Empresa       ----Good-----
@Nombre nvarchar (50) ,
@Direccion nvarchar (max),
@Telefono int 
as
begin
insert into Empresa (Nombre, Direccion, Telefono)
values (@Nombre, @Direccion, @Telefono)
end
go

--Eliminar Empresa

if object_id ('Eliminar_Empresa') is not null
begin
drop proc Eliminar_Empresa
end
go

Create proc Eliminar_Empresa    ---Good-------
@Id_empresa int
As 
begin
Delete  Empresa where Id_empresa = @Id_empresa
end
go


--Editar Empresa

if object_id ('Editar_empresa') is not null
begin
drop proc Editar_empresa
end
go

Create proc Editar_empresa     -----Good--------
@Id_empresa int,
@Nombre nvarchar (50) ,
@Direccion nvarchar (max),
@Telefono int 
as
begin
Update Empresa set Nombre=@Nombre,Direccion=@Direccion,Telefono=@Telefono where Id_empresa=@Id_empresa
end
go


--Buscar Empresa

if object_id ('Buscar_empresa') is not null
begin
drop proc Buscar_empresa
end
go

Create proc Buscar_empresa       -----Good----
@Id_empresa int
as
begin 
select * from Empresa where @Id_empresa=Id_empresa
end
go



--- CREANDO PROCEDIMIENTOS ALMACENADOS PARA EMPLEADO --- 

--Insertar venta ---

if object_id ('insertar_empleado') is not null
begin
drop proc insertar_empleado
end
go

create proc insertar_empleado   -----Good-----
@Id_empresa int,
@Nombre Nvarchar (30),
@Apellido Nvarchar (30),
@Inss Nvarchar (12),
@Fecha_nac Nvarchar (15),
@Genero Char (1),
@Direccion Nvarchar (Max),
@No_cedula nvarchar (16),
@Telefono Nvarchar (15),
@Estado_civil Nvarchar (12),
@Email Nvarchar (80)
as 
begin
insert into Empleado (Id_empresa,Nombre,Apellido,Inss,Fecha_nac,Genero,Direccion,No_cedula,Telefono,Estado_civil,Email)
values (@Id_empresa,@Nombre,@Apellido,@Inss,@Fecha_nac,@Genero,@Direccion,@No_cedula,@Telefono,@Estado_civil,@Email)
end
go


--Editar Empelado ---

if object_id ('editar_empleado') is not null
begin
drop proc editar_empleado
end
go

create proc editar_empleado   -----Good-----
@Id_empleado int,
@Id_empresa int,
@Nombre Nvarchar (30),
@Apellido Nvarchar (30),
@Inss Nvarchar (12),
@Fecha_nac Nvarchar (15),
@Genero Char (1),
@Direccion Nvarchar (Max),
@No_cedula nvarchar (16),
@Telefono Nvarchar (15),
@Estado_civil Nvarchar (12),
@Email Nvarchar (80)
as 
begin
update Empleado set Id_empresa=@Id_empresa, Nombre=@Nombre, Apellido=@Apellido,Inss=@Inss,Fecha_nac=@Fecha_nac,
Genero=@Genero,Direccion=@Direccion,No_cedula=@No_cedula,Telefono=@Telefono, Estado_civil=@Estado_civil, Email=@Email
where Id_empleado=@Id_empleado
end
go


--Eliminar emplado ---

if object_id ('Eliminar_Empleado') is not null
begin
drop proc Eliminar_Empleado
end
go

create proc Eliminar_Empleado     ----Good-----
@Id_empleado int 
as
begin
Delete  Empleado where Id_empleado=@Id_empleado
end
go


--- Buscar empleado ---

if object_id ('Buscar_Empleado') is not null
begin
drop proc Buscar_Empleado
end
go

Create proc Buscar_Empleado   ----Good------
@Id_Empleado int
as
begin 
select * from Empleado where @Id_Empleado=Id_empleado
end
go



--- CREANDO PROCEDIMIENTOS ALMACENADOS PARA USUARIO --- 
--Insertar Usuario----------

if OBJECT_ID ('Insertar_usuario') is not null
begin 
drop proc Insertar_usuario 
end
go

Create proc Insertar_usuario    ----Good------
@Id_empleado int,
@Usuario Nvarchar (20),
@Contraseña Nvarchar (20),
@Tipo_Usuario Nvarchar (20)
as
begin
insert into Usuario  (Id_empleado, Usuario, Contraseña, Tipo_Usuario )
values ( @Id_empleado, @Usuario, @Contraseña, @Tipo_Usuario )
end
go


--Elimina Usuario

if OBJECT_ID ('Eliminar_usuario') is not null
begin 
drop proc Eliminar_usuario 
end
go

create proc Eliminar_usuario     ----Good----
@Id_Usuario int 
as
begin
Delete Usuario where @Id_Usuario=@Id_Usuario
end
go


--Editar Usuario-----

if OBJECT_ID ('Editar_usuario') is not null
begin 
drop proc Editar_usuario
end
go

Create proc Editar_usuario     ----Good----
@Id_Usuario Int, 
@Id_empleado int,
@Usuario Nvarchar (20),
@Contraseña Nvarchar (20),
@Tipo_Usuario Nvarchar (20)
as
begin
update Usuario set Id_empleado= @Id_empleado, Usuario=@Usuario ,Contraseña =@Contraseña, Tipo_Usuario=@Tipo_Usuario 
where Id_Usuario=@Id_Usuario
end
go


--Buscar Usuario----

if OBJECT_ID ('Buscar_Usuario') is not null
begin 
drop proc Buscar_Usuario
end
go


Create proc Buscar_Usuario    ---Good------
@Id_Usuario int
as
begin 
select * from Usuario where @Id_Usuario=@Id_Usuario
end
go


--Validacion de usuario 

create proc AccesoUsuario
@usuario  Nvarchar (20),
@contraseña  Nvarchar (20),
@Tipo_usuario  Nvarchar (20)
as
select * from Usuario where Usuario = @usuario and Contraseña = @contraseña and Tipo_usuario = @Tipo_usuario



--- CREANDO PROCEDIMIENTOS ALMACENADOS PARA INVENTARIO --- 

--Insertar Inventario 

if OBJECT_ID ('Insertar_inventario') is not null
begin 
drop proc Insertar_inventario 
end
go

Create proc Insertar_inventario    ----Good---
@Marca nvarchar(50),
@Modelo nvarchar(50),
@Precio float,
@Stock_max int,
@Stock_min int,
@Stock int 
as
begin
insert into Inventario (Marca ,Modelo, Precio, Stock_max, Stock_min, Stock )
values (@Marca ,@Modelo, @Precio, @Stock_max, @Stock_min, @Stock )
end
go


--Elimina Inventario----

if OBJECT_ID ('Eliminar_inventario') is not null
begin 
drop proc Eliminar_inventario
end
go

create proc Eliminar_inventario    ----Good-----
@Id_producto int 
as
begin 
Delete  Inventario where Id_producto=@Id_producto
end
go


--Editar Inventario-------

if OBJECT_ID ('Editar_inventario') is not null
begin 
drop proc Editar_inventario 
end
go

Create proc Editar_inventario    ----Good-----
@Id_producto int,
@Marca nvarchar(50),
@Modelo nvarchar(50),
@Precio float,
@Stock_max int,
@Stock_min int,
@Stock int 
as
begin
Update Inventario set Marca=@Marca, Modelo= @Modelo, Precio= @Precio, Stock_max= @Stock_max, Stock_min=@Stock_min, Stock = @Stock  
where Id_producto=@Id_producto
end
go

--Buscar Inventario--------

if OBJECT_ID ('Buscar_inventario') is not null
begin 
drop proc Buscar_inventario 
end
go

Create proc Buscar_inventario     ----Good-----
@Id_producto int
as
begin 
select * from Inventario where @Id_producto=Id_producto
end
go


--- CREANDO PROCEDIMIENTOS ALMACENADOS PARA CLIENTES --- 


--Insertar Clientes 

if OBJECT_ID ('Insertar_cliente ') is not null
begin 
drop proc Insertar_cliente  
end
go

Create proc Insertar_cliente    ---Good---------
@No_cedula nvarchar (16) ,
@Nombre nvarchar (30),
@Apellido  nvarchar (30),
@Telefono int,
@Direccion nvarchar (MAX),
@Ciudad nvarchar (25),
@Email nvarchar (MAX)
as
begin
insert into Clientes  (No_cedula,Nombre, Apellido, Telefono, Direccion, Ciudad ,Email)
values (@No_cedula,@Nombre, @Apellido, @Telefono, @Direccion, @Ciudad ,@Email)
end
go



--Eliminar clientes

if OBJECT_ID ('Eliminar_cliente') is not null
begin 
drop proc Eliminar_cliente   
end
go

Create proc Eliminar_cliente     ---.Good-----
@Id_cliente int
As 
begin
Delete  Clientes where Id_cliente = @Id_cliente
end
go


--Editar clientes

if OBJECT_ID ('Editar_clientes') is not null
begin 
drop proc Editar_clientes  
end
go

Create proc Editar_clientes     ----Good----
@Id_cliente int,
@No_cedula nvarchar (16) ,
@Nombre nvarchar (30),
@Apellido  nvarchar (30),
@Telefono int,
@Direccion nvarchar (MAX),
@Ciudad nvarchar (25),
@Email nvarchar (MAX)
as
begin
Update Clientes set No_cedula=@No_cedula,Nombre= @Nombre, Apellido= @Apellido, Telefono= @Telefono, Direccion=@Direccion, Ciudad= @Ciudad , Email=@Email 
where Id_cliente=@Id_cliente
end
go


--Buscar cliente

if OBJECT_ID ('Buscar_cliente') is not null
begin 
drop proc Buscar_cliente  
end
go

Create proc Buscar_cliente   ----Good----
@Id_cliente int
as
begin 
select * from clientes 
where @Id_cliente=Id_cliente 
end
go


--- CREANDO PROCEDIMIENTOS ALMACENADOS PARA PROVEEDOR --- 


--Insertar proveedor 


if OBJECT_ID (' Insertar_proveedor') is not null
begin 
drop proc  Insertar_proveedor  
end
go

Create proc Insertar_proveedor   ----no----
@No_cedula nvarchar (16),
@Nombre nvarchar (30),
@Apellido nvarchar (30),
@Telefono_personal int,
@Telefono_empresa int,
@Email nvarchar (MAX)
as
begin
insert into Proveedores (No_cedula,Nombre,Apellido,Telefono_personal,Telefono_empresa,Email )
values (@No_cedula,@Nombre,@Apellido,@Telefono_personal,@Telefono_empresa,@Email )
end
go


--Elimina Proveedor

if OBJECT_ID ('Eliminar_proveedor') is not null
begin 
drop proc  Eliminar_proveedor  
end
go

create proc Eliminar_proveedor   -----Good-----
@Id_proveedor int 
as
begin
Delete Proveedores where Id_proveedor=@Id_proveedor
end
go

--Editar proveedores

if OBJECT_ID ('Editar_proveedor') is not null
begin 
drop proc  Editar_proveedor  
end
go

Create proc Editar_proveedor     -----Good-------
@Id_proveedor int,
@No_cedula nvarchar (16),
@Nombre nvarchar (30),
@Apellido nvarchar (30),
@Telefono_personal int,
@Telefono_empresa int,
@Email nvarchar (MAX)
as
begin
update Proveedores set  No_cedula= @No_cedula,Nombre=@Nombre,Apellido =@Apellido,Telefono_personal=@Telefono_personal,Telefono_empresa=@Telefono_empresa,Email=@Email
where Id_proveedor=@Id_proveedor
end
go

--Buscar Proveedor

if OBJECT_ID ('Buscar_proveedor') is not null
begin 
drop proc  Buscar_proveedor  
end
go

Create proc Buscar_proveedor    ----Good-----
@Id_proveedor int
as
begin 
select * from Proveedores where @Id_proveedor=Id_proveedor
end
go



--- CREANDO PROCEDIMIENTOS ALMACENADOS PARA COMPRA ---

--Insertar compra ---

if OBJECT_ID ('insertar_compra') is not null
begin 
drop proc  insertar_compra  
end
go

create proc insertar_compra      ----Good----
@Id_proveedor int,
@Id_producto int,
@Fecha_compra nvarchar (20),
@Precio_compra float,
@Cantidad int,
@Subtotal float,
@Iva float,
@Descuento float,
@Stock int
as 
begin
insert into Compra  (Id_proveedor,Id_producto,Fecha_compra,Precio_compra,Cantidad,Subtotal, Iva,Descuento,Stock)
values (@Id_proveedor,@Id_producto,@Fecha_compra,@Precio_compra,@Cantidad,@Subtotal,@Iva,@Descuento,@Stock)
end
go




--Editar compra ---

if OBJECT_ID ('editar_compra') is not null
begin 
drop proc  editar_compra  
end
go

create proc editar_compra    ----Good----
@Id_compra int,
@Id_proveedor int,
@Id_producto int,
@Fecha_compra nvarchar (20),
@Precio_compra float,
@Cantidad int,
@Subtotal float,
@Iva float,
@Descuento float,
@Stock int
as 
begin
update Compra set Id_proveedor=@Id_proveedor,Id_producto=@Id_producto,Fecha_compra=@Fecha_compra,Precio_compra=@Precio_compra,@Cantidad = Cantidad,@Subtotal = Subtotal,Iva=@Iva,Descuento=@Descuento,Stock=@Stock
where Id_compra=@Id_compra
end
go
--Eliminar compra ---

if OBJECT_ID ('Eliminar_compra') is not null
begin 
drop proc Eliminar_compra  
end
go

create proc Eliminar_compra    ----Good----
@Id_compra int 
as
begin
Delete Compra where Id_compra=@Id_compra
end
go

--- Buscar compra ---

if OBJECT_ID ('Buscar_compra') is not null
begin 
drop proc Buscar_compra  
end
go

Create proc Buscar_compra   ----Good-----
@Id_compra int
as
begin 
select * from Compra where @Id_compra=Id_compra
end
go
create proc MostrarCompra 
as
select *from Compra 
go


--- CREANDO PROCEDIMIENTOS ALMACENADOS PARA VENTA --- 

--Insertar venta ---

if OBJECT_ID ('insertar_venta') is not null
begin 
drop proc insertar_venta  
end
go

create proc insertar_venta    ----Good-----
@Id_producto int,
@Id_cliente int,
@Fecha_venta nvarchar (20),
@Precio_venta float,
@stock int,
@Iva float,
@Descuento float,
@Total float 
as 
begin
insert into Venta (Id_producto,Id_cliente,Fecha_venta,Precio_venta,Stock,Iva,Descuento,Total)
values (@Id_producto,@Id_cliente,@Fecha_venta,@Precio_venta,@Stock,@Iva,@Descuento,@Total)
end
go


--Editar venta ---

if OBJECT_ID ('editar_venta') is not null
begin 
drop proc editar_venta  
end
go

create proc editar_venta     ----Good----
@Id_venta int,
@Id_producto int,
@Id_cliente int,
@Fecha_venta nvarchar (20),
@Precio_venta float,
@stock int,
@Iva float,
@Descuento float,
@Total float
as begin
update Venta set Id_producto=@Id_producto,Id_cliente=@Id_cliente,Fecha_venta=@Fecha_venta,Precio_venta=@Precio_venta,Stock=@Stock,Iva=@Iva,Descuento=@Descuento,Total= @Total 
where Id_venta=@Id_venta
end
go


--Eliminar venta ---

if OBJECT_ID ('Eliminar_venta') is not null
begin 
drop proc Eliminar_venta  
end
go

create proc Eliminar_venta    ----Good----
@Id_venta int 
as
begin
Delete Venta 
where Id_venta=@Id_venta
end
go


--- Buscar venta ---

if OBJECT_ID ('Buscar_venta') is not null
begin 
drop proc Buscar_venta  
end
go

Create proc Buscar_venta    ----Good-----
@Id_venta int
as
begin 
select * from Venta where @Id_venta=Id_venta
end
go

--- Mostrar --- 
--Mostrar Empresa
if OBJECT_ID ('MostrarEmpresa') is not null
begin 
drop proc MostrarEmpresa  
end
go
create proc MostrarEmpresa
as
select *from Empresa
go
--Mostrar Empleado
if OBJECT_ID ('MostrarEmpleado') is not null
begin 
drop proc MostrarEmpleado  
end
go
create proc MostrarEmpleado
as
select *from Empleado
go
--Mostrar Usuario
if OBJECT_ID ('MostrarUsuario') is not null
begin 
drop proc MostrarUsuario  
end
go
create proc MostrarUsuario
as
select *from Usuario
go
--Mostrar Inventario
if OBJECT_ID ('MostrarInventario') is not null
begin 
drop proc MostrarInventario  
end
go
create proc MostrarInventario
as
select *from Inventario
go

--Mostar Clientes
if OBJECT_ID ('MostrarClientes') is not null
begin 
drop proc MostrarClientes  
end
go
create proc MostrarClientes
as
select *from Clientes
go
--Mostrar Proveedores
if OBJECT_ID ('MostrarProveedores') is not null
begin 
drop proc MostrarProveedores  
end
go
create proc MostrarProveedores
as
select * from Proveedores
go
--Mostrar Compra
if OBJECT_ID ('MostrarCompra') is not null
begin 
drop proc MostrarCompra  
end
go
create proc MostrarCompra 
as
select *from Compra 
go
--Mostrar Venta 
if OBJECT_ID ('MostrarVenta') is not null
begin 
drop proc MostrarVenta  
end
go
create proc MostrarVenta
as
select *from Venta  
go



Create trigger InsertarCompra
on Compra
for insert
as
set nocount on
begin
declare @Cantidad int
declare @ID int
select @Cantidad =Cantidad from inserted
Select @ID= Id_Producto From inserted
Update Inventario set Stock=(Inventario.Stock + (@Cantidad)) 
where Id_producto = (@ID)
end
go



select * from Compra
select * from Inventario
select * from Venta


create trigger InsertarVenta
on Venta
for insert
as
set nocount on
begin
declare @Cantidad int
declare @ID int
select @Cantidad = stock from inserted
Select @ID= Id_venta From inserted
Update Inventario set Stock=(Inventario.Stock - (@Cantidad)) 
where Id_producto = (@ID)
end
go
/*crear base y tablas*/

create database NueveDeJulio

create table Tipo_Documento
(Id_Doc int not null PRIMARY KEY identity,
Tipo nvarchar(4),
Descripcion nvarchar(40)
)

create table Provincia
(Id_Provincia int not null PRIMARY KEY identity,
Nombre nvarchar(40)
)

create table Localidad
(Id_Localidad int not null PRIMARY KEY identity,
Nombre nvarchar(40),
Id_Provincia int
)

create table Usuarios
(Id_Usuario int not null PRIMARY KEY identity,
Nombre nvarchar(40),
Usuario nvarchar(40),
Pass nvarchar(10),
Id_Rol int
)

create table Rol
(Id_Rol int not null PRIMARY KEY identity,
Nombre nvarchar(40)
)
/*crear consultas*/

declare @user nvarchar(40)='admin'
declare @pass nvarchar(10)='admin'
select *from Usuarios where Usuario=@user and Pass=@pass
select * from Rol


SELECT us.Usuario, us.Pass, ro.Nombre from Usuarios us INNER JOIN Rol ro ON us.Id_Rol = ro.Id_Rol 
declare @user nvarchar(40)='admin'
declare @pass nvarchar(10)='admin'
declare @NombreRol nvarchar(10)='Administrador'

SELECT us.Usuario, us.Pass, ro.Nombre from Usuarios us INNER JOIN Rol ro ON us.Id_Rol = ro.Id_Rol  where us.Usuario=@user and us.Pass=@pass and ro.Nombre=@NombreRol

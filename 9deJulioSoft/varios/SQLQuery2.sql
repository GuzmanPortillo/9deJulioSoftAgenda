/*consulta Socio *///////////////////////////////////////////////////////////////////////---------------------------------------------
select so.*, td.Tipo, pv.Nombre, de1.Nombre, de2.Nombre, es.Estado, se.Sexo  from Socios so 
inner join  Tipo_Documento td on td.Id_Doc=so.Id_Doc
inner join Provincia pv on pv.Id_Provincia = so.Id_Provincia 
inner join Deporte de1 on de1.Id_Deporte = so.Id_Deporte1
inner join Deporte de2 on de2.Id_Deporte = so.Id_Deporte2
inner join Estado es on es.Id_Estado = so.Id_Estado
inner join Sexo se on se.Id_Sexo = so.Id_Sexo

/*Alta Socio*/--------------------------------------------------------------------------------------------------------------------------

create procedure sp_AltaSocio 

@Nombre nvarchar(100),
@Apellido nvarchar(100),
@Id_Doc int,
@Nº_Doc int,
@Fecha_Nac nvarchar(10),
@email nvarchar(100),
@Telefono1 int,
@Telefono2 int,
@Domicilio nvarchar(150),
@Piso nvarchar(50),
@Dpto nvarchar(50),
@Localidad nvarchar(100),
@Id_Provincia int,
@Categoria int,
@Id_Deporte1 int,
@Id_Deporte2 int,
@Id_Estado int,
@foto image,
@CodigoPostal int,
@Id_Sexo int
as

insert into Socios values(@Nombre, @Apellido, @Id_Doc, @Nº_Doc, @Fecha_Nac, @email, @Telefono1, @Telefono2, @Domicilio, 
@Piso, @Dpto, @Localidad, @Id_Provincia, @Categoria, @Id_Deporte1, @Id_Deporte2, @Id_Estado, @foto, @CodigoPostal, @Id_Sexo);

------------------------------------------------------------------------------------------------------------------------

create procedure sp_AltaEmpleado 

@Nombre nvarchar(100),
@Apellido nvarchar(100),
@Id_Doc int,
@Nº_Doc int,
@Fecha_Nac nvarchar(10),
@email nvarchar(100),
@Telefono1 int,
@Telefono2 int,
@Domicilio nvarchar(150),
@Piso nvarchar(50),
@Dpto nvarchar(50),
@Localidad nvarchar(100),
@Id_Provincia int,
@Id_Sector int,
@Id_Puesto int,
@foto image,
@CodigoPostal int,
@Id_Sexo int
as

insert into Empleados values(@Nombre, @Apellido, @Id_Doc, @Nº_Doc, @Fecha_Nac, @email, @Telefono1, @Telefono2, @Domicilio, @Piso, @Dpto, @Localidad, @Id_Provincia, @Id_Sector, @Id_Puesto, @foto, @CodigoPostal, @Id_Sexo);





using CapaDatos;
using System;
using CapaSoporte.Cache;


namespace CapaNegocio
{
    public class ModeloUsuario
    {
        Accesodatos accesoDatos = new Accesodatos();

        public bool LoginUser(string usuario, string pass)
        {
            return accesoDatos.Login(usuario, pass);
        }

        public void tipocargo()
        {
            if (InicioSesion.cargo == Cargos.administrador)
            { }

            if (InicioSesion.cargo == Cargos.recepcionista)
            { }
        }
    }

    public class ModeloSocio
    {
        Accesodatos accesoDatos = new Accesodatos();


        //private int Id_Socio;
        private string Nombre;
        private string Apellido;
        private string Id_Doc;
        private string Nº_Doc;
        private string Fecha_Nac;
        private string email;
        private string Telefono1;
        private string Telefono2;
        private string Domicilio;
        private string Piso;
        private string Dpto;
        private string Localidad;
        private string Id_Provincia;
        private string Categoria;
        private string Id_Deporte1;
        private string Id_Deporte2;
        private string Id_Estado;
        private byte[] foto;
        private string CodigoPostal;
        private string Id_Sexo;

        public ModeloSocio(string Nombre, string Apellido, string Id_Doc, string Nº_Doc, string Fecha_Nac, string email, string Telefono1,
           string Telefono2, string Domicilio, string Piso, string Dpto, string Localidad, string Id_Provincia, string Categoria, string Id_Deporte1, string Id_Deporte2,
           string Id_Estado, byte[] foto, string CodigoPostal, string Id_Sexo)
        {
            //this.Id_Socio = Id_Socio;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Id_Doc = Id_Doc;
            this.Nº_Doc = Nº_Doc;
            this.Fecha_Nac = Fecha_Nac;
            this.email = email;
            this.Telefono1 = Telefono1;
            this.Telefono2 = Telefono2;
            this.Domicilio = Domicilio;
            this.Piso = Piso;
            this.Dpto = Dpto;
            this.Localidad = Localidad;
            this.Id_Provincia = Id_Provincia;
            this.Categoria = Categoria;
            this.Id_Deporte1 = Id_Deporte1;
            this.Id_Deporte2 = Id_Deporte2;
            this.Id_Estado = Id_Estado;
            this.foto = foto;
            this.CodigoPostal = CodigoPostal;
            this.Id_Sexo = Id_Sexo;
        }

        public string CrearSocioProfile()
        {
            try
            {
                accesoDatos.NuevoSocio(Nombre, Apellido, Id_Doc, Nº_Doc, Fecha_Nac, email, Telefono1, Telefono2, Domicilio, Piso, Dpto, Localidad,
                    Id_Provincia, Categoria, Id_Deporte1, Id_Deporte2, Id_Estado, foto, CodigoPostal, Id_Sexo);

                return "El Socio ha sido creado satisfactoriamente";

            }
            catch (Exception ex)
            {
                return "El Socio no pudo crearse, vuelva a intentarlo" + ex;
            }
        }

    }
    public class ModeloEmpleado
    {
        Accesodatos accesoDatos = new Accesodatos();


        private int Id_Socio;
        private string Nombre;
        private string Apellido;
        private string Id_Doc;
        private string Nº_Doc;
        private string Fecha_Nac;
        private string email;
        private string Telefono1;
        private string Telefono2;
        private string Domicilio;
        private string Piso;
        private string Dpto;
        private string Localidad;
        private string Id_Provincia;
        private string Id_Sector;
        private string Id_Puesto;
        private byte[] foto;
        private string CodigoPostal;
        private string Id_Sexo;

        public ModeloEmpleado(int Id_Socio, string Nombre, string Apellido, string Id_Doc, string Nº_Doc, string Fecha_Nac, string email, string Telefono1,
           string Telefono2, string Domicilio, string Piso, string Dpto, string Localidad, string Id_Provincia, string Id_Sector, string Id_Puesto, 
           byte[] foto, string CodigoPostal, string Id_Sexo)
        {
            this.Id_Socio = Id_Socio;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Id_Doc = Id_Doc;
            this.Nº_Doc = Nº_Doc;
            this.Fecha_Nac = Fecha_Nac;
            this.email = email;
            this.Telefono1 = Telefono1;
            this.Telefono2 = Telefono2;
            this.Domicilio = Domicilio;
            this.Piso = Piso;
            this.Dpto = Dpto;
            this.Localidad = Localidad;
            this.Id_Provincia = Id_Provincia;
            this.Id_Sector = Id_Sector;
            this.Id_Puesto = Id_Puesto;
            this.foto = foto;
            this.CodigoPostal = CodigoPostal;
            this.Id_Sexo = Id_Sexo;
        }

        public string CrearEmpleadoProfile()
        {
            try
            {
                accesoDatos.NuevoEmpleado(Id_Socio, Nombre, Apellido, Id_Doc, Nº_Doc, Fecha_Nac, email, Telefono1, Telefono2, Domicilio, Piso, Dpto, Localidad,
                    Id_Provincia, Id_Sector, Id_Puesto, foto, CodigoPostal, Id_Sexo);

                return "El Empleado ha sido creado satisfactoriamente";

            }
            catch (Exception)
            {
                return "El Empleado no pudo crearse, vuelva a intentarlo";
            }
        }

    }
}

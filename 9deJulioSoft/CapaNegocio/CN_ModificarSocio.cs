using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_ModificarSocio
    {
        private Accesodatos objDatosSocio = new Accesodatos();
     


        //private int Id_Socio;
        private string Nombre;
        private string Apellido;
        private string Id_Doc;
        private int Nro_Doc;
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

        public CN_ModificarSocio()
        {
        }

        public CN_ModificarSocio(string Nombre, string Apellido, string Id_Doc, int nro_doc, string Fecha_Nac, string email, string Telefono1,
           string Telefono2, string Domicilio, string Piso, string Dpto, string Localidad, string Id_Provincia, string Categoria, string Id_Deporte1, string Id_Deporte2,
           string Id_Estado, byte[] foto, string CodigoPostal, string Id_Sexo)
        {
            //this.Id_Socio = Id_Socio;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Id_Doc = Id_Doc;
            this.Nro_Doc = nro_doc;
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
        public DataTable consulta_socio(int dni)
        {
            DataTable tabla = new DataTable();
            tabla = objDatosSocio.consultaSocio(dni);
            return tabla;

        }

        public string editar_socio()
        {
            try
            {
                objDatosSocio.EditarSocio(Nombre, Apellido, Id_Doc, Nro_Doc, Fecha_Nac, email, Telefono1, Telefono2, Domicilio, Piso, Dpto, Localidad,
                    Id_Provincia, Categoria, Id_Deporte1, Id_Deporte2, Id_Estado, foto, CodigoPostal, Id_Sexo);

                return "El Empleado se  modificó satisfactoriamente";

            }
            catch (Exception ex)
            {
                return "El Empleado no pudo modificarse, vuelva a intentarlo" + ex;
            }
        }

    }
}

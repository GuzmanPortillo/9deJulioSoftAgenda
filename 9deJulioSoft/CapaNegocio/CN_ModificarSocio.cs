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
        //#region atributos
        //private string dni;

        //public string Dni 
        //{ get => dni; 
        //  set => dni = value; }
        //#endregion
        //private void PasarDatos()
        //{
        //    objDatosSocio.Dni = Convert.ToInt32(dni);
        //}
        public DataTable consulta_socio(int dni)
        {
            DataTable tabla = new DataTable();
            tabla = objDatosSocio.consultaSocio(dni);
            return tabla;

        }

    }
}

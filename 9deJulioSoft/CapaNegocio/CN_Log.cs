using System;
using CapaDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public static class CN_Log
    {
        //public int id { get; set; }
        //public DateTime fecha { get; set; }
        //public int usuario { get; set; }
        //public string accion { get; set; }
        //public string detalle { get; set; }

        public static void Insertar(int usuario,  string accion, string detalle)
        {
            var logDatos = new CD_Log();
            logDatos.Insertar(usuario, accion, detalle);
        }




    }
}

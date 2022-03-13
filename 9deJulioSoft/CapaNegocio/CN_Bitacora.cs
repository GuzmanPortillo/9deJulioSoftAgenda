using System;
using CapaDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public static class CN_Bitacora
    {
        public static void Insertar(int usuario,  string entidad, string accion, string detalle)
        {
            var logDatos = new CD_Bitacora();
            logDatos.Insertar(usuario, entidad, accion, detalle);
        }




    }
}

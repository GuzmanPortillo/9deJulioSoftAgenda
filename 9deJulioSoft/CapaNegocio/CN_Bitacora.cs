using System;
using CapaDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaSoporte.Cache;

namespace CapaNegocio
{
    public static class CN_Bitacora
    {
        public static void Guardar(int usuario,  string entidad, string accion, string detalle)
        {
            var bitacoraDatos = new CD_Bitacora();
            bitacoraDatos.Insertar(usuario, entidad, accion, detalle);
        }

        public static DataTable getAll(DateTime fechaDesde, DateTime fechaHasta, int idUsuario, string entidad, string accion)
        {
            var bitacoraDatos = new CD_Bitacora();

            if (entidad == BitacoraEntidad.TODOS.ToString())
            {
                entidad = null;
            }

            if (accion == BitacoraAccion.TODOS.ToString())
            {
                accion = null;
            }

            return bitacoraDatos.getAll(fechaDesde, fechaHasta, idUsuario, entidad, accion);
        }

    }
}

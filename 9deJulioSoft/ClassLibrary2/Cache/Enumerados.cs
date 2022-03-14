using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSoporte.Cache
{
   
    public enum BitacoraEntidad
    {
        TODOS,
        Usuario,
        Socio,
        Empleado,
        Login
    }

    public enum BitacoraAccion
    {
        TODOS,
        Alta,
        Baja,
        Modificacion,
        Ingresar,
        Salir
    }
}

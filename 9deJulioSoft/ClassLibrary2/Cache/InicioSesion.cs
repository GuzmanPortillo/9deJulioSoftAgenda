using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSoporte.Cache
{
    public static class InicioSesion
    {
        public static int idusuario { get; set; }
        public static string usuario { get; set; }
        public static string contrasenia { get; set; }
        public static string nombres { get; set; }
        public static string apellidos { get; set; }
        public static string estado { get; set; }
        public static int cargo { get; set; }
        public static byte[] foto { get; set; }
    }
}

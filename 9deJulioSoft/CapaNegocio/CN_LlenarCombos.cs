using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_LlenarCombos
    {
        private CD_LlenarCombos llenar = new CD_LlenarCombos();

        #region ATRIBUTOS

        private string nomtabla;
        private string campoid;
        private string campodescrip;
        private string condicion;

        #endregion

        #region PROPERTIES

        public string NomTabla
        {
            set { nomtabla = value; }
        }
        public string CampoId
        {
            set { campoid = value; }
        }
        public string CampoDescrip
        {
            set { campodescrip = value; }
        }
        public string Condicion
        {
            set { condicion = value; }
        }

        #endregion


        public DataTable Cargar()
        {
            llenar.Tabla = nomtabla;
            llenar.CampoId = campoid;
            llenar.CampoDescrip = campodescrip;
            llenar.Condicion = condicion;

            DataTable tabla = new DataTable();
            tabla = llenar.CargarCMB();
            return tabla;
        }
    }
}
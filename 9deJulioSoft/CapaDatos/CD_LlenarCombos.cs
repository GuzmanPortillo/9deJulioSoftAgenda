using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class CD_LlenarCombos : ConnectionToSql
    {
        #region ATRIBUTOS
        private string tabla;
        private string campoid;
        private string campodescrip;
        private string condicion;
        #endregion

        #region PROPERTIES
        public string Tabla
        {
            set { tabla = value; }
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


        public DataTable CargarCMB()
        {
            string sSql;
            if (condicion == "")
            {
                sSql = "SELECT " + campoid + ", " + campodescrip + " FROM " + tabla + " ORDER BY " + campodescrip;
            }
            else
            {
                sSql = "SELECT " + campoid + ", " + campodescrip + " FROM " + tabla + " Where  " + condicion + " ORDER BY " + campodescrip;
            }

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = sSql;
                    DataTable data = new DataTable();
                    SqlDataReader reader = command.ExecuteReader();
                    data.Load(reader);
                    connection.Close();
                    return data;

                }
            }
        }
    }
}

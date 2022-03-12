using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class CD_Log : ConnectionToSql
    {
        public void Insertar(int usuario, string accion, string detalle)
        {
            string sSql = "Insert Into Bitacora" +
            "(fecha, id_usuario, accion, detalle)" +
            " Values( " + "getdate(), " + usuario + ","  + "'" + accion + "'," + "'" + detalle + "')";

            using (var connection = GetConnection())
            {

                connection.Open();

                SqlCommand cmd = new SqlCommand(sSql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            //objDB.Ejecutar(sSql);
        }

    }
}

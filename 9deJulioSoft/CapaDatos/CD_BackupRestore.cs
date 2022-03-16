using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class CD_BackupRestore : ConnectionToSql
    {

        //Insert, Update And Delete...
        public void general_query(string query)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = query;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

        }


        //public DataTable Mitabla(string query)
        //{
        //    //Open_Connection();
        //    //command.CommandText = query;
        //    //SqlDataAdapter myAdapter = new SqlDataAdapter(command);
        //    //DataTable mytbl = new DataTable();
        //    //myAdapter.Fill(mytbl);
        //    //return mytbl;

        //    using (var connection = GetConnection())
        //    {
        //        connection.Open();
        //        using (var command = new SqlCommand())
        //        {
        //            command.Connection = connection;
        //            command.CommandText = query;
        //            SqlDataAdapter da = new SqlDataAdapter(command);
        //            DataTable dt = new DataTable();
        //            da.Fill(dt);
        //            command.CommandType = CommandType.Text;
        //            command.ExecuteNonQuery();
        //            return dt;
        //        }
        //    }
        //}

    }
}

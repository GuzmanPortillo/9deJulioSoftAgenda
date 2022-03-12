using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{

    public class StockDatos : ConnectionToSql
    {
        #region Atributos
        private int IdCodigo;
        private string Producto;
        private int Cantidad;
        private int Total;
        #endregion
        #region Properties
        public int ID
        {
            get => IdCodigo;
            set { IdCodigo = value; }

        }
        public string PRODUCTO
        {
            get => Producto;
            set { Producto = value; }

        }
        public int CANTIDAD
        {
            get => Cantidad;
            set { Cantidad = value; }

        }
        public int TOTAL
        {
            get => Total;
            set { Total = value; }

        }
        #endregion
        public void NuevoStock(string Producto, int Cantidad, int Total)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "spAltaStock";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Producto", Producto);
                    command.Parameters.AddWithValue("@Cantidad ", Cantidad);
                    command.Parameters.AddWithValue("@Total", Total);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                    connection.Close();

                }
            }
        }
         public void ModificarStock(int IdCodigo, int Cantidad, int Total)
         {
             using (var connection = GetConnection())
             {
                 connection.Open();
                 using (var command = new SqlCommand())
                 {
                     command.Connection = connection;
                     command.CommandText = "spModificacionStockk";
                     command.CommandType = CommandType.StoredProcedure;
                     command.Parameters.AddWithValue("@IdCodigo", IdCodigo);
                     command.Parameters.AddWithValue("@Cantidad ", Cantidad);
                     command.Parameters.AddWithValue("@Total", Total);
                     command.ExecuteNonQuery();
                     command.Parameters.Clear();

                     connection.Close();

                 }
             }
         }
        public Tuple<string> Modificar(int IdCodigo)
        {
            string Total = "null";
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select Total from Stock where IdCodigo = @IdCodigo";
                    command.Parameters.AddWithValue("@IdCodigo", IdCodigo);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Total = reader["Total"].ToString();
                    }
                    Console.WriteLine(Total);
                    return Tuple.Create(Total);
                }
            }
        }
        public void BajaStock(int IdCodigo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "spBajaStock";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdCodigo", IdCodigo);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                    connection.Close();

                }
            }
        }
        public DataTable ListaStock(string Producto)
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    string sSql = "SELECT * From Stock where Producto like '"+ Producto + "%'";
                    DataTable dt = new DataTable();
                    command.Connection = connection;
                    command.CommandText = sSql;
                    SqlDataReader dr = command.ExecuteReader();
                    dt.Load(dr);
                    connection.Close();
                    return dt;
                }
            }
        }
        public DataTable ListarStock()
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    string sSql = "SELECT * From Stock";
                    DataTable dt = new DataTable();
                    command.Connection = connection;
                    command.CommandText = sSql;
                    SqlDataReader dr = command.ExecuteReader();
                    dt.Load(dr);
                    connection.Close();
                    return dt;
                }
            }
        }
        public Tuple<string, string, string, string> LeerSt()
        {
            string IdCodigo = "null";
            string Producto = "null";
            string Cantidad = "null";
            string Total = "null";

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT* From Stock";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        IdCodigo = reader["IdCodigo"].ToString();
                        Producto = reader["Producto"].ToString();
                        Cantidad = reader["Cantidad"].ToString();
                        Total = reader["Total"].ToString();

                    }
                    Console.WriteLine(IdCodigo);
                    Console.WriteLine(Producto);
                    Console.WriteLine(Cantidad);
                    Console.WriteLine(Total);
                    return Tuple.Create(IdCodigo, Producto, Cantidad, Total);


                }
            }
        }

        public bool Existe(string Producto)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM Stock WHERE Producto = @Producto";
                    command.Parameters.AddWithValue("@Producto", Producto);
                    command.CommandType = CommandType.Text;
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }

        public bool ExisteId(int IdCodigo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Stock WHERE  IdCodigo = @IdCodigo";
                    command.Parameters.AddWithValue("@IdCodigo", IdCodigo);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }
    }
        
}

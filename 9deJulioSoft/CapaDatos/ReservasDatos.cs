using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ReservasDatos :ConnectionToSql
    {
        #region Atributos
        private int Id_Reservas;
        private string Nombre;
        private string Apellido;
        private string Dni;
        private string Deporte;
        private string Fecha;
        private string Horario;
        #endregion
        #region Properties
        public int ID
        {
            get => Id_Reservas;
            set { Id_Reservas = value; }

        }
        public string NOMBRE
        {
            get => Nombre;
            set { Nombre = value; }

        }
        public string APELLIDO
        {
            get => Apellido;
            set { Apellido = value; }

        }
        public string DNI
        {
            get => Dni;
            set { Dni = value; }

        }
        public string FECHA
        {
            get => Fecha;
            set { Fecha = value; }

        }
        public string HORARIO
        {
            get => Horario;
            set { Horario = value; }

        }
        public string DEPORTE
        {
            get => Deporte;
            set { Deporte = value; }

        }
        #endregion

        public bool Documento(string Dni)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Socios where Nº_Doc = @DNI" ;
                    command.Parameters.AddWithValue("@DNI", Dni);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    //var nombre = reader.["nombre"];
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
        public DataTable ListaDeReservas(string fecInicio, string Fecfin)
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    string sSql = "SELECT Nombre, Apellido, Dni, Deporte, Fecha, Horario From Reservas Where Fecha Between '" + fecInicio + "' and '" + Fecfin + "'";
                    DataTable dt = new DataTable();
                    command.Connection = connection;
                    command.CommandText = sSql;
                    SqlDataReader dr = command.ExecuteReader();
                    dt.Load(dr);
                    connection.Close();
                    return dt;
                }
                //SELECT Nombre, Apellido, Dni, Deporte, Fecha, Horario From Reservas Where Fecha Between '01/01/2022' and '01/03/2022';
            }
        }
        /* public bool Leer(string Dni, string Nombre, string Apellido)
         {
             string nombre;
             string apellido;
             string dni;
             using (var connection = GetConnection())
             {
                 connection.Open();
                 using (var command = new SqlCommand())
                 {
                     command.Connection = connection;
                     command.CommandText = "select Nombre, Apellido from Socios where Nº_Doc = @DNI";
                     // command.CommandText = "select Apellido from Socios where Nº_Doc = @DNI";
                     command.Parameters.AddWithValue("@DNI", Dni);*/
        /*command.Parameters.AddWithValue("Nombre", Nombre);
        command.Parameters.AddWithValue("Apellido", Apellido);*/
        /* command.CommandType = CommandType.Text;*/
        //command.Parameters.Add("Nombre", Nombre);
        //command.Parameters.Add("Apellido", Apellido);
        /*Console.WriteLine(Nombre);
        Console.WriteLine(Apellido);*/
        /*  SqlDataReader reader = command.ExecuteReader();

          if (reader.Read())
          {
              dni = Convert.ToString(Dni);
              nombre = reader["Nombre"].ToString();
              apellido = reader["Apellido"].ToString();
              Console.WriteLine(Dni);
              Console.WriteLine(Nombre);
              Console.WriteLine(Apellido);*/
        /*if (dni != null && nombre != null && apellido != null) {
            dni = Convert.ToString(Dni);
            nombre = reader["Nombre"].ToString();
            apellido = reader["Apellido"].ToString();
            return (dni, nombre, apellido);
        }*/
        /*
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
                 */
        public Tuple<string, string> Leer (string Dni) {
            string Nombre = "Null";
            string Apellido = "Null";
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Socios where Nº_Doc = @DNI";
                    command.Parameters.AddWithValue("@DNI", Dni); 
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Nombre = reader["Nombre"].ToString();
                        Apellido = reader["Apellido"].ToString();
                    }
                    Console.WriteLine(Nombre);
                    Console.WriteLine(Apellido);
                        return Tuple.Create(Nombre, Apellido);
                    
                
            }
        }
}
        public void NuevaReserva(string Nombre, string Apellido, string Dni, string Deporte, string Fecha, string Horario )
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "sp_AltaReserva";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Apellido ", Apellido);
                    command.Parameters.AddWithValue("@Dni", Dni);
                    command.Parameters.AddWithValue("@Deporte", Deporte);
                    command.Parameters.AddWithValue("@Fecha", Fecha);
                    command.Parameters.AddWithValue("@Horario", Horario);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                    connection.Close();

                }
            }
        }

        public bool CheckF()
{
using (var connection = GetConnection())
{
    connection.Open();
    using (var command = new SqlCommand())
    {
        command.Connection = connection;
        command.CommandText = "select * from Deporte where Id_Deporte = 1";
        //command.CommandText = "select * from Deporte where Id_Deporte = @ID";
        //command.Parameters.AddWithValue("@ID", Id);
        command.CommandType = CommandType.Text;
        SqlDataReader reader = command.ExecuteReader();
        if (reader.HasRows)
        {
            return true;
        }
        else
            return false;
    }
}
}
public bool CheckB()
{
    using (var connection = GetConnection())
    {
        connection.Open();
        using (var command = new SqlCommand())
        {
            command.Connection = connection;
            command.CommandText = "select * from Deporte where Id_Deporte = 2";
            //command.CommandText = "select * from Deporte where Id_Deporte = @ID";
            //command.Parameters.AddWithValue("@ID", Id);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
                return false;
        }
    }
}

}

}
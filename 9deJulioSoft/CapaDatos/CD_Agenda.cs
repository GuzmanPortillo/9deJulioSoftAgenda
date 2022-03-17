using System;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class CD_Agenda : ConnectionToSql
    {
        #region Atributos
        private int id;
        private DateTime fecha;
        private int hora;
        private string nombreEvento;
        private int espacio;

        #endregion
        #region Properties
        public int ID
        {
            get => id;
            set { id = value; }

        }
        public DateTime Fecha
        {
            get => fecha;
            set { fecha = value; }
        }
        public int Hora
        {
            get => hora;
            set { hora = value; }
        }
        public string NombreEvento
        {
            get => nombreEvento;
            set { nombreEvento = value; }
        }
        public int Espacio
        {
            get => espacio;
            set { espacio = value; }
        }
        #endregion

        /*consutla para pantalla agenda*/
        public DataTable consultarAgenda(string fecInicio, string Fecfin)
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    string sSql = "SELECT * From Eventos Where CONVERT(datetime, Fecha, 0) Between '" + fecInicio + "' and '" + Fecfin + "'";
                    DataTable dt = new DataTable();
                    command.Connection = connection;
                    command.CommandText = sSql;
                    SqlDataReader dr = command.ExecuteReader();
                    dt.Load(dr);

                   // da.Fill(dt);
                    connection.Close();
                    return dt;
                }

            }
        }
        /*consulta para reporte*/
        public DataTable consultarListaEventos(string fecInicio, string Fecfin)
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    string sSql = "SELECT a.Nombre, a.Fecha, right('0' + convert(varchar, a.Hora) + ':00',5) as Hora, b.Espacio From Eventos as a inner join EstablecimientoLugar as b " +
                        " on a.idEspacio = b.idEspacioEst Where CONVERT(date, a.Fecha, 0) Between '" + fecInicio + "' and '" + Fecfin + "'";
                    DataTable dt = new DataTable();
                    command.Connection = connection;
                    command.CommandText = sSql;
                    SqlDataReader dr = command.ExecuteReader();
                    dt.Load(dr);

                    // da.Fill(dt);
                    connection.Close();
                    return dt;
                }

            }
        }
        /*consulta item seleccionado en la pantalla de agenda*/
        public DataTable MostrarEventoSelec(int idapp)
        {
            using (var connection = GetConnection())
            {
                //TODO
                connection.Open();
                using (var command = new SqlCommand())
                {
                    string sSql = "SELECT a.Nombre, a.Fecha, right('0' + convert(varchar, a.Hora) + ':00',5) as Hora, a.idEspacio From Eventos as a " +
                        "where  a.ID = " + idapp;
                    //string sSql = "SELECT * From Eventos Where ID = " + idapp;
                    DataTable dt = new DataTable();
                    command.Connection = connection;
                    command.CommandText = sSql;
                    SqlDataReader dr = command.ExecuteReader();
                    dt.Load(dr);

                    // da.Fill(dt);
                    connection.Close();
                    return dt;
                }

            }
        }

        public DataTable GetEvento(string fecha, int hora, int idEspacio)
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    string sSql = "SELECT * From Eventos as a inner join EstablecimientoLugar as b " +
                        " on a.idEspacio = b.idEspacioEst Where a.ID = ";//+ idapp;
                    //string sSql = "SELECT * From Eventos Where ID = " + idapp;
                    DataTable dt = new DataTable();
                    command.Connection = connection;
                    command.CommandText = sSql;
                    SqlDataReader dr = command.ExecuteReader();
                    dt.Load(dr);

                    // da.Fill(dt);
                    connection.Close();
                    return dt;
                }
            }
        }

        public void insertarDatos()
        {
            string sSql = "Insert Into Eventos" +
            "(Fecha, Hora, Nombre, idEspacio)" +
            "Values" + "('" + fecha.ToString("yyyyMMdd") + "'," + hora + ",'" + nombreEvento + "'," + espacio + ")";
            Ejecutar(sSql);
        }

        public void Actualizar()
        {
                string sSql = "UPDATE Eventos set " + " Fecha ='" + fecha + "',Hora = '" + hora + "',Nombre ='" + nombreEvento + "',idEspacio = " + espacio +
                            " where ID = " + id;
                Ejecutar(sSql);
        }
    
    
        public void Delete()
        {
            string sSql = "DELETE FROM Eventos WHERE ID = " + id;
            Ejecutar(sSql);
        }

        public void Ejecutar(string ssql)
        {
            using (var connection = GetConnection())
            {
                
            connection.Open();
            
            SqlCommand cmd = new SqlCommand(ssql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            }
        }
      

    }
}

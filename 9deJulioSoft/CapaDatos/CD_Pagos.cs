using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Pagos : ConnectionToSql
    {
        #region Atributos
        private int idsociocuota;
        //private string fecha;
        //private string hora;
        //private string nombreEvento;
        //private int espacio;

        #endregion
        #region Properties
        public int Idsociocuota
        {
            get => idsociocuota;
            set { idsociocuota = value; }

        }
        //public string Fecha
        //{
        //    get => fecha;
        //    set { fecha = value; }
        //}
        //public string Hora
        //{
        //    get => hora;
        //    set { hora = value; }
        //}
        //public string NombreEvento
        //{
        //    get => nombreEvento;
        //    set { nombreEvento = value; }
        //}
        //public int Espacio
        //{
        //    get => espacio;
        //    set { espacio = value; }
        //}
            #endregion

            //public DataTable consultarCuotas(int nro_socio)
            //{
            //    using (var connection = GetConnection())
            //    {

            //        connection.Open();
            //        using (var command = new SqlCommand())
            //        {
            //            string sSql = "sp_consulta_cuota";
            //            DataTable dt = new DataTable();
            //            command.Connection = connection;
            //            command.CommandText = sSql;
            //            SqlDataAdapter da = new SqlDataAdapter(command);
            //            command.CommandType = CommandType.StoredProcedure;
            //            command.Parameters.AddWithValue("@id_socio", nro_socio);
            //            command.Parameters.Clear();

            //            da.Fill(dt);
            //            connection.Close();
            //            return dt;
            //        }

            //    }
            //}

        public DataTable consultarCuotas(int nro_socio)
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    string sSql = "select b.id_socio_cuota, a.nombre, a.apellido, b.nro_cuota, b.fec_venc, b.monto, b.estado From socios as a inner join detalle_cuotas_socios as b" +
                        " on a.Id_Socios = b.id_socios where b.id_socios = " + nro_socio;
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

        public void ActualizarCuota()
        {
            string sSql = "UPDATE detalle_cuotas_socios set " + " estado = " + "'Pagado'" + "where id_socio_cuota = " + idsociocuota;
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

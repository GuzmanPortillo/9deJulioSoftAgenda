using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class CD_Bitacora : ConnectionToSql
    {
        public void Insertar(int usuario, string entidad,  string accion, string detalle)
        {
            try
            {
                //string sSql = "Insert Into Bitacora" +
                //"(fecha, id_usuario, entidad,  accion, detalle)" +
                //" Values( " + "getdate(), " + usuario + "," + "'" + entidad + "'," + "'" + accion + "'," + "'" + detalle + "')";

                string sSql = "Insert Into Bitacora" +
                "(fecha, id_usuario, entidad,  accion, detalle)" +
                " Values(@fecha, @idUsurio, @entidad, @accion, @detalle )";
                using (var connection = GetConnection())
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(sSql, connection);
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                    cmd.Parameters.AddWithValue("@idUsurio",usuario);
                    cmd.Parameters.AddWithValue("@entidad",entidad);
                    cmd.Parameters.AddWithValue("@accion", accion);
                    cmd.Parameters.AddWithValue("@detalle", detalle);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    connection.Dispose();
                }
            }
            catch (Exception)
            {
                throw ;
            }
        }

        public DataTable getAll(DateTime fechaDesde, DateTime fechaHasta, int idUsuario, string entidad, string accion)
        {
            var dt = new DataTable();

            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "sp_getBitacora";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                        command.Parameters.AddWithValue("@fechaHasta ", fechaHasta);
                        
                        if (idUsuario == -1 )
                            command.Parameters.AddWithValue("@idUsuario", null);
                        else
                            command.Parameters.AddWithValue("@idUsuario", idUsuario);

                        command.Parameters.AddWithValue("@entidad", entidad);
                        command.Parameters.AddWithValue("@accion", accion);


                        SqlDataReader dr = command.ExecuteReader();
                        dt.Load(dr);
                        command.Parameters.Clear();
                        connection.Close();
                        return dt;
                    }
                }
            }
            catch (Exception e)
            {
                return dt;
            }
        }
    }
}

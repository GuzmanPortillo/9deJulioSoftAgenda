using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Usuarios : ConnectionToSql
    {
        CD_Agenda objDB = new CD_Agenda();

        #region Atributos
        private int idUsuarios;
        private int idRol;
        private int idUsuarioAlta;
        private bool permitir;

        #endregion

        #region Properties
        public int IdUsuario
        {
            get => idUsuarios;
            set { idUsuarios = value; }

        }
        public int IdRol
        {
            get => idRol;
            set { idRol = value; }
        }
        public int IdUsuarioAlta
        {
            get => idUsuarioAlta;
            set { idUsuarioAlta = value; }
        }

        public bool Permitir
        {
            get => permitir;
            set { permitir = value; }
        }

        #endregion

        public DataTable ConsultaUsuarioRol(int idUsuario)
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    DataTable dt = new DataTable();
                    command.Connection = connection;
                    command.CommandText = "sp_ObtenerPermisosUsuario";
                    command.Parameters.AddWithValue("@usuario", idUsuario);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = command.ExecuteReader();
                    dt.Load(dr);

                    connection.Close();
                    return dt;
                }

            }
        }
        public void insertarUsurioRol()
        {

            string sSql = "Insert Into tUsuarioRoles" +
            "(id_usuario, id_rol)" +
            "Values" + "('" + idUsuarioAlta + "'," + idRol + ")";
            objDB.Ejecutar(sSql);

        }

        public void actualizarRol()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "sp_ActualizarRol";
                    command.Parameters.AddWithValue("@idUsuario", IdUsuario);
                    command.Parameters.AddWithValue("@idRol", IdRol);
                    command.Parameters.AddWithValue("@activo", Permitir);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public DataTable EditarOtroUsuario(string usuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from tUsuario where Usuario=@user";
                    command.Parameters.AddWithValue("@user", usuario);
                    DataTable dt = new DataTable();
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    dt.Load(reader);
                    connection.Close();
                    return dt;
                }
            }
        }
        public DataTable NoExiste(string usuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from tUsuario where Usuario=@user";
                    command.Parameters.AddWithValue("@user", usuario);
                    DataTable dt = new DataTable();
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    dt.Load(reader);
                    connection.Close();
                    return dt;
                }
            }
        }

        public DataTable GetUsuarios()
        {
            string sSql;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {

                    sSql = "SELECT * From tusuario order by usuario";

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
    }
}

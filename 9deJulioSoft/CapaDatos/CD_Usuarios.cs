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
        #endregion

        public DataTable ConsultaUsuarioRol(string UsuarioRol)
        {
            string sSql;
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    if (UsuarioRol == "")
                    {
                        sSql = "SELECT t.id_usuario, t.usuario, t.Nombres, t.Apellidos, r.id_rol, r.Nombre From tusuario as t inner join tUsuarioRoles as tu" +
                            " on t.id_usuario = tu.id_usuario inner join rol as r on tu.id_rol = r.id_rol";
                    }
                    else
                    {
                        sSql = "SELECT t.id_usuario, t.usuario, t.Nombres, t.Apellidos, r.id_rol, r.Nombre From tusuario as t inner join tUsuarioRoles as tu" +
                            " on t.id_usuario = tu.id_usuario inner join rol as r on tu.id_rol = r.id_rol where t.usuario = " + UsuarioRol + "'";
                    }

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
        public void insertarUsurioRol()
        {

            string sSql = "Insert Into tUsuarioRoles" +
            "(id_usuario, id_rol)" +
            "Values" + "('" + idUsuarioAlta + "'," + idRol + ")";
            objDB.Ejecutar(sSql);

        }

        public void actualizarRol()
        {
            string sSql = "UPDATE tUsuarioRoles set id_rol = " + idRol + " where id_usuario = " + idUsuarios;
            objDB.Ejecutar(sSql);
        }

        //public DataTable consultarAgenda(string fecInicio, string Fecfin)
        //{
        //    using (var connection = GetConnection())
        //    {

        //        connection.Open();
        //        using (var command = new SqlCommand())
        //        {
        //            string sSql = "SELECT * From Eventos Where CONVERT(datetime, Fecha, 0) Between '" + fecInicio + "' and '" + Fecfin + "'";
        //            DataTable dt = new DataTable();
        //            command.Connection = connection;
        //            command.CommandText = sSql;
        //            SqlDataReader dr = command.ExecuteReader();
        //            dt.Load(dr);

        //            // da.Fill(dt);
        //            connection.Close();
        //            return dt;
        //        }

        //    }
        //}

    }
}

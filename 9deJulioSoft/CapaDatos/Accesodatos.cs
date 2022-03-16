using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaSoporte.Cache;


namespace CapaDatos
{
    public class Accesodatos : ConnectionToSql
    {
        //#region atributos
        //private int dni;

        //public int Dni
        //{
        //    get => dni;
        //    set => dni = value;
        //}
        //#endregion

        //Login
        public void editarPerfil(int id, string usuario, string contrasenia, string nombres, string apellidos, string estado, byte[] foto)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update tusuario set Usuario=@usuario, Contrasenia=@contrasenia, Nombres=@Nombres, Apellidos=@apellidos, Estado=@estado where id_usuario=@id";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contrasenia", contrasenia);
                    command.Parameters.AddWithValue("@Nombres", nombres);
                    command.Parameters.AddWithValue("@apellidos", apellidos);
                    //command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@estado", estado);

                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@foto", SqlDbType.Image).Value = foto;
                    command.CommandType = CommandType.StoredProcedure;

                    command.ExecuteNonQuery();
                }
            }
        }

        public void ObtenerCargos()
        {
            List<int> cargos = new List<int>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from tUsuario as t WHERE id_usuario = @idUsuario";
                    command.Parameters.AddWithValue("@idUsuario", InicioSesion.idusuario);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                            cargos.Add(reader.GetInt32(0));

                        InicioSesion.cargos = cargos.ToArray();
                        connection.Close();
                    }
                    else
                    {
                        connection.Close();
                    }

                }
            }


        }

        public void altaUsuario(string usuario, string contrasenia, string nombres, string apellidos, string estado, byte[] foto)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert  into tusuario(Usuario,Nombres, Apellidos, Contrasenia, Estado )" +
                                            "Values" + "('" + usuario + "','" + nombres + "','" + apellidos  + "','" + contrasenia  + "','" + estado + "')";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@Nombres", nombres);
                    command.Parameters.AddWithValue("@apellidos", apellidos);
                    command.Parameters.AddWithValue("@contrasenia", contrasenia);
                    command.Parameters.AddWithValue("@estado", estado);
                    //command.Parameters.AddWithValue("@mail", mail);
                    //command.Parameters.AddWithValue("@id", id);

                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool Login(String user, string contrasenia)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select t.id_usuario, t.usuario, t.Nombres, t.Apellidos, t.Contrasenia,r.id_rol from tUsuario as t " +
                        " inner join tusuarioRoles as tr on tr.id_usuario = t.id_usuario inner join Rol as r on r.Id_Rol = tr.id_rol where Usuario=@user and contrasenia=@contrasenia";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@contrasenia", contrasenia);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            InicioSesion.idusuario = reader.GetInt32(0);
                            InicioSesion.usuario = reader.GetString(1);
                            InicioSesion.nombres = reader.GetString(2);
                            InicioSesion.apellidos = reader.GetString(3);
                            InicioSesion.contrasenia = reader.GetString(4);
                        }
                        connection.Close();
                        return true;
                    }
                    else
                    {
                        connection.Close();
                        return false;
                    }
                        
                }
            }
        }



        //Socios
        public void NuevoSocio(string Nombre, string Apellido, string Id_Doc, string Nº_Doc, string Fecha_Nac, string email, string Telefono1,
           string Telefono2, string Domicilio, string Piso, string Dpto, string Localidad, string Id_Provincia, string Categoria, string Id_Deporte1, string Id_Deporte2,
           string Id_Estado, byte[] foto, string CodigoPostal, string Id_Sexo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "sp_AltaSocio";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Apellido ", Apellido);
                    command.Parameters.AddWithValue("@Id_Doc", Id_Doc);
                    command.Parameters.AddWithValue("@Nº_Doc", Nº_Doc);
                    command.Parameters.AddWithValue("@Fecha_Nac", Fecha_Nac);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@Telefono1", Telefono1);
                    command.Parameters.AddWithValue("@Telefono2", Telefono2);
                    command.Parameters.AddWithValue("@Domicilio", Domicilio);
                    command.Parameters.AddWithValue("@Piso", Piso);
                    command.Parameters.AddWithValue("@Dpto", Dpto);
                    command.Parameters.AddWithValue("@Localidad", Localidad);
                    command.Parameters.AddWithValue("@Id_Provincia", Id_Provincia);
                    command.Parameters.AddWithValue("@Categoria", Categoria);
                    command.Parameters.AddWithValue("@Id_Deporte1", Id_Deporte1);
                    command.Parameters.AddWithValue("@Id_Deporte2", Id_Deporte2);
                    command.Parameters.AddWithValue("@Id_Estado", Id_Estado);
                    command.Parameters.AddWithValue("@foto ", SqlDbType.Image).Value = foto;
                    command.Parameters.AddWithValue("@CodigoPostal", CodigoPostal);
                    command.Parameters.AddWithValue("@Id_Sexo", Id_Sexo);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                    connection.Close();

                }
            }
        }

        public void EditarSocio(string Nombre, string Apellido, string Id_Doc, int dni, string Fecha_Nac, string email, string Telefono1,
           string Telefono2, string Domicilio, string Piso, string Dpto, string Localidad, string Id_Provincia, string Categoria, string Id_Deporte1, string Id_Deporte2,
           string Id_Estado, byte[] foto, string CodigoPostal, string Id_Sexo)

        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "sp_Actualizar_socios";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Apellido ", Apellido);
                    command.Parameters.AddWithValue("@Id_Doc", Id_Doc);
                    command.Parameters.AddWithValue("@Nro_Doc", dni);
                    command.Parameters.AddWithValue("@Fecha_Nac", Fecha_Nac);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@Telefono1", Telefono1);
                    command.Parameters.AddWithValue("@Telefono2", Telefono2);
                    command.Parameters.AddWithValue("@Domicilio", Domicilio);
                    command.Parameters.AddWithValue("@Piso", Piso);
                    command.Parameters.AddWithValue("@Dpto", Dpto);
                    command.Parameters.AddWithValue("@Localidad", Localidad);
                    command.Parameters.AddWithValue("@Id_Provincia", Id_Provincia);
                    command.Parameters.AddWithValue("@Categoria", Categoria);
                    command.Parameters.AddWithValue("@Id_Deporte1", Id_Deporte1);
                    command.Parameters.AddWithValue("@Id_Deporte2", Id_Deporte2);
                    command.Parameters.AddWithValue("@Id_Estado", Id_Estado);
                    command.Parameters.AddWithValue("@foto ", SqlDbType.Image).Value = foto;
                    command.Parameters.AddWithValue("@CodigoPostal", CodigoPostal);
                    command.Parameters.AddWithValue("@Id_Sexo", Id_Sexo);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                    connection.Close();

                }
            }
        }
        //Empleados
        public void NuevoEmpleado(int Id_Socio, string Nombre, string Apellido, string Id_Doc, string Nº_Doc, string Fecha_Nac, string email, string Telefono1,
        string Telefono2, string Domicilio, string Piso, string Dpto, string Localidad, string Id_Provincia, string Id_Sector, string Id_Puesto, byte[] foto, string CodigoPostal, string Id_Sexo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "sp_AltaEmpleado";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Apellido ", Apellido);
                    command.Parameters.AddWithValue("@Id_Doc", Id_Doc);
                    command.Parameters.AddWithValue("@Nro_Doc", Nº_Doc);
                    command.Parameters.AddWithValue("@Fecha_Nac", Fecha_Nac);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@Telefono1", Telefono1);
                    command.Parameters.AddWithValue("@Telefono2", Telefono2);
                    command.Parameters.AddWithValue("@Domicilio", Domicilio);
                    command.Parameters.AddWithValue("@Piso", Piso);
                    command.Parameters.AddWithValue("@Dpto", Dpto);
                    command.Parameters.AddWithValue("@Localidad", Localidad);
                    command.Parameters.AddWithValue("@Id_Provincia", Id_Provincia);
                    command.Parameters.AddWithValue("@Id_Sector", Id_Sector);
                    command.Parameters.AddWithValue("@Id_Puesto", Id_Puesto);
                    command.Parameters.AddWithValue("@foto ", SqlDbType.Image).Value = foto;
                    command.Parameters.AddWithValue("@CodigoPostal", CodigoPostal);
                    command.Parameters.AddWithValue("@Id_Sexo", Id_Sexo);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                    connection.Close();
                }
            }
        }
        public DataTable consultaSocio(int dni)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "sp_consulta_Socio";
                    command.Parameters.AddWithValue("@dni", dni);
                    DataTable dt = new DataTable();
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    dt.Load(reader);
                    connection.Close();
                    return dt;

                }
            }
        }
    }
}





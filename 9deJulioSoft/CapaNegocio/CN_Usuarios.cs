﻿using System;
using System.Collections.Generic;
using System.Data;
using CapaDatos;
using CapaSoporte;

namespace CapaNegocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios objUsuario = new CD_Usuarios();
        private Accesodatos objuserdatos = new Accesodatos();

        #region Atributos
        private int idusuarios;
        private string idRol;
        private string idusuarioAlta;

        #endregion

        #region Properties
        public int IdUsuario
        {
            get => idusuarios;
            set { idusuarios = value; }

        }
        public string IdRol
        {
            get => idRol;
            set { idRol = value; }
        }
        public string IdUsuarioAlta
        {
            get => idusuarioAlta;
            set { idusuarioAlta = value; }

        }

        public string Usuario { get; set; }
        #endregion

        private void PasarDatos()
        {

            objUsuario.IdUsuario = this.idusuarios;
            objUsuario.IdRol = Convert.ToInt32(idRol);
            objUsuario.IdUsuarioAlta = Convert.ToInt32(idusuarioAlta);
            


        }

        public void insertar_Datos()
        {
            PasarDatos();
            objUsuario.insertarUsurioRol();
        }

        public DataTable consultaUsuarioPermiso(string Usuario)
        {
            DataTable tabla = new DataTable();
            tabla = objUsuario.ConsultaUsuarioRol(Usuario);
            return tabla;
        }

        #region Attributes
        private int idUsuario;
        private string users;
        private string contrasenia;
        private string nombres;
        private string apellidos;
        private string estado;
        //private string cargo;
        #endregion

        public CN_Usuarios(int idUsuario, string users, string contrasenia, string nombres, string apellidos, string estado)
        {
            this.idUsuario = idUsuario;
            this.users = users;
            this.contrasenia = contrasenia;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.estado = estado;
            //this.cargo = cargo;
        }
        public CN_Usuarios(string users, string contrasenia, string nombres, string apellidos, string estado)
        {
            this.users = users;
            this.contrasenia = contrasenia;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.estado = estado;
            //this.cargo = cargo;
        }

        public CN_Usuarios()
        {
        }

        //private string email;
        //Constructors


        //public UserModel()
        //{
        //}
        //Methods
        public string editarPerfilUsuario()
        {

            //try
            //{
                objuserdatos.editarPerfil(idUsuario, users, contrasenia, nombres, apellidos, estado);
                return "Tu perfil se ha editado correctamente";
            //}
            //catch (Exception ex)
            //{
            //    return "Usuario existente, intente nuevamente" + ex;
            //}
        }
        public string altaUsuario()
        {
            objuserdatos.altaUsuario(users, contrasenia, nombres, apellidos, estado);
            return "El usuario se dio de alta correctamente";
        }

        public void actualizar_rol()
        {
            PasarDatos();
            objUsuario.actualizarRol();
        }

        public DataTable consultar_otroUsuario(string usuario)
        {
            DataTable tabla = new DataTable();
            tabla = objUsuario.EditarOtroUsuario(usuario);
            return tabla;
        }

        public DataTable No_EXiste(string Usuario)
        {
            DataTable tabla = new DataTable();
            tabla = objUsuario.NoExiste(Usuario);
            return tabla;
        }

        public List<CN_Usuarios> GetUsuarios()
        {
            var usuarios = new List<CN_Usuarios>();

            var user = new CN_Usuarios();
            user.IdUsuario = -1;
            user.Usuario = "TODOS";
            usuarios.Add(user);

            var dt = objUsuario.GetUsuarios();

            foreach (DataRow row in dt.Rows)
            {
                var usuario = new CN_Usuarios();

                usuario.IdUsuario = (int)row[0];
                usuario.Usuario = row[1].ToString();

                usuarios.Add(usuario);
            }

            return usuarios;
        }
    }
}

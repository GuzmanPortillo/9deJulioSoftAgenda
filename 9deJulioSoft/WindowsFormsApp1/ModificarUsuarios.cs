using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaSoporte.Cache;
using CapaNegocio;




namespace CapaPresentacion
{
    public partial class ModificarUsuarios : Form
    {
        public ModificarUsuarios()
        {
            InitializeComponent();
        }


        private void ModificarUsuarios_Load(object sender, EventArgs e)
        {
            llenarDatosEdicion();
        }

        private void llenarDatosEdicion()
        {
            txtNombres.Text = InicioSesion.nombres;
            txtApellidos.Text = InicioSesion.apellidos;
            txtUsuario.Text = InicioSesion.usuario;
            txtContraseña.Text = InicioSesion.contrasenia;
            txtConfirmarPass.Text = InicioSesion.contrasenia;
            txtContraseñaActual.Text = "";
            if(InicioSesion.estado == "Activo")
            {
                rbtActivo.Checked = true;
            }
            else
            {
                rbtInactivo.Checked = true;
            }
            Utiles.BloquearControles(this);
         
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(btnEditar.Text == "Editar")
            {               
                Utiles.DesbloquearControles(this);
            }
            
        }

        //private void initializePassEditControls()
        //{
        //    LinkEditPass.Text = "Edit";
        //    txtPassword.UseSystemPasswordChar = true;
        //    txtPassword.Enabled = false;
        //    txtConfirmPass.UseSystemPasswordChar = true;
        //    txtConfirmPass.Enabled = false;
        //}
        private void reset()
        {
            llenarDatosEdicion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string estadoUser;
            if(rbtActivo.Checked == true)
            {
            estadoUser = "Activo";
            }
            else
            {
             estadoUser = "Inactivo";
            }

            if (txtContraseña.Text.Length >= 5)
            {
                if (txtContraseña.Text == txtConfirmarPass.Text)
                {
                    if (txtContraseñaActual.Text == InicioSesion.contrasenia)
                    {
                        var modeloUsuario = new CN_Usuarios(
                            idUsuario: InicioSesion.idusuario,
                            users: txtUsuario.Text,
                            contrasenia: txtContraseña.Text,
                            nombres: txtNombres.Text,
                            apellidos: txtApellidos.Text,
                            estado: estadoUser);
                            
                        var resultado = modeloUsuario.editarPerfilUsuario();
                        MessageBox.Show(resultado);
                        reset();
                    }
                    else
                        MessageBox.Show("Contraseña inconrrecta, intentar nuevamente");
                }
                else
                    MessageBox.Show("La contraseña no coincide, intentar nuevamente");
            }
            else
                MessageBox.Show("La contraseña debe tener 5 caracteres minimos");

        }
    }
}

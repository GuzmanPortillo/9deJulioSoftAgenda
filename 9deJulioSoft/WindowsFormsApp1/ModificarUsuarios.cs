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
        private CN_Usuarios objUserModif = new CN_Usuarios();
        public ModificarUsuarios()
        {
            InitializeComponent();
        }


        private void ModificarUsuarios_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            llenarDatosEdicion();
            txtBucarUsuario.Visible = false;
            btnBuscar.Visible = false;
        }

        private void llenarDatosEdicion()
        {
            txtNombres.Text = InicioSesion.nombres;
            txtApellidos.Text = InicioSesion.apellidos;
            txtUsuario.Text = InicioSesion.usuario;
            txtContraseña.Text = InicioSesion.contrasenia;
            txtConfirmarPass.Text = "";
            txtContraseñaActual.Text = "";
            if(InicioSesion.estado == "Activo")
            {
                rbtActivo.Checked = true;
            }
            else
            {
                rbtInactivo.Checked = true;
                //rbtActivo.Checked = false;
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
                        //reset();
                        Utiles.LimpiarControles(this);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = objUserModif.consultar_otroUsuario(txtBucarUsuario.Text);
            if (dt.Rows.Count > 0)
            {
                string estado;
                DataRow dr = dt.Rows[0];
                txtNombres.Text = dr["Nombres"].ToString();
                txtApellidos.Text = dr["Apellidos"].ToString();
                txtContraseña.Text = dr["Contrasenia"].ToString();
                txtUsuario.Text = dr["Usuario"].ToString();
                estado = dr["Estado"].ToString();
                if (estado == "Activo")
                {
                    rbtActivo.Checked = true;
                }
                else
                {
                    rbtInactivo.Checked = true;
                    //rbtActivo.Checked = false;
                }

            }

        }

        private void BtnOtroUsuario_Click(object sender, EventArgs e)
        {
            txtBucarUsuario.Visible = true;
            btnBuscar.Visible = true;
            txtBucarUsuario.Enabled = true;
            Utiles.LimpiarControles(this);
        }

    }
}

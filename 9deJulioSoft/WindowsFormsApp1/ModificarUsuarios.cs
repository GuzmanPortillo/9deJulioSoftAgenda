using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaSoporte.Cache;
using CapaNegocio;
using System.IO;

namespace CapaPresentacion
{
    public partial class ModificarUsuarios : Form
    {
        private CN_Usuarios objUserModif = new CN_Usuarios();
        public ModificarUsuarios()
        {
            InitializeComponent();
        }

        int idUsuario = 0;

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
            idUsuario = InicioSesion.idusuario;
            txtConfirmarPass.Text = "";
            txtContraseñaNueva.Text = "";
            if (InicioSesion.estado == "Activo")
            {
                rbtActivo.Checked = true;
            }
            else
            {
                rbtInactivo.Checked = true;
            }
            if(InicioSesion.foto != null)
            {
                MemoryStream ms = new MemoryStream(InicioSesion.foto);
                Bitmap bm = new Bitmap(ms);
                picPerfil.Image = bm;
            }

            Utiles.BloquearControles(this);
        }
        private void reset()
        {
            Utiles.LimpiarControles(this);
            Utiles.BloquearControles(this);
            txtContraseña.PasswordChar = '*';
            picPerfil.Image = Utiles.ImagenUsuario();
            btnAccion.Text = "Modificar Usuario";
            btnAccion.Enabled = false;
            txtBucarUsuario.Enabled = true;
        }

        private bool GuardarCambios()
        {
            try
            {
                string estadoUser = (rbtActivo.Checked == true) ? "Activo" : "Inactivo";

                if (!string.IsNullOrEmpty(txtContraseñaNueva.Text))
                {
                    if (txtContraseñaNueva.Text.Length < 5)
                    {
                        MessageBox.Show("La contraseña debe tener 5 caracteres minimos");
                        return false;
                    }

                    if (txtContraseñaNueva.Text != txtConfirmarPass.Text)
                    {
                        MessageBox.Show("La contraseña no coincide, intentar nuevamente");
                        return false;
                    }
                }

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                picPerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                var modeloUsuario = new CN_Usuarios(
                    idUsuario: idUsuario,
                    users: txtUsuario.Text,
                    contrasenia: string.IsNullOrWhiteSpace(txtContraseñaNueva.Text) ? txtContraseña.Text : txtContraseñaNueva.Text,
                    nombres: txtNombres.Text,
                    apellidos: txtApellidos.Text,
                    estado: estadoUser,
                    foto: ms.GetBuffer());

                var resultado = modeloUsuario.editarPerfilUsuario();
                MessageBox.Show(resultado);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBucarUsuario.Text))
            {
                MessageBox.Show("Ingrese el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset();
                return;
            }
            string usuario = txtBucarUsuario.Text.Trim();
            DataTable dt = objUserModif.consultar_otroUsuario(txtBucarUsuario.Text.Trim());
            
            reset();
            
            txtBucarUsuario.Text = usuario;

            if (dt.Rows.Count > 0)
            {
                string estado;
                DataRow dr = dt.Rows[0];
                idUsuario = Convert.ToInt32(dr["id_usuario"]);
                txtNombres.Text = dr["Nombres"].ToString();
                txtApellidos.Text = dr["Apellidos"].ToString();
                txtContraseña.Text = dr["Contrasenia"].ToString();
                txtUsuario.Text = dr["Usuario"].ToString();
                estado = dr["Estado"].ToString();
                if (estado == "Activo")
                    rbtActivo.Checked = true;
                else
                    rbtInactivo.Checked = true;

                if(!string.IsNullOrEmpty(dr["foto"].ToString()))
                {
                    MemoryStream ms = new MemoryStream((byte[])dr["foto"]);
                    Bitmap bm = new Bitmap(ms);
                    picPerfil.Image = bm;
                }
                else
                {
                    picPerfil.Image = Utiles.ImagenUsuario();
                }

                btnAccion.Enabled = true;
            }
            else
            {
                MessageBox.Show("No existe el usuario a buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnOtroUsuario_Click(object sender, EventArgs e)
        {
            reset();
            txtBucarUsuario.Visible = true;
            btnBuscar.Visible = true;
            btnEditarFoto.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrarPass_Click(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = txtContraseña.PasswordChar == '*' ? '\0' : '*';
        }

        private void btnEditarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            foto.Filter = "Imagen JPG (*.jpg)|*.jpg";
            DialogResult rs = foto.ShowDialog();
            if (rs == DialogResult.OK)
            {
                picPerfil.Image = Image.FromFile(foto.FileName);
            }
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (btnAccion.Text == "Modificar Usuario")
            {
                Utiles.DesbloquearControles(this);
                btnAccion.Text = "Guardar";
                btnEditarFoto.Enabled = true;
            }
            else
            {
                if (GuardarCambios())
                    btnAccion.Text = "Modificar Usuario";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaSoporte.Cache;


namespace CapaPresentacion
{
    public partial class AltaUsuarios : Form
    {
        private CN_Usuarios objCNUsuarios = new CN_Usuarios();
        public AltaUsuarios()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataTable dt = objCNUsuarios.No_EXiste(txtUsuario.Text);
            if (dt.Rows.Count == 0)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                picPerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                if (txtConfirmarContrasenia.Text == txtContrasenia.Text)
                {
                    var modeloUsuario = new CN_Usuarios(
                                    users: txtUsuario.Text,
                                    contrasenia: txtContrasenia.Text,
                                    nombres: txtNombres.Text,
                                    apellidos: txtApellidos.Text,
                                    estado: "Activo",
                                      ms.GetBuffer());
                    var resultado = modeloUsuario.altaUsuario();
                    MessageBox.Show(resultado);
                    CN_Bitacora.Guardar(InicioSesion.idusuario, BitacoraEntidad.Usuario.ToString(), BitacoraAccion.Alta.ToString(), $"Alta de usuario {txtUsuario.Text}");
                    Utiles.LimpiarControles(this);
                }
                else
                    MessageBox.Show("La contraseña no coincide, intentar nuevamente");
            }
            else
                MessageBox.Show("Ya existe el usuario, ingrese otro");
        }
        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            DialogResult rs = foto.ShowDialog();
            if (rs == DialogResult.OK)
            {
                picPerfil.Image = Image.FromFile(foto.FileName);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

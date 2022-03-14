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
        public AltaUsuarios()
        {
            InitializeComponent();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtConfirmarContrasenia.Text == txtContrasenia.Text)
            { 
                var modeloUsuario = new CN_Usuarios(
                                //idUsuario: InicioSesion.idusuario,
                                users: txtUsuario.Text,
                                contrasenia: txtContrasenia.Text,
                                nombres: txtNombres.Text,
                                apellidos: txtApellidos.Text,
                                estado: "Activo");
                var resultado = modeloUsuario.altaUsuario();
                MessageBox.Show(resultado);

                CN_Bitacora.Guardar(InicioSesion.idusuario, BitacoraEntidad.Usuario.ToString(), BitacoraAccion.Alta.ToString(), $"Alta de usuario {txtUsuario.Text}");
                Utiles.LimpiarControles(this);
            }
            else
                MessageBox.Show("La contraseña no coincide, intentar nuevamente");
            
            
        }

      
    }
}

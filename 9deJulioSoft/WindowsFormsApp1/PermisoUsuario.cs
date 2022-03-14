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

namespace CapaPresentacion

{
    public partial class PermisoUsuario : Form
    {
        private CN_Usuarios objusuarioModel = new CN_Usuarios();
        public PermisoUsuario()
        {
            InitializeComponent();
        }


        private void LlenarCombo(ComboBox cb, string NombreTabla, string CampoID, string CampoDescrip, string Condicion = "")
        {
            CN_LlenarCombos LC = new CN_LlenarCombos();

            LC.NomTabla = NombreTabla;
            LC.CampoId = CampoID;
            LC.CampoDescrip = CampoDescrip;
            LC.Condicion = Condicion;

            cb.DataSource = LC.Cargar();
            cb.DisplayMember = CampoDescrip;
            cb.ValueMember = CampoID;
            cb.SelectedIndex = -1;
        }

        private void PermisoUsuario_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboRoles, "rol", "Id_Rol", "Nombre");
            grbAlta.Enabled = false;
            grbContieneGrilla.Enabled = false;
        }
        private void mostrarUsuarioPermiso(string usuario)
        {
            dgvPermisoUsuario.DataSource = objusuarioModel.consultaUsuarioPermiso(usuario);
        }

        private void Hacer_pasajeDatos()
        {
            objusuarioModel.IdUsuario = Convert.ToInt32(dgvPermisoUsuario.SelectedRows[0].Cells[0].Value.ToString());
            objusuarioModel.IdRol = cboRoles.SelectedValue.ToString();
        }
        private void Hacer_pasajeDatosAlta()
        {
            objusuarioModel.IdUsuarioAlta = cboUsuarios.SelectedValue.ToString();
            objusuarioModel.IdRol = cboRoles.SelectedValue.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grbContieneBotones.Enabled = true;
            btnGuardar.Enabled = false;
        }

        private void dgvPermisoUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboUsuarios.Text = dgvPermisoUsuario.SelectedRows[0].Cells[1].Value.ToString();
            cboRoles.SelectedValue = Convert.ToInt32(dgvPermisoUsuario.SelectedRows[0].Cells[4].Value.ToString());
            grbAlta.Enabled = true;
            cboUsuarios.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mostrarUsuarioPermiso(txtBuscarUsuario.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Hacer_pasajeDatosAlta();
                objusuarioModel.insertar_Datos();
                MessageBox.Show("Se guardó correctamente");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al guardar los dator por: \n" + error);

            }
        }

        private void rbtAlta_CheckedChanged(object sender, EventArgs e)
        {
            grbAlta.Enabled = true;
            LlenarCombo(cboUsuarios, "tusuario", "id_usuario", "usuario");
            grbContieneGrilla.Enabled = false;
            btnGuardarCambios.Visible = false;
            rbtModificacion.Checked = false;
            btnGuardar.Visible = true;
        }

        private void rbtModificacion_CheckedChanged(object sender, EventArgs e)
        {
            grbContieneGrilla.Enabled = true;
            grbAlta.Enabled = false;
            rbtAlta.Checked = false;
            btnGuardar.Visible = false;
            btnGuardarCambios.Visible = true;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                Hacer_pasajeDatos();
                objusuarioModel.actualizar_rol();
                MessageBox.Show("Se actualizó correctamente");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al guardar los cambios por: \n" + error);
            }
        }
    }
}

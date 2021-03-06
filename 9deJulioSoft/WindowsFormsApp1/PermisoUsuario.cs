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
        private bool comboLlenado = false;

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
            LlenarCombo(cboUsuarios, "tusuario", "id_usuario", "usuario");
            comboLlenado = true;
        }
        private void mostrarUsuarioPermiso(int idUsuario)
        {
            dgvPermisoUsuario.DataSource = null;
            dgvPermisoUsuario.Columns.Clear();
            dgvPermisoUsuario.Refresh();

            dgvPermisoUsuario.DataSource = objusuarioModel.consultaUsuarioPermiso(idUsuario);

            for (int i = 0, j = dgvPermisoUsuario.Columns.Count - 2; i < j; i++)
                dgvPermisoUsuario.Columns[i].ReadOnly = true;

            dgvPermisoUsuario.Columns["Id_Rol"].Visible = false;
            dgvPermisoUsuario.Columns["IdPermiso"].Visible = false;
            dgvPermisoUsuario.Columns["Activo"].Visible = false;

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.Name = "ActivoMod";
            chk.HeaderText = "Permitir";

            dgvPermisoUsuario.Columns.Add(chk);

            dgvPermisoUsuario.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0, j = dgvPermisoUsuario.Rows.Count; i < j; i++)
                dgvPermisoUsuario[4, i].Value = dgvPermisoUsuario[3, i].Value;


            dgvPermisoUsuario.Refresh();
        }

        private void Hacer_pasajeDatos(DataGridViewRow row)
        {
            objusuarioModel.IdUsuario = Convert.ToInt32(cboUsuarios.SelectedValue);
            objusuarioModel.IdRol = row.Cells["Id_Rol"].Value.ToString();
            objusuarioModel.Permitir = Convert.ToBoolean(row.Cells["ActivoMod"].Value);
       }

        private void cboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboLlenado)
                return;

            if (cboUsuarios.SelectedIndex > -1)
                mostrarUsuarioPermiso(Convert.ToInt32(cboUsuarios.SelectedValue));

            btnGuardar.Enabled = cboUsuarios.SelectedIndex > -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                List<DataGridViewRow> permisos = dgvPermisoUsuario.Rows.Cast<DataGridViewRow>().ToList();
                var resultado = MessageBox.Show("Desea guardar los cambios", "Permisos usuarios",
                                                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    foreach (DataGridViewRow item in permisos)
                    {
                        Hacer_pasajeDatos(item);
                        objusuarioModel.actualizar_rol();
                    }
                    MessageBox.Show("Se actualizó correctamente");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error " + error.Message);
            }
        }
    }
}

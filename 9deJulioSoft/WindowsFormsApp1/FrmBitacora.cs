using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaSoporte.Cache;

namespace CapaPresentacion
{
    public partial class FrmBitacora : Form
    {
        public FrmBitacora()
        {
            InitializeComponent();
        }

        private void FrmBitacora_Load(object sender, EventArgs e)
        {
            var usuarioNegocio = new CN_Usuarios();
            var usuarios = new List<CN_Usuarios>();

            usuarios = usuarioNegocio.GetUsuarios();
            
            cboUsuario.DataSource = usuarios;
            cboUsuario.ValueMember = "IdUsuario";
            cboUsuario.DisplayMember = "Usuario";

            cboEntidad.DataSource = Enum.GetValues(typeof(BitacoraEntidad));
            cboAccion.DataSource = Enum.GetValues(typeof(BitacoraAccion));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var dt = new DataTable();
            int idUsuario = (int) cboUsuario.SelectedValue;
            string entidad = cboEntidad.SelectedItem.ToString();
            string accion = cboAccion.SelectedItem.ToString();

            dt = CN_Bitacora.getAll(dtpDesde.Value.Date, dtpHasta.Value, idUsuario, entidad, accion);

            DgvBitacora.DataSource = dt;          
            DgvBitacora.AutoResizeColumns();
            DgvBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron datos para los filtros ingresados","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now;
            dtpHasta.Value = DateTime.Now;
            cboUsuario.SelectedIndex = 0;
            cboEntidad.SelectedIndex = 0;
            cboAccion.SelectedIndex = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

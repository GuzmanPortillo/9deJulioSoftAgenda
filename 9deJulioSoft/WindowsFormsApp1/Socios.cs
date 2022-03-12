using System.Windows.Forms;
using System;
using CapaNegocio;
using System.Data;
namespace CapaPresentacion
{
    public partial class Socios : Form
    {
        public Socios()
        {
            InitializeComponent();
        }

        private void buscar_socio()
        {
            CN_ModificarSocio modificarSocio = new CN_ModificarSocio();
            DataTable dt = modificarSocio.consulta_socio(int.Parse(txtNumDoc.Text));

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                txtApellido.Text = dr["Apellido"].ToString();
                txtDomicilio.Text = dr["Domicilio"].ToString();
                txtCP.Text = dr["CodigoPostal"].ToString();
                txtDpto.Text = dr["Dpto"].ToString();
                txtEmail.Text = dr["email"].ToString();
                txtNombre.Text = dr["Nombre"].ToString();
                txtNumSocio.Text = dr["id_socios"].ToString();
                txtPiso.Text = dr["Piso"].ToString();
                txtTel1.Text = dr["Telefono1"].ToString();
                txtTel2.Text = dr["Telefono2"].ToString();
                txtCategoria.Text = dr["Categoria"].ToString();
                cboLocalidad.SelectedValue = int.Parse(dr["Localidad"].ToString());
                cbDeporte1.SelectedValue = int.Parse(dr["Id_Deporte1"].ToString());
                cbDeporte2.SelectedValue = int.Parse(dr["Id_Deporte2"].ToString());
                cbEstado.SelectedValue = int.Parse(dr["Id_Estado"].ToString());
                cbProv.SelectedValue = int.Parse(dr["Id_provincia"].ToString());
                cbSexo.SelectedValue = int.Parse(dr["Id_sexo"].ToString());
                cbTipodoc.SelectedValue = int.Parse(dr["Id_doc"].ToString());
                dtpFecNacimiento.Value = DateTime.Parse(dr["Fecha_Nac"].ToString());
            }
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            buscar_socio();
        }

        private void Socios_Load(object sender, EventArgs e)
        {
            llenar_Combos();

        }
        private void llenar_Combos()
        {
            LlenarCombo(cbTipodoc, "Tipo_Documento", "Id_Doc", "Tipo");
            LlenarCombo(cbSexo, "Sexo", "Id_Sexo", "Sexo");
            LlenarCombo(cbProv, "Provincia", "Id_Provincia", "Nombre");
            LlenarCombo(cbEstado, "Estado", "Id_Estado", "Estado");
            LlenarCombo(cbDeporte1, "Deporte", "Id_Deporte", "Nombre");
            LlenarCombo(cbDeporte2, "Deporte", "Id_Deporte", "Nombre");
        }
        //Metodo LLenar ComboS  
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
    }
}

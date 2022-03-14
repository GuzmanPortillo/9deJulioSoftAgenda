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
            DataTable dt = modificarSocio.consulta_socio(int.Parse(txtDniBuscar.Text));

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                txtApellido.Text = dr["Apellido"].ToString();
                txtDomicilio.Text = dr["Domicilio"].ToString();
                txtNumDoc.Text = dr["Nro_doc"].ToString();
                txtCP.Text = dr["CodigoPostal"].ToString();
                txtDpto.Text = dr["Dpto"].ToString();
                txtEmail.Text = dr["email"].ToString();
                txtNombre.Text = dr["Nombre"].ToString();
                txtNumSocio.Text = dr["id_socios"].ToString();
                txtPiso.Text = dr["Piso"].ToString();
                txtTel1.Text = dr["Telefono1"].ToString();
                txtTel2.Text = dr["Telefono2"].ToString();
                txtCategoria.Text = dr["Categoria"].ToString();
                txtLocalidad.Text = dr["Localidad"].ToString();
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
            Utiles.BloquearControles(this);
            txtDniBuscar.Enabled = true;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Utiles.DesbloquearControles(this);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //pcbx1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                if (!string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    if (!string.IsNullOrWhiteSpace(cbTipodoc.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(txtNumDoc.Text))
                        {
                            if (!string.IsNullOrWhiteSpace(dtpFecNacimiento.Text))
                            {
                                if (!string.IsNullOrWhiteSpace(txtTel1.Text) || !string.IsNullOrWhiteSpace(txtTel2.Text))
                                {
                                    if (!string.IsNullOrWhiteSpace(txtDomicilio.Text))
                                    {
                                        if (!string.IsNullOrWhiteSpace(txtLocalidad.Text))
                                        {
                                            if (!string.IsNullOrWhiteSpace(cbProv.Text))
                                            {
                                                if (!string.IsNullOrWhiteSpace(txtCategoria.Text))
                                                {
                                                    if (!string.IsNullOrWhiteSpace(cbEstado.Text))
                                                    {
                                                        if (!string.IsNullOrWhiteSpace(txtCP.Text))
                                                        {
                                                            if (!string.IsNullOrWhiteSpace(cbSexo.Text))
                                                            {
                                                                var socioModel = new CN_ModificarSocio(
                                                                 //Id_Socio: 0,
                                                                 Nombre: txtNombre.Text,
                                                                 Apellido: txtApellido.Text,
                                                                 Id_Doc: cbTipodoc.SelectedValue.ToString(),
                                                                 nro_doc: int.Parse(txtNumDoc.Text),
                                                                 Fecha_Nac: dtpFecNacimiento.Value.ToString("yyyy-MM-dd"),
                                                                 email: txtEmail.Text,
                                                                 Telefono1: txtTel1.Text,
                                                                 Telefono2: txtTel2.Text,
                                                                 Domicilio: txtDomicilio.Text,
                                                                 Piso: txtPiso.Text,
                                                                 Dpto: txtDpto.Text,
                                                                 Localidad: txtLocalidad.Text,
                                                                 Id_Provincia: cbProv.SelectedValue.ToString(),
                                                                 Categoria: txtCategoria.Text,
                                                                 Id_Deporte1: cbDeporte1.SelectedValue.ToString(),
                                                                 Id_Deporte2: cbDeporte2.SelectedValue.ToString(),
                                                                 Id_Estado: cbEstado.SelectedValue.ToString(),
                                                                 foto: ms.GetBuffer(),
                                                                 CodigoPostal: txtCP.Text,
                                                                 Id_Sexo: cbSexo.SelectedValue.ToString());
                                                                var result = socioModel.editar_socio();
                                                                MessageBox.Show(result);
                                                                Utiles.LimpiarControles(this);


                                                            }
                                                            else
                                                                MessageBox.Show("Ingrese el Sexo");
                                                        }
                                                        else
                                                            MessageBox.Show("Ingrese el Codigo Postal");
                                                    }
                                                    else
                                                        MessageBox.Show("Ingrese el estado del socio");
                                                }
                                                else
                                                    MessageBox.Show("Ingrese la categoria");
                                            }
                                            else
                                                MessageBox.Show("Ingrese la provincia");
                                        }
                                        else
                                            MessageBox.Show("Ingrese la localidad");
                                    }
                                    else
                                        MessageBox.Show("Ingrese el domicilio");
                                }
                                else
                                    MessageBox.Show("Ingrese al menos un número de telefono de contacto");
                            }
                            else
                                MessageBox.Show("Ingrese fecha de nacimiento");
                        }
                        else
                            MessageBox.Show("Ingrese número de documento");
                    }
                    else
                        MessageBox.Show("Ingrese Tipo de Documento");
                }
                else
                    MessageBox.Show("Ingrese Apellido");
            }
            else
                MessageBox.Show("Ingrese Nombre");
        }
    }
}

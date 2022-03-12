using CapaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class AltaEmpleados : Form
    {
        public AltaEmpleados()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pcbx1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            { if (!string.IsNullOrWhiteSpace(txtApellido.Text))
                { if (!string.IsNullOrWhiteSpace(cbTipodoc.Text))
                    { if (!string.IsNullOrWhiteSpace(txtNumDoc.Text))
                        { if (!string.IsNullOrWhiteSpace(dateTimePicker1.Text))
                            { if (!string.IsNullOrWhiteSpace(txtTel1.Text) || !string.IsNullOrWhiteSpace(txtTel2.Text))
                                { if (!string.IsNullOrWhiteSpace(txtDomicilio.Text))
                                    { if (!string.IsNullOrWhiteSpace(txtLocalidad.Text))
                                        { if (!string.IsNullOrWhiteSpace(cbProv.Text))
                                            { if (!string.IsNullOrWhiteSpace(cbSector.Text))
                                                 { if (!string.IsNullOrWhiteSpace(cbPuesto.Text))
                                                      {   if (!string.IsNullOrWhiteSpace(txtCP.Text))
                                                             {  if (!string.IsNullOrWhiteSpace(cbSexo.Text))
                                                                   {    var empleadoModel = new ModeloEmpleado(
                                                              Id_Socio: 0,
                                                              Nombre: txtNombre.Text,
                                                              Apellido: txtApellido.Text,
                                                              Id_Doc: cbTipodoc.SelectedValue.ToString(),
                                                              Nº_Doc: txtNumDoc.Text,
                                                              Fecha_Nac: dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                                                              email: txtEmail.Text,
                                                              Telefono1: txtTel1.Text,
                                                              Telefono2: txtTel2.Text,
                                                              Domicilio: txtDomicilio.Text,
                                                              Piso: txtPiso.Text,
                                                              Dpto: txtDpto.Text,
                                                              Localidad: txtLocalidad.Text,
                                                              Id_Provincia: cbProv.SelectedValue.ToString(),
                                                              Id_Sector: cbSector.SelectedValue.ToString(),
                                                              Id_Puesto: cbPuesto.SelectedValue.ToString(),
                                                              foto: ms.GetBuffer(),
                                                              CodigoPostal: txtCP.Text,
                                                              Id_Sexo: cbSexo.SelectedValue.ToString());;
                                                              var result = empleadoModel.CrearEmpleadoProfile();
                                                              MessageBox.Show(result);
                                                              
                                                            } else
                                                              MessageBox.Show("Ingrese el Sexo");
                                                      } else
                                                      MessageBox.Show("Ingrese el Codigo Postal");
                                                 } else
                                                 MessageBox.Show("Ingrese el sector");
                                             }else
                                             MessageBox.Show("Ingrese el puesto");
                                         } else
                                         MessageBox.Show("Ingrese la provincia");
                                    } else
                                    MessageBox.Show("Ingrese la localidad");
                                } else
                                MessageBox.Show("Ingrese el domicilio");
                            } else
                            MessageBox.Show("Ingrese al menos un número de telefono de contacto");
                        } else
                        MessageBox.Show("Ingrese fecha de nacimiento");
                    } else
                    MessageBox.Show("Ingrese número de documento");
                } else
                MessageBox.Show("Ingrese Tipo de Documento");
            } else
            MessageBox.Show("Ingrese Apellido");
        } else
        MessageBox.Show("Ingrese Nombre");
               
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
        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtEmail_TextChanged_1(object sender, EventArgs e)
        {
            Validar_email val = new Validar_email();
            val.Correo = txtEmail.Text;
            if (val.Valid() != true)
            {
                txtEmail.ForeColor = Color.Red;
            }
            else
            {
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void AltaEmpleados_Load_1(object sender, EventArgs e)
        {
            LlenarCombo(cbTipodoc, "Tipo_Documento", "Id_Doc", "Tipo");
            LlenarCombo(cbSexo, "Sexo", "Id_Sexo", "Sexo");
            LlenarCombo(cbProv, "Provincia", "Id_Provincia", "Nombre");
            LlenarCombo(cbSector, "Sector", "Id_Sector", "Nombre");
            LlenarCombo(cbPuesto, "Puesto", "Id_Puesto", "Nombre");
        }

        private void btnCargarFoto_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            DialogResult rs = foto.ShowDialog();
            if (rs == DialogResult.OK)
            {
                pcbx1.Image = Image.FromFile(foto.FileName);
            }
        }

        private void btnLimpiarP_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarControles(this);
        }
    }



}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class CargarEventos : Form
    {
        CN_Agenda AgendaNegocio = new CN_Agenda();

        public int IdEspacio { get; set; }

        public CargarEventos()
        {
            InitializeComponent();
        }
        private static DateTime diaActual = DateTime.Today;

        public int idAPP = 0;
        private void CargarEventos_Load(object sender, EventArgs e)
        {
            AgendaDeportiva frm = new AgendaDeportiva();
            LlenarCombo(cboEstablecimiento, "EstablecimientoLugar", "idEspacioEst", "Espacio");

            if (idAPP == 0) //Nuevo
            {
                cboEstablecimiento.SelectedIndex = 0;
                btnEliminar.Enabled = false;
            }
            else 
            {
                cboEstablecimiento.SelectedValue = this.IdEspacio; 
            }
            
        }
        
        private void Hacer_pasajeDatos()
        {
            AgendaNegocio.ID = Convert.ToInt32(idAPP);
            AgendaNegocio.Fecha = dtpTiempo.Value.Date;
            AgendaNegocio.Hora = msktxtHora.Text;
            AgendaNegocio.NombreEvento = txtEvento.Text;
            AgendaNegocio.Espacio = (int) cboEstablecimiento.SelectedValue;

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
            //cb.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Hacer_pasajeDatos();
                if (AgendaNegocio.DatosValidos())
                {
                    string mensaje = string.Empty;

                    if (this.idAPP == 0) //Nuevo
                    {
                        AgendaNegocio.insertar_Datos();
                        mensaje = "Se guardó el evento correctamente";
                    }
                    else
                    {
                        AgendaNegocio.Actualizar_datos();
                        mensaje = "Se actualizó el evento correctamente";
                    }
                    
                    MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(AgendaNegocio.Error, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     

        //private void btnActualizar_Click(object sender, EventArgs e)
        //{
        //    DesbloquearControles(this);
        //    btnFormularios(this, btnActualizar);
        //    msktxtHora.Focus();
        //    LlenarCombo(cboEstablecimiento, "EstablecimientoLugar", "idEspacioEst", "Espacio");
        //}

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = MessageBox.Show("Desea realmente eliminar Evento", "Eliminar Evento",
                                                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    AgendaNegocio.ID = Convert.ToInt32(idAPP);
                    AgendaNegocio.Eliminar();
                }

                MessageBox.Show("Se eliminó correctamente","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception error)
            {
                Console.WriteLine("Ocurrió un error " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboEstablecimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LlenarCombo(cboEstablecimiento, "EstablecimientoLugar", "id", "Espacio");
        }

        private void txtEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //private void btmGuardarCambios_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Hacer_pasajeDatos();
        //        AgendaNegocio.Actualizar_datos();
        //        MessageBox.Show("Se actualizó correctamente");
        //    }
        //    catch(Exception error)
        //    {
        //        Console.WriteLine("Ocurrió un error " + error.Message);
        //    }
        //}


        #region Botonera
        //private void btnFormularios(Form fAux, Button btn)
        //{
        //    string nombre = btn.Name;
        //    switch (nombre)
        //    {
        //        case "btnAgregar":
        //            foreach (Control c in fAux.Controls)
        //            {
        //                if (c is GroupBox | c is Panel)
        //                {
        //                    foreach (Object x in c.Controls)
        //                    {
        //                        if (x is Button)
        //                        {
        //                            if (((Button)x).Name == "btnAgregar")
        //                            {
        //                                ((Button)x).Enabled = false;
        //                                ((Button)x).Visible = false;
        //                            }
        //                            if (((Button)x).Name == "btnGuardar")
        //                            {
        //                                ((Button)x).Enabled = true;
        //                                ((Button)x).Visible = true;
        //                            }
        //                            if (((Button)x).Name == "btnActualizar")
        //                            {
        //                                ((Button)x).Enabled = false;
        //                                ((Button)x).Visible = false;
        //                            }
        //                            if (((Button)x).Name == "btnGuardarCambios")
        //                            {
        //                                ((Button)x).Enabled = false;
        //                                ((Button)x).Visible = false;
        //                            }
        //                            if (((Button)x).Name == "btnCancelar")
        //                            {
        //                                ((Button)x).Enabled = true;
        //                                ((Button)x).Visible = true;
        //                            }
        //                            if (((Button)x).Name == "btnEliminar")
        //                            {
        //                                ((Button)x).Enabled = false;
        //                                ((Button)x).Visible = false;
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //            break;
        //        case "btnGuardar":
        //            foreach (Control c in fAux.Controls)
        //            {
        //                if (c is GroupBox | c is Panel)
        //                {
        //                    foreach (object x in c.Controls)
        //                    {
        //                        if (x is Button)
        //                        {
        //                            if (((Button)x).Name == "btnAgregar")
        //                            {
        //                                ((Button)x).Enabled = true;
        //                                ((Button)x).Visible = true;
        //                            }
        //                            if (((Button)x).Name == "btnGuardar")
        //                            {
        //                                ((Button)x).Enabled = false;
        //                                ((Button)x).Visible = false;
        //                            }
        //                            if (((Button)x).Name == "btnActualizar")
        //                            {
        //                                ((Button)x).Enabled = true;
        //                                ((Button)x).Visible = true;
        //                            }
        //                            if (((Button)x).Name == "btnGuardarCambios")
        //                            {
        //                                ((Button)x).Enabled = false;
        //                                ((Button)x).Visible = false;
        //                            }
        //                            if (((Button)x).Name == "btnCancelar")
        //                            {
        //                                ((Button)x).Enabled = false;
        //                                ((Button)x).Visible = false;
        //                            }
        //                            if (((Button)x).Name == "btnEliminar")
        //                            {
        //                                ((Button)x).Enabled = true;
        //                                ((Button)x).Visible = true;
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //            break;
        //        case "btnmodificar":
        //            foreach (Control c in fAux.Controls)
        //            {
        //                if (c is GroupBox | c is Panel)
        //                {
        //                    foreach (object x in c.Controls)
        //                    {
        //                        if (x is Button)
        //                        {
        //                            if (((Button)x).Name == "btnAgregar")
        //                            {
        //                                ((Button)x).Enabled = false;
        //                                ((Button)x).Visible = false;
        //                            }
        //                            if (((Button)x).Name == "btnGuardar")
        //                            {
        //                                ((Button)x).Enabled = false;
        //                                ((Button)x).Visible = false;
        //                            }
        //                            if (((Button)x).Name == "btnActualizar")
        //                            {
        //                                ((Button)x).Enabled = false;
        //                                ((Button)x).Visible = false;
        //                            }
        //                            if (((Button)x).Name == "btnGuardaCambios")
        //                            {
        //                                ((Button)x).Enabled = true;
        //                                ((Button)x).Visible = true;
        //                            }
        //                            if (((Button)x).Name == "btnCancelar")
        //                            {
        //                                ((Button)x).Enabled = true;
        //                                ((Button)x).Visible = true;
        //                            }
        //                            if (((Button)x).Name == "btnEliminar")
        //                            {
        //                                ((Button)x).Enabled = false;
        //                                ((Button)x).Visible = false;
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //            break;
        //        case "btnGuardarCambios":
        //            foreach (Control c in fAux.Controls)
        //            {
        //                if (c is GroupBox | c is Panel)
        //                {
        //                    foreach (object x in c.Controls)
        //                    {
        //                        if (x is Button)
        //                        {
        //                            if (((Button)x).Name == "btnAgregar")
        //                            {
        //                                ((Button)x).Enabled = true;
        //                                ((Button)x).Visible = true;
        //                            }
        //                            if (((Button)x).Name == "btnGuardar")
        //                            {
        //                                ((Button)x).Enabled = false;
        //                                ((Button)x).Visible = false;
        //                            }
        //                            if (((Button)x).Name == "btnActualizar")
        //                            {
        //                                ((Button)x).Enabled = true;
        //                                ((Button)x).Visible = true;
        //                            }
        //                            if (((Button)x).Name == "btnGuardarCambios")
        //                            {
        //                                ((Button)x).Enabled = false;
        //                                ((Button)x).Visible = false;
        //                            }
        //                            if (((Button)x).Name == "btnCancelar")
        //                            {
        //                                ((Button)x).Enabled = false;
        //                                ((Button)x).Visible = false;
        //                            }
        //                            if (((Button)x).Name == "btnEliminar")
        //                            {
        //                                ((Button)x).Enabled = true;
        //                                ((Button)x).Visible = true;
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //            break;
        //        case "btnEliminar":
        //            foreach (Control c in fAux.Controls)
        //            {
        //                if (c is GroupBox | c is Panel)
        //                {
        //                    foreach (object x in c.Controls)
        //                    {

        //                    }
        //                }
        //            }
        //            break;
        //        case "btnCancelar":
        //            foreach (Control c in fAux.Controls)
        //            {
        //                if (c is GroupBox | c is Panel)
        //                {
        //                    foreach (object x in c.Controls)
        //                    {
        //                        if (x is Button)
        //                        {
        //                            if (((Button)x).Name == "btnAgregar")
        //                            {
        //                                ((Button)x).Enabled = true;
        //                                ((Button)x).Visible = true;
        //                            }
        //                            if (((Button)x).Name == "btnGuardar")
        //                            {
        //                                ((Button)x).Enabled = false;
        //                                ((Button)x).Visible = false;
        //                            }
        //                            if (((Button)x).Name == "btnActualizar")
        //                            {
        //                                ((Button)x).Enabled = true;
        //                                ((Button)x).Visible = true;
        //                            }
        //                            if (((Button)x).Name == "btnGuardarCambios")
        //                            {
        //                                ((Button)x).Enabled = false;
        //                                ((Button)x).Visible = false;
        //                            }
        //                            if (((Button)x).Name == "btnCancelar")
        //                            {
        //                                ((Button)x).Enabled = false;
        //                                ((Button)x).Visible = false;
        //                            }
        //                            if (((Button)x).Name == "btnEliminar")
        //                            {
        //                                ((Button)x).Enabled = true;
        //                                ((Button)x).Visible = true;
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //            break;
        //    }
        //}
        #endregion


        
       

        private void cmdCancelar_Click(object sender, EventArgs e)
        {

        }

        private void dtpTiempo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

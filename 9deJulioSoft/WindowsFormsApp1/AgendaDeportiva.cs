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
    public partial class AgendaDeportiva : Form
    {
        CN_Agenda objEventos = new CN_Agenda();
        public AgendaDeportiva()
        {
            InitializeComponent();
        }

        private static DateTime diaActual = DateTime.Now;

        List<FlowLayoutPanel> listafl = new List<FlowLayoutPanel>();

        public void MostraDiaActual()
        {
            lblMesAño.Text = diaActual.ToString("MMMM,yyy");
            CargarLblDiaFl(ObtenerPrimerDiaSemana(), totalDias());
            traerFlnumero(ObtenerPrimerDiaSemana());
        }
        private void MesAnterior()
        {
            diaActual = diaActual.AddMonths(-1);
            MostraDiaActual();
        }

        private void SiguienteMes()

        {
            diaActual = diaActual.AddMonths(1);
            MostraDiaActual();
        }
        private void MostrarHoy()
        {
            diaActual = diaActual = DateTime.Today;
            MostraDiaActual();
        }

        public static int ObtenerPrimerDiaSemana()
        {
            DateTime PrimerDiaActual = new DateTime(diaActual.Year, diaActual.Month, 1);
            int diaSemana = Convert.ToInt32(PrimerDiaActual.DayOfWeek);

            return diaSemana + 1;
        }
        public static int totalDias()
        {
            DateTime totaldias = new DateTime(diaActual.Year, diaActual.Month, 1);
            int tdias = Convert.ToInt32(totaldias.AddMonths(1).AddDays(-1).Day);

            return tdias;
        }
        private void AgendaDeportiva_Load(object sender, System.EventArgs e)
        {
            GenerarDiaPanel(42);
            MostraDiaActual();
        }


        private void CargarNuevoEvento(object sender, System.EventArgs e)
        {
            int day = (int)((FlowLayoutPanel)sender).Tag;

            CargarEventos frm = new CargarEventos();
            if (day != 0) 
            {
                frm.idAPP = 0;
                ((DateTimePicker)frm.Controls["dtpTiempo"]).Value = new DateTime(diaActual.Year, diaActual.Month, day);
                ((MaskedTextBox)frm.Controls["msktxtHora"]).Text = "";
                ((TextBox)frm.Controls["txtEvento"]).Text = "";
                ((ComboBox)frm.Controls["cboEstablecimiento"]).Text = "";

                frm.ShowDialog();

            }
            MostraDiaActual();
            
        }

        private void GenerarDiaPanel(int TotalDias)
        {
            flowLayoutPanel1.Controls.Clear();
            listafl.Clear();

            for (int i = 0; i <= TotalDias; i++)
            {
                FlowLayoutPanel flp = new FlowLayoutPanel();
                flp.Name = $"fldias{i}";
                flp.Size = new Size(98, 66);
                flp.BackColor = Color.White;
                flp.BorderStyle = BorderStyle.FixedSingle;
                flp.Cursor = Cursors.Hand;
                flp.AutoScroll = true;
                flp.Click += new EventHandler(CargarNuevoEvento);
                flowLayoutPanel1.Controls.Add(flp);
                listafl.Add(flp);
            }
        }
        private void MostrardetalleEvento(object sender, System.EventArgs e)
        {
            int idapp = (int)((LinkLabel)sender).Tag;

            DataTable dt = objEventos.consultarEventoItem(idapp);
            
            DataRow fil =  dt.Rows[0];
            {
              
                CargarEventos frm = new CargarEventos();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.idAPP = idapp;
                ((DateTimePicker)frm.Controls["dtpTiempo"]).Value = DateTime.Parse(fil["Fecha"].ToString());
                ((MaskedTextBox)frm.Controls["msktxtHora"]).Text = fil["Hora"].ToString();
                ((TextBox)frm.Controls["txtEvento"]).Text = fil["Nombre"].ToString();
                frm.IdEspacio = int.Parse(fil["idEspacio"].ToString());
                //((ComboBox)frm.Controls["cboEstablecimiento"]).Text = fil["Espacio"].ToString();

                frm.ShowDialog();

            }
            MostraDiaActual();
        }
        private void CargarLblDiaFl(int empezarDiasFl, int totalDiasMes)
        {
            foreach (FlowLayoutPanel fl in listafl)
            {
                fl.Controls.Clear();
                fl.Tag = 0;
            }

            for (int i = 1; i < totalDiasMes + 1 ; i++)
            {
                Label lbl = new Label();
                lbl.Name = $"lblDia{i}";
                lbl.AutoSize = false;
                lbl.TextAlign = ContentAlignment.MiddleRight;
                lbl.Size = new Size(86, 26);
                lbl.Text = i.ToString();
                lbl.Font = new Font("Microsoft sans serid", 12);
                listafl.Add(new FlowLayoutPanel());
                listafl[i - 2 + empezarDiasFl].Controls.Clear();
                listafl[i - 2 + empezarDiasFl].Controls.Add(lbl);
                listafl[i - 2 + empezarDiasFl].Tag = i;
            }
        }
        private void traerFlnumero(int DiaInicio)
        {
            //int idappp = (int)((LinkLabel)sender).Tag;
            DateTime iniciofecha = new DateTime(diaActual.Year, diaActual.Month, 1);
            DateTime finfecha = iniciofecha.AddMonths(1).AddDays(-1);

            DataTable dt = objEventos.consultarAgenda(iniciofecha.ToString("yyyyMMdd"), finfecha.ToString("yyyyMMdd"));

            foreach (DataRow fila in dt.Rows)
            {

                DateTime diaApp = DateTime.Parse(fila["Fecha"].ToString());
                LinkLabel link = new LinkLabel();
                link.Tag = fila["id"];
                link.Name = $"link{fila["id"]}";
                link.Text = fila["Nombre"].ToString();
                link.Click += new EventHandler(MostrardetalleEvento);
                listafl[(diaApp.Day) + (DiaInicio - 2)].Controls.Add(link);
                
            }

        }
        

        private void pasaje_Datos()
        {
            
        }
        #region botones
        private void btnHoy_Click(object sender, EventArgs e)
        {
            MostrarHoy();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            MesAnterior();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SiguienteMes();
        }

        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

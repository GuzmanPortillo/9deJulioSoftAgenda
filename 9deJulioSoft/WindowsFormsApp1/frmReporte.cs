using System;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmReporte : Form
    {
        CN_Agenda objEventos = new CN_Agenda();
        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmCargarAgenda_Load(object sender, EventArgs e)
        {
            
        }
        private void Mostrar_listaEventos()
        {
            string iniciofecha = dtpFecDesde.Value.ToString("yyyyMMdd");
            string finfecha = dtpFecHasta.Value.ToString("yyyyMMdd");

            dgvListaEventos.DataSource = objEventos.consultar_ListaEventos(iniciofecha, finfecha);
            dgvListaEventos.Refresh();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string iniciofecha = dtpFecDesde.Value.ToString("dd/MM/yyyy");
            string finfecha = dtpFecHasta.Value.ToString("dd/MM/yyyy");

            SaveFileDialog Guardar = new SaveFileDialog();
            Guardar.DefaultExt = "pdf";
            Guardar.Filter = "PDF (*.pdf)|*.pdf";
            Guardar.FileName = "Reporte" + DateTime.Now.ToString("ddMMyyyy") + ".pdf";

            string paginaHtmlTexto = CapaPresentacion.Properties.Resources.Plantilla.ToString();
        
            paginaHtmlTexto = paginaHtmlTexto.Replace("@FECHADESDE", iniciofecha);
            paginaHtmlTexto = paginaHtmlTexto.Replace("@FECHAHASTA", finfecha);

            
            string filas = string.Empty;
            var fecha = new DateTime();
            string fecnueva = fecha.ToString("dd/MM/yyyy");
            

            for (int i=0 ; i < dgvListaEventos.RowCount - 1;i++)
            {
                filas += "<tr>";
                filas += "<td>" + dgvListaEventos.Rows[i].Cells[0].Value.ToString() + "</td>";
                filas += "<td>" + DateTime.Parse(dgvListaEventos.Rows[i].Cells[1].Value.ToString()).ToString("dd/MM/yyyy") + "</td>";
                filas += "<td>" + dgvListaEventos.Rows[i].Cells[2].Value.ToString() + "</td>";
                filas += "<td>" + dgvListaEventos.Rows[i].Cells[3].Value.ToString() + "</td>";
                filas += "</tr>";

            }
            
            paginaHtmlTexto = paginaHtmlTexto.Replace("@FILAS", filas);

            if (Guardar.ShowDialog() == DialogResult.OK)
            {

                using (FileStream stream = new FileStream(Guardar.FileName, FileMode.Create))
                {
                    Document PDF = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(PDF, stream);
                    PDF.Open();

                    PDF.Add(new Phrase(""));
                    ////Agregamos la imagen del banner al documento
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(CapaPresentacion.Properties.Resources.LogoClub, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(PDF.LeftMargin, PDF.Top - 60);
                    PDF.Add(img);


                    using (StringReader sr = new StringReader(paginaHtmlTexto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, PDF, sr);
                    }

                    PDF.Close();
                    stream.Close();

                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Mostrar_listaEventos();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

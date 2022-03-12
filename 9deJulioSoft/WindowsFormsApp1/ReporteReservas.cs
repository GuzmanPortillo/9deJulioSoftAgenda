using System;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class ReporteReservas : Form
    {
        CN_Reservas reservas = new CN_Reservas();
        public ReporteReservas()
        {
            InitializeComponent();
        }

        private void Mostrar_listadoReservas()
        {
            string iniciofecha = dtpFecDesde.Value.ToString("dd-MM-yyyy");
            string finfecha = dtpFecHasta.Value.ToString("dd-MM-yyyy");

            dgvListaEventos.DataSource = reservas.ListaDeReservas(iniciofecha, finfecha);
            dgvListaEventos.Refresh();
        }
        private void ReporteReservas_Load(object sender, EventArgs e)
        {

        }

        private void dgvListaEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Mostrar_listadoReservas();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                string iniciofecha = dtpFecDesde.Value.ToString("dd-MM-yyyy");
                string finfecha = dtpFecHasta.Value.ToString("dd-MM-yyyy");

                SaveFileDialog Guardar = new SaveFileDialog();
                Guardar.FileName = "Reporte" + DateTime.Now.ToString("ddMMyyyy") + ".pdf";

                string paginaHtmlTexto = Properties.Resources.PlantillaReservas.ToString();

                paginaHtmlTexto = paginaHtmlTexto.Replace("@FECHADESDE", iniciofecha);
                paginaHtmlTexto = paginaHtmlTexto.Replace("@FECHAHASTA", finfecha);


                string filas = string.Empty;
                for (int i = 0; i < dgvListaEventos.RowCount - 1; i++)
                {
                    filas += "<tr>";
                    filas += "<td>" + dgvListaEventos.Rows[i].Cells[0].Value.ToString() + "</td>";
                    filas += "<td>" + dgvListaEventos.Rows[i].Cells[1].Value.ToString() + "</td>";
                    filas += "<td>" + dgvListaEventos.Rows[i].Cells[2].Value.ToString() + "</td>";
                    filas += "<td>" + dgvListaEventos.Rows[i].Cells[3].Value.ToString() + "</td>";
                    filas += "<td>" + dgvListaEventos.Rows[i].Cells[4].Value.ToString() + "</td>";
                    filas += "<td>" + dgvListaEventos.Rows[i].Cells[5].Value.ToString() + "</td>";
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
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.LogoClub, System.Drawing.Imaging.ImageFormat.Png);
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
                MessageBox.Show("La descarga fue realizada con éxito");
            }
            catch (Exception )
            {
                MessageBox.Show("Error al intentar descargar el Pdf");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

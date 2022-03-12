using System;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using CapaNegocio;
using System.util;


namespace CapaPresentacion
{
    public partial class Pagos : Form
    {
        private CN_Pagos objCNpagos = new CN_Pagos();

        public Pagos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pagos_Load(object sender, System.EventArgs e)
        {
            //DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            //dgvPagos.Columns.Add(chk);
            dgvPagos.Refresh();
        }

        private void btnPagar_Click(object sender, System.EventArgs e)
        {
            //int total = dgvPagos.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells[0].Value) == true).Count();
            //if (total > 0)
            //{
            try
                {
                    var resultado = MessageBox.Show("Desea realizar el pago", "Realizar Pago",
                                                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.OK)
                    {
                        Hacer_pasajeDatos();
                        objCNpagos.Actualizar_Cuota();
                    }

                    MessageBox.Show("Se realizo el pago");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ocurrió un error " + error.Message);
                }


        }
    

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            int nro_socio = Convert.ToInt32(txtIngresarSocio.Text);

            dgvPagos.DataSource = objCNpagos.consultar_cuota(nro_socio);
            // dgvListaEventos.Refresh();
        }

        private void Hacer_pasajeDatos()
        {
            objCNpagos.Idsociocuota = Convert.ToInt32(dgvPagos.Rows[dgvPagos.SelectedRows[0].Index].Cells["id_socio_cuota"].Value.ToString());


        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {


            SaveFileDialog Guardar = new SaveFileDialog();
            Guardar.DefaultExt = "pdf";
            Guardar.Filter = "PDF (*.pdf)|*.pdf";
            Guardar.FileName = "Reporte" + DateTime.Now.ToString("ddMMyyyy") + ".pdf";

            string paginaHtmlTexto = CapaPresentacion.Properties.Resources.PlantillaPagos.ToString();

            paginaHtmlTexto = paginaHtmlTexto.Replace("@Nrosocio", txtIngresarSocio.Text);



            string filas = string.Empty;
            //var fecha = new DateTime();
            //string fecnueva = fecha.ToString("dd/MM/yyyy");


            for (int i = 0; i < dgvPagos.RowCount - 1; i++)
            {
                filas += "<tr>";
                filas += "<td>" + dgvPagos.Rows[i].Cells[1].Value.ToString() + "</td>";
                filas += "<td>" + dgvPagos.Rows[i].Cells[2].Value.ToString() + "</td>";
                filas += "<td>" + dgvPagos.Rows[i].Cells[3].Value.ToString() + "</td>";
                filas += "<td>" + dgvPagos.Rows[i].Cells[4].Value.ToString() + "</td>";
                filas += "<td>" + dgvPagos.Rows[i].Cells[5].Value.ToString() + "</td>";
                filas += "<td>" + dgvPagos.Rows[i].Cells[6].Value.ToString() + "</td>";
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
        }
    }
        
}

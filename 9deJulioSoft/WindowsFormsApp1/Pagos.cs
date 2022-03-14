using System;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using CapaNegocio;
using System.util;
using System.Linq;
using System.Collections.Generic;

namespace CapaPresentacion
{
    public partial class Pagos : Form
    {
        private CN_Pagos objCNpagos = new CN_Pagos();
        const int COLUMNA_ESTADO = 5;
        private int nro_socio = 0;

        public Pagos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pagos_Load(object sender, System.EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, System.EventArgs e)
        {
            List<DataGridViewRow> seleccionados = dgvPagos.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells[0].Value) == true).ToList();

            if (seleccionados.Any())
            {
                try
                {
                    var resultado = MessageBox.Show("Desea realizar el pago", "Realizar Pago",
                                                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.OK)
                    {
                        foreach (DataGridViewRow seleccionado in seleccionados)
                        {
                            Hacer_pasajeDatos(seleccionado);
                            objCNpagos.Actualizar_Cuota();
                        }
                        MessageBox.Show("Se realizo el pago");
                        Buscar(nro_socio);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ocurrió un error " + error.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione los registros a pagar", "Realizar Pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            //int nro_socio = Convert.ToInt32(txtIngresarSocio.Text);

            if (!int.TryParse(txtIngresarSocio.Text, out nro_socio))
            {
                MessageBox.Show("Ingrese un nro. de socio valido", "Pagos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Buscar(nro_socio);
        }

        private void Buscar(int idSocio)
        {
            dgvPagos.DataSource = null;
            dgvPagos.Columns.Clear();
            dgvPagos.Refresh();

            dgvPagos.DataSource = objCNpagos.consultar_cuota(idSocio);
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dgvPagos.Columns.Insert(0, chk);

            for (int i = 1, j = dgvPagos.Columns.Count; i < j; i++)
                dgvPagos.Columns[i].ReadOnly = true;

            for (int i = 0, j = dgvPagos.Rows.Count; i < j; i++)
                dgvPagos[0, i].ReadOnly = (dgvPagos.Rows[i].Cells["estado"].Value.ToString() == "Pagado");

            dgvPagos.Refresh();
        }

        private void Hacer_pasajeDatos(DataGridViewRow row)
        {
            objCNpagos.Idsociocuota = Convert.ToInt32(row.Cells["id_socio_cuota"].Value.ToString());
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

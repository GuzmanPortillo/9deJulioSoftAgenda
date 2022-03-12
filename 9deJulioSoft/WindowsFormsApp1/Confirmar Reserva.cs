using System;
using CapaNegocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CapaPresentacion
{
    public partial class Confirmar_Reserva : Form
    {
     
        public Confirmar_Reserva()
        {
            InitializeComponent();
            
        }
       /* private static SqlConnection conexionBd()
        {
            SqlConnection conexion = new SqlConnection("SERVER=localhost\\SQLEXPRESS; DATABASE=NuevedeJulio;INTEGRATED SECURITY=true");
            conexion.Open();
            return conexion;
            
        }*/
       
       
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Confirmar_Reserva_Load(object sender, EventArgs e)
        {
          

            /*
                    SqlConnection conexion = conexionBd();

            int Dni = int.Parse(textBox03.Text);
            string cadena = "select * from Socios where Nº_Doc =" + Dni;
            SqlCommand sqlCommand = new SqlCommand(cadena, conexion);
            SqlDataReader registro = sqlCommand.ExecuteReader();*/
            CN_Reservas reservas = new CN_Reservas();
            //int dni = 0;
            var leer = reservas.Leer(textBox03.Text);

            textBox01.Text = leer.Item1;
            textBox02.Text = leer.Item2;
             // textBox01.Text = registro["Nombre"].ToString();
             //textBox02.Text = registro ["Apellido"].ToString();

            dataGridView1.Columns.Add("textBox01", "Nombre");
             dataGridView1.Columns.Add("textBox02", "Apellido");
             dataGridView1.Columns.Add("textBox03", "D.N.I");
             dataGridView1.Columns.Add("textBox04", "Deporte");
             dataGridView1.Columns.Add("dateTimePicker1", "Fecha"); 
             dataGridView1.Columns.Add("comboBox1", "Horario");
            
            //conexion.Close();
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox03.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CN_Reservas reservas = new CN_Reservas();

            if (!string.IsNullOrWhiteSpace(textBox01.Text))
            {
                if (!string.IsNullOrWhiteSpace(textBox02.Text)) {

                    if (!string.IsNullOrWhiteSpace(textBox03.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(textBox04.Text))
                        {
                            if (!string.IsNullOrWhiteSpace(dateTimePicker1.Text))
                            {
                                if (!string.IsNullOrWhiteSpace(comboBox1.Text))
                                {
                                    var reservaModel = new ModeloReserva(
                                    Nombre: textBox01.Text,
                                    Apellido: textBox02.Text,
                                    Dni: textBox03.Text,
                                    Deporte: textBox04.Text,
                                    Fecha: dateTimePicker1.Value.ToString("dd-MM-yyyy"),
                                    Horario: comboBox1.Text
                                    );
                                    var result = reservaModel.CrearReserva();
                                    MessageBox.Show(result);
                                }
                                else
                                    MessageBox.Show("Porfavor, verifique que ningun campo quede vacio");
                            }
                            else
                                MessageBox.Show("Ingrese el Apellido");
                        }
                        else
                            MessageBox.Show("Ingrese el Dni");
                    }
                    else
                        MessageBox.Show("Ingrese el Deporte");
                }
                else
                    MessageBox.Show("Ingrese la Fecha");

            }
            else
                MessageBox.Show("Ingrese el Horario");

            dataGridView1.Rows.Clear();
            /*
            SqlConnection conexion = conexionBd();
           string agregar = "INSERT INTO Reservas (Nombre, Apellido, Dni, Deporte, Fecha, Horario) VALUES (@Nombre, @Apellido, @DNI, @Deporte, @Fecha, @Horario)";
           SqlCommand sqlCommand = new SqlCommand(agregar, conexion);


           try
           {
               sqlCommand.Parameters.Clear();

               sqlCommand.Parameters.AddWithValue("@Nombre",textBox01.Text);
               sqlCommand.Parameters.AddWithValue("@Apellido",textBox02.Text);
               sqlCommand.Parameters.AddWithValue("@DNI", textBox03.Text);
               sqlCommand.Parameters.AddWithValue("@Deporte", textBox04.Text);
               sqlCommand.Parameters.AddWithValue("@Fecha",dateTimePicker1.Text);
               sqlCommand.Parameters.AddWithValue("@Horario", comboBox1.Text);

               sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Datos agregados");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falló el ingreso de datos");
            }
               conexion.Close(); 
                     */
        }

        private void textBox01_TextChanged(object sender, EventArgs e)
        {
            textBox01.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox01.Text) && !string.IsNullOrWhiteSpace(textBox02.Text) && !string.IsNullOrWhiteSpace(textBox03.Text) && !string.IsNullOrWhiteSpace(textBox04.Text) && !string.IsNullOrWhiteSpace(dateTimePicker1.Text) && !string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                dataGridView1.Rows.Add(textBox01.Text, textBox02.Text, textBox03.Text, textBox04.Text, dateTimePicker1.Text, comboBox1.Text);
                    if (dataGridView1.Rows != null)
                    {
                        button2.Enabled = false;
                    }
            }
            else {
                MessageBox.Show("Porfavor, verifique que ningun campo este vacio");
            }
            
    }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            button2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox04_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox02_TextChanged(object sender, EventArgs e)
        {
            textBox02.Enabled = false;
        }
    }
}

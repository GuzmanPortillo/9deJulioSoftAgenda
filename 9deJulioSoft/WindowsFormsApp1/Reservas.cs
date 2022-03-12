using System.Windows.Forms;
using CapaNegocio;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;


namespace CapaPresentacion
{
    public partial class Reservas : Form
    {
        
        public Reservas()
        {
            InitializeComponent();
        }
        
       /* private static SqlConnection conexionBd()
        {
            SqlConnection conexion = new SqlConnection("SERVER=localhost\\SQLEXPRESS; DATABASE=NuevedeJulio;INTEGRATED SECURITY=true");
            conexion.Open();
            return conexion;
        }*/
        private void botonvalidar_Click(object sender, System.EventArgs e)
        {
            /*
            SqlConnection conexion = conexionBd();

            
            if (textBox1.Text != "" )
            {
                int Dni = int.Parse(textBox1.Text);
                string cadena = "select * from Socios where Nº_Doc =" + Dni;
            SqlCommand sqlCommand = new SqlCommand(cadena, conexion);
            SqlDataReader registro = sqlCommand.ExecuteReader();
            
                if (registro.Read())
                {
                    botonvalidar.Enabled = false;
                    MessageBox.Show("Dni validado con éxito: ");
                  
                }
                else
                {
                    MessageBox.Show("Dni no existente en la base de datos");
                }
            }
            else {
                MessageBox.Show("El campo D.N.I es requerido");
            }
            conexion.Close();
          */
            if (textBox1.Text != "") {
                CN_Reservas reservas = new CN_Reservas();
                var docVal = reservas.ValDni(textBox1.Text);
                if (docVal == true)
                {
                    botonvalidar.Enabled = false;
                    MessageBox.Show("Dni validado con éxito: ");

                }
                else
                {
                    MessageBox.Show("Dni no existente en la base de datos");
                }
            }
            else
            {
                MessageBox.Show("El campo D.N.I es requerido");

            }
        }


        private void botonconfirmar_Click(object sender, System.EventArgs e)
        {
            //SqlConnection conexion = conexionBd();
            
            if (botonvalidar.Enabled == false) //cancela el boton validar 
            {
                if (radioButton1.Checked == true)//chequea si el boton esta seleccionado
                {
                    CN_Reservas reservas = new CN_Reservas();
                    var checkFut = reservas.CheckF();
                if (checkFut == true)
                {
                    //string cadena2 = "select * from Deporte where Id_Deporte = 1";
                    //SqlCommand sqlCommand1 = new SqlCommand(cadena2, conexion);
                    //SqlDataReader registro2 = sqlCommand1.ExecuteReader();  
                    
                    Confirmar_Reserva confirmar_form = new Confirmar_Reserva();
                    confirmar_form.textBox03.Text = textBox1.Text;
                    confirmar_form.textBox04.Text = radioButton1.Text;
                    confirmar_form.Show();
                }
                }
                else if (radioButton2.Checked == true)
                {
                    CN_Reservas reservas = new CN_Reservas();
                    var checkBas = reservas.CheckB();
                if (checkBas == true)
                {
                    //string cadena3 = "select * from Deporte where Id_Deporte = 2";
                    //SqlCommand sqlCommand2 = new SqlCommand(cadena3, conexion);
                    //SqlDataReader registro3 = sqlCommand2.ExecuteReader();
                    
                    Confirmar_Reserva confirmar_form = new Confirmar_Reserva();
                    confirmar_form.textBox03.Text = textBox1.Text;
                    confirmar_form.textBox04.Text = radioButton2.Text;
                  
                    confirmar_form.Show();
                }
                }

                if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    MessageBox.Show("Debe elegir entre FUTBOL o BASQUET y seleccionar uno");
                }
            }
            else {
                MessageBox.Show("Es requerida la validacion del D.N.I");
            }


               // conexion.Close();
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {


        }

        private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void Reservas_Load(object sender, System.EventArgs e)
        {
        
        }

        private void button1_Click_1(object sender, System.EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, System.EventArgs e)
        {

        }
    }
}
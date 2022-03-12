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
using System;

namespace CapaPresentacion
{
    public partial class Stock : Form
    {

        public Stock()
        {
            InitializeComponent();
        }
         private void stockLoad() 
        {
                    StockNegocio stock = new StockNegocio();
                    var dt = stock.ListarStock();
                    dataGridView1.DataSource = dt;
                    Console.WriteLine(dt);
         }
     
        private void Stock_Load(object sender, EventArgs e)
        { 
            stockLoad();    
        }

        private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            StockNegocio stock = new StockNegocio();
            var existe = stock.Existente(textBox1.Text);
            
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (!string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    try
                    {
                        var modeloStock = new ModeloStock(
                            Producto: textBox1.Text,
                            Cantidad: Convert.ToInt32(textBox2.Text),
                            Total: Convert.ToInt32(textBox2.Text)
                            );
                        if (existe == false)
                        {
                            var result = modeloStock.CrearStock();
                            MessageBox.Show(result);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo realizar la operación, ¡verifique si el producto ingresado ya existe!");
                        }
                    }
                    catch {
                        MessageBox.Show("Porfavor, revise que el campo sea válido");
                    }
                }
                 else
                     MessageBox.Show("Porfavor, verifique que ningun campo quede vacio");
                }
             else
                 MessageBox.Show("Ingrese la CANTIDAD");
                textBox1.Clear();   
                textBox2.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBox7.Text))
            {
                try
                {
                    var modeloStock = new ModeloStockId(
                            IdCodigo: Convert.ToInt32(textBox7.Text)
                            );

                    var result = modeloStock.EliminarStock();
                    MessageBox.Show(result);
                    
                }
                catch {
                    MessageBox.Show("Porfavor, revise que el campo sea válido");
                } 
            }
            else
                MessageBox.Show("Porfavor, revise que el campo no este vacio");
            textBox7.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StockNegocio stock = new StockNegocio();
            if (!string.IsNullOrWhiteSpace(textBox3.Text) && !string.IsNullOrWhiteSpace(comboBox1.Text) && !string.IsNullOrWhiteSpace(textBox4.Text))
            {
                try
                {
                    var existe = stock.ExisteId(Convert.ToInt32(textBox3.Text));
                    if (existe)
                    {
                        var ver = stock.Modificar(Convert.ToInt32(textBox3.Text));
                        var leerTotal = Convert.ToInt32(ver.Item1);
                        Console.WriteLine(leerTotal);
                        Console.WriteLine(ver);

                        if (comboBox1.Text == "Agregar")
                        {

                            var cant = Convert.ToInt32(textBox4.Text);
                            var total = cant + leerTotal;
                            Console.WriteLine(total);

                            var modeloStock = new ModeloStockMod(
                                IdCodigo: Convert.ToInt32(textBox3.Text),
                                Cantidad: cant,
                                Total: total
                                );

                            var result = modeloStock.ModificacionStock();
                            MessageBox.Show(result);
                            /*Agregar();
                            UpdateEventHandler += AgUpdate;*/
                        }
                        if (comboBox1.Text == "Descontar")
                        {
                            var cant = Convert.ToInt32(textBox4.Text);

                            if (leerTotal >= cant)
                            {
                                var total = leerTotal - cant;
                                Console.WriteLine(total);
                                var modeloStock = new ModeloStockMod(
                               IdCodigo: Convert.ToInt32(textBox3.Text),
                               Cantidad: cant,
                               Total: total
                               );

                                var result = modeloStock.ModificacionStock();
                                MessageBox.Show(result);
                                /*Agregar();
                                UpdateEventHandler += AgUpdate;*/
                            }
                            if (leerTotal < cant)
                            {
                                MessageBox.Show("Verifique que la cantidad a descontar no sea mayor que el total de productos");
                            }
                            else
                            {
                                MessageBox.Show("Ocurrió un error al intentar descontar el stock");
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("El código de producto ingresado no existe");
                    }
                }
                catch {
                    MessageBox.Show("Verifique que los campos ingresados sean correctos");
                }

            }
            else 
            {
                MessageBox.Show("Verifique que ningun campo este vacio, porfavor");
            }
            textBox3.Clear();
            textBox4.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StockNegocio stock = new StockNegocio();
            var dt = stock.ListadoStock(textBox5.Text);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            stockLoad();
            textBox5.Clear();

        }
    }
}


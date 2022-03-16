using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class BackupAndRestoreDB : Form
    {
        private CN_BackupRestore objbkp = new CN_BackupRestore();
        public BackupAndRestoreDB()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDirectorio_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Filter = "SQL SERVER database backup files (*.bak)|.bak";
            saveFileDialog1.ShowDialog();
            txtbkp.Text = saveFileDialog1.FileName;
        }

        private void btnbkpDB_Click(object sender, EventArgs e)
        {
            objbkp.dbGeneral("backup database NueveDeJulio to disk='" + txtbkp.Text + "'");
            MessageBox.Show("El backup se realizó correctamente.");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnDirectorioRest_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Restore Files (*.bak)|*.bak";
            openFileDialog1.ShowDialog();
            txtRestore.Text = openFileDialog1.FileName;
        }

        private void btnRestoreDB_Click(object sender, EventArgs e)
        {
            objbkp.dbGeneral("use master restore database NueveDeJulio from disk= '" + txtRestore.Text + "'");
            MessageBox.Show("La restauración se realizó correctamente.");
        }
    }
}
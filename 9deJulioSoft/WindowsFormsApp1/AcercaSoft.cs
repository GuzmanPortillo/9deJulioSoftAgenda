using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class AcercaSoft : Form
    {
        public AcercaSoft()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

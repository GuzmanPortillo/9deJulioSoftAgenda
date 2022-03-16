using System;
using System.Linq;
using System.Windows.Forms;
using CapaSoporte.Cache;
using System.Drawing;

namespace CapaPresentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que quiere salir?", "Warning",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; //Cancela el cerrado del formulario
            }
        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            
            Form formulario ;
            formulario = PanelFormularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();

                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.FixedDialog;
                //formulario.Dock = DockStyle.Fill;
                PanelFormularios.Controls.Add(formulario);
                PanelFormularios.Tag = formulario;
                formulario.ControlBox = false;
                formulario.Top = (PanelFormularios.Height / 2) - (formulario.Height / 2);
                formulario.Left = (PanelFormularios.Width / 2) - (formulario.Width / 2);
                formulario.Show();
                formulario.BringToFront();

            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        private void acercaDe9deJulioSoftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaSoft AcercaSoft = new AcercaSoft();
            AcercaSoft.Show();
        }
        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Stock>();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Pagos>();
        }

        private void agendaDeportivaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AgendaDeportiva>();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Reservas>();
        }

        private void altaSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AltaSocios>();
        }

        private void admSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Socios>();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<SociosInformes>();
        }

        private void altaEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AltaEmpleados>();
        }

        private void admDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Empleados>();
        }

        private void cargarAgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<CargarEventos>();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmReporte>();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            if (!InicioSesion.cargos.Contains(Cargos.administrador))
            {
                if (InicioSesion.cargos.Contains(Cargos.recepcionista))
                {
                    agendaDeportivaToolStripMenuItem1.Enabled = false;
                    reporteToolStripMenuItem.Enabled = false;
                }

                if (InicioSesion.cargos.Contains(Cargos.contador))
                {
                    usuariosToolStripMenuItem.Enabled = false;
                    usuariosToolStripMenuItem.Visible = false;
                }

            }
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AltaUsuarios>();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ModificarUsuarios>();
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<PermisoUsuario>();
        }

        private void nuevaReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Reservas>();
        }

        private void reporteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ReporteReservas>();
        }

        private void abrirFormularioFrmBitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmBitacora>();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<BackupAndRestoreDB>();
        }
    }
}

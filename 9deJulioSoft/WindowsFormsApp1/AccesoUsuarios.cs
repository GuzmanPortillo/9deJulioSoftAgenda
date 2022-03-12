using CapaNegocio;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class AccesoUsuarios : Form
    {
        public AccesoUsuarios()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void AccesoUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que quiere salir?", "Warning",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; //Cancela el cerrado del formulario
            }
        }
        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            {
                if (txtuser.Text != "")
                {
                    if (txtpass.Text != "")
                    {
                        ModeloUsuario usuario = new ModeloUsuario();
                        var validlogin = usuario.LoginUser(txtuser.Text, txtpass.Text);
                        if (validlogin == true)
                        {
                            FormPrincipal mainmenu = new FormPrincipal();
                            mainmenu.Show();
                            mainmenu.FormClosed += Logout;
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o Contraseña invalido! \n Por Favor vuelva a intentarlo");
                            txtpass.Text = "";
                            txtuser.Focus();
                        }
                    }
                    else MessageBox.Show("Por favor ingrese la Contraseña");
                }
                else MessageBox.Show("Por favor ingrese el Usuario");
            }

        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpass.Text = "";
            txtpass.UseSystemPasswordChar = false;
            txtuser.Text = "";
            this.Show();
            //txtuser.Focus();
        }

        private void AccesoUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AccesoUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}


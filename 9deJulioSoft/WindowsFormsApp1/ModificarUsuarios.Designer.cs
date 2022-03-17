
namespace CapaPresentacion
{
    partial class ModificarUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarUsuarios));
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnAccion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.picPerfil = new System.Windows.Forms.PictureBox();
            this.rbtActivo = new System.Windows.Forms.RadioButton();
            this.rbtInactivo = new System.Windows.Forms.RadioButton();
            this.BtnOtroUsuario = new System.Windows.Forms.Button();
            this.txtBucarUsuario = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMostrarPass = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtContraseñaNueva = new System.Windows.Forms.TextBox();
            this.lblContraseñaActual = new System.Windows.Forms.Label();
            this.lblConfirmarPass = new System.Windows.Forms.Label();
            this.txtConfirmarPass = new System.Windows.Forms.TextBox();
            this.btnEditarFoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(316, 63);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(138, 20);
            this.txtNombres.TabIndex = 0;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(316, 93);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(138, 20);
            this.txtApellidos.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(316, 121);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(138, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(263, 65);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(52, 13);
            this.lblNombres.TabIndex = 4;
            this.lblNombres.Text = "Nombres ";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(266, 95);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 5;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(272, 124);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(212, 159);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(103, 13);
            this.lblContraseña.TabIndex = 7;
            this.lblContraseña.Text = "Antigua Contraseña:";
            // 
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(266, 294);
            this.btnAccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(108, 21);
            this.btnAccion.TabIndex = 9;
            this.btnAccion.Text = "Modificar Usuario";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(390, 294);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 21);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.White;
            this.txtContraseña.Location = new System.Drawing.Point(316, 157);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.ReadOnly = true;
            this.txtContraseña.Size = new System.Drawing.Size(107, 20);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.TabStop = false;
            // 
            // picPerfil
            // 
            this.picPerfil.Image = ((System.Drawing.Image)(resources.GetObject("picPerfil.Image")));
            this.picPerfil.Location = new System.Drawing.Point(12, 62);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(136, 120);
            this.picPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPerfil.TabIndex = 14;
            this.picPerfil.TabStop = false;
            // 
            // rbtActivo
            // 
            this.rbtActivo.AutoSize = true;
            this.rbtActivo.Enabled = false;
            this.rbtActivo.Location = new System.Drawing.Point(16, 225);
            this.rbtActivo.Name = "rbtActivo";
            this.rbtActivo.Size = new System.Drawing.Size(55, 17);
            this.rbtActivo.TabIndex = 22;
            this.rbtActivo.Text = "Activo";
            this.rbtActivo.UseVisualStyleBackColor = true;
            // 
            // rbtInactivo
            // 
            this.rbtInactivo.AutoSize = true;
            this.rbtInactivo.Enabled = false;
            this.rbtInactivo.Location = new System.Drawing.Point(88, 225);
            this.rbtInactivo.Name = "rbtInactivo";
            this.rbtInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbtInactivo.TabIndex = 23;
            this.rbtInactivo.Text = "Inactivo";
            this.rbtInactivo.UseVisualStyleBackColor = true;
            // 
            // BtnOtroUsuario
            // 
            this.BtnOtroUsuario.Location = new System.Drawing.Point(10, 294);
            this.BtnOtroUsuario.Name = "BtnOtroUsuario";
            this.BtnOtroUsuario.Size = new System.Drawing.Size(109, 21);
            this.BtnOtroUsuario.TabIndex = 10;
            this.BtnOtroUsuario.Text = "Editar otro usuario";
            this.BtnOtroUsuario.UseVisualStyleBackColor = true;
            this.BtnOtroUsuario.Click += new System.EventHandler(this.BtnOtroUsuario_Click);
            // 
            // txtBucarUsuario
            // 
            this.txtBucarUsuario.Location = new System.Drawing.Point(12, 11);
            this.txtBucarUsuario.Name = "txtBucarUsuario";
            this.txtBucarUsuario.Size = new System.Drawing.Size(135, 20);
            this.txtBucarUsuario.TabIndex = 25;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(153, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 21);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnMostrarPass
            // 
            this.btnMostrarPass.Font = new System.Drawing.Font("Webdings", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMostrarPass.Location = new System.Drawing.Point(428, 150);
            this.btnMostrarPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrarPass.Name = "btnMostrarPass";
            this.btnMostrarPass.Size = new System.Drawing.Size(38, 32);
            this.btnMostrarPass.TabIndex = 5;
            this.btnMostrarPass.TabStop = false;
            this.btnMostrarPass.Text = "N";
            this.btnMostrarPass.UseVisualStyleBackColor = true;
            this.btnMostrarPass.Click += new System.EventHandler(this.btnMostrarPass_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtContraseñaNueva);
            this.groupBox1.Controls.Add(this.lblContraseñaActual);
            this.groupBox1.Controls.Add(this.lblConfirmarPass);
            this.groupBox1.Controls.Add(this.txtConfirmarPass);
            this.groupBox1.Location = new System.Drawing.Point(214, 188);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(238, 81);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambiar contraseña";
            // 
            // txtContraseñaNueva
            // 
            this.txtContraseñaNueva.Location = new System.Drawing.Point(116, 21);
            this.txtContraseñaNueva.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContraseñaNueva.Name = "txtContraseñaNueva";
            this.txtContraseñaNueva.Size = new System.Drawing.Size(112, 20);
            this.txtContraseñaNueva.TabIndex = 6;
            // 
            // lblContraseñaActual
            // 
            this.lblContraseñaActual.AutoSize = true;
            this.lblContraseñaActual.Location = new System.Drawing.Point(20, 24);
            this.lblContraseñaActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraseñaActual.Name = "lblContraseñaActual";
            this.lblContraseñaActual.Size = new System.Drawing.Size(96, 13);
            this.lblContraseñaActual.TabIndex = 24;
            this.lblContraseñaActual.Text = "Nueva Contraseña";
            // 
            // lblConfirmarPass
            // 
            this.lblConfirmarPass.AutoSize = true;
            this.lblConfirmarPass.Location = new System.Drawing.Point(4, 48);
            this.lblConfirmarPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmarPass.Name = "lblConfirmarPass";
            this.lblConfirmarPass.Size = new System.Drawing.Size(108, 13);
            this.lblConfirmarPass.TabIndex = 23;
            this.lblConfirmarPass.Text = "Confirmar Contraseña";
            // 
            // txtConfirmarPass
            // 
            this.txtConfirmarPass.Location = new System.Drawing.Point(116, 46);
            this.txtConfirmarPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConfirmarPass.Name = "txtConfirmarPass";
            this.txtConfirmarPass.Size = new System.Drawing.Size(112, 20);
            this.txtConfirmarPass.TabIndex = 7;
            // 
            // btnEditarFoto
            // 
            this.btnEditarFoto.Enabled = false;
            this.btnEditarFoto.Location = new System.Drawing.Point(10, 188);
            this.btnEditarFoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarFoto.Name = "btnEditarFoto";
            this.btnEditarFoto.Size = new System.Drawing.Size(136, 19);
            this.btnEditarFoto.TabIndex = 29;
            this.btnEditarFoto.TabStop = false;
            this.btnEditarFoto.Text = "Editar Foto";
            this.btnEditarFoto.UseVisualStyleBackColor = true;
            this.btnEditarFoto.Click += new System.EventHandler(this.btnEditarFoto_Click);
            // 
            // ModificarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 326);
            this.Controls.Add(this.btnEditarFoto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMostrarPass);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBucarUsuario);
            this.Controls.Add(this.BtnOtroUsuario);
            this.Controls.Add(this.rbtInactivo);
            this.Controls.Add(this.rbtActivo);
            this.Controls.Add(this.picPerfil);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModificarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMUsuarios";
            this.Load += new System.EventHandler(this.ModificarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.PictureBox picPerfil;
        private System.Windows.Forms.RadioButton rbtActivo;
        private System.Windows.Forms.RadioButton rbtInactivo;
        private System.Windows.Forms.Button BtnOtroUsuario;
        private System.Windows.Forms.TextBox txtBucarUsuario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMostrarPass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtContraseñaNueva;
        private System.Windows.Forms.Label lblContraseñaActual;
        private System.Windows.Forms.Label lblConfirmarPass;
        private System.Windows.Forms.TextBox txtConfirmarPass;
        private System.Windows.Forms.Button btnEditarFoto;
    }
}
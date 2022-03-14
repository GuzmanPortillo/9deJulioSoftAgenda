
namespace CapaPresentacion
{
    partial class PermisoUsuario
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.cboRoles = new System.Windows.Forms.ComboBox();
            this.grbAlta = new System.Windows.Forms.GroupBox();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.grbContieneBotones = new System.Windows.Forms.GroupBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvPermisoUsuario = new System.Windows.Forms.DataGridView();
            this.grbContieneGrilla = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscarUsuario = new System.Windows.Forms.Label();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbContienSalir = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtModificacion = new System.Windows.Forms.RadioButton();
            this.rbtAlta = new System.Windows.Forms.RadioButton();
            this.grbAlta.SuspendLayout();
            this.grbContieneBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisoUsuario)).BeginInit();
            this.grbContieneGrilla.SuspendLayout();
            this.grbContienSalir.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 19);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(183, 20);
            this.lblRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(23, 13);
            this.lblRol.TabIndex = 1;
            this.lblRol.Text = "Rol";
            // 
            // cboRoles
            // 
            this.cboRoles.FormattingEnabled = true;
            this.cboRoles.Location = new System.Drawing.Point(186, 35);
            this.cboRoles.Margin = new System.Windows.Forms.Padding(2);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(171, 21);
            this.cboRoles.TabIndex = 10;
            // 
            // grbAlta
            // 
            this.grbAlta.Controls.Add(this.cboUsuarios);
            this.grbAlta.Controls.Add(this.lblUsuario);
            this.grbAlta.Controls.Add(this.grbContieneBotones);
            this.grbAlta.Controls.Add(this.cboRoles);
            this.grbAlta.Controls.Add(this.lblRol);
            this.grbAlta.Location = new System.Drawing.Point(17, 45);
            this.grbAlta.Margin = new System.Windows.Forms.Padding(2);
            this.grbAlta.Name = "grbAlta";
            this.grbAlta.Padding = new System.Windows.Forms.Padding(2);
            this.grbAlta.Size = new System.Drawing.Size(368, 120);
            this.grbAlta.TabIndex = 11;
            this.grbAlta.TabStop = false;
            this.grbAlta.Text = "Alta";
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(11, 35);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(159, 21);
            this.cboUsuarios.TabIndex = 16;
            // 
            // grbContieneBotones
            // 
            this.grbContieneBotones.Controls.Add(this.btnGuardarCambios);
            this.grbContieneBotones.Controls.Add(this.btnGuardar);
            this.grbContieneBotones.Location = new System.Drawing.Point(7, 64);
            this.grbContieneBotones.Margin = new System.Windows.Forms.Padding(2);
            this.grbContieneBotones.Name = "grbContieneBotones";
            this.grbContieneBotones.Padding = new System.Windows.Forms.Padding(2);
            this.grbContieneBotones.Size = new System.Drawing.Size(350, 44);
            this.grbContieneBotones.TabIndex = 15;
            this.grbContieneBotones.TabStop = false;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(237, 16);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(109, 19);
            this.btnGuardarCambios.TabIndex = 17;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(263, 16);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 19);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvPermisoUsuario
            // 
            this.dgvPermisoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisoUsuario.Location = new System.Drawing.Point(4, 52);
            this.dgvPermisoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPermisoUsuario.Name = "dgvPermisoUsuario";
            this.dgvPermisoUsuario.RowTemplate.Height = 28;
            this.dgvPermisoUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPermisoUsuario.Size = new System.Drawing.Size(451, 119);
            this.dgvPermisoUsuario.TabIndex = 14;
            this.dgvPermisoUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermisoUsuario_CellClick);
            this.dgvPermisoUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // grbContieneGrilla
            // 
            this.grbContieneGrilla.Controls.Add(this.btnBuscar);
            this.grbContieneGrilla.Controls.Add(this.lblBuscarUsuario);
            this.grbContieneGrilla.Controls.Add(this.txtBuscarUsuario);
            this.grbContieneGrilla.Controls.Add(this.dgvPermisoUsuario);
            this.grbContieneGrilla.Location = new System.Drawing.Point(17, 169);
            this.grbContieneGrilla.Margin = new System.Windows.Forms.Padding(2);
            this.grbContieneGrilla.Name = "grbContieneGrilla";
            this.grbContieneGrilla.Padding = new System.Windows.Forms.Padding(2);
            this.grbContieneGrilla.Size = new System.Drawing.Size(459, 175);
            this.grbContieneGrilla.TabIndex = 16;
            this.grbContieneGrilla.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(381, 27);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(74, 22);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscarUsuario
            // 
            this.lblBuscarUsuario.AutoSize = true;
            this.lblBuscarUsuario.Location = new System.Drawing.Point(3, 14);
            this.lblBuscarUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarUsuario.Name = "lblBuscarUsuario";
            this.lblBuscarUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblBuscarUsuario.TabIndex = 16;
            this.lblBuscarUsuario.Text = "Usuario";
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(4, 29);
            this.txtBuscarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(129, 20);
            this.txtBuscarUsuario.TabIndex = 16;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(376, 11);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 21);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // grbContienSalir
            // 
            this.grbContienSalir.Controls.Add(this.btnSalir);
            this.grbContienSalir.Location = new System.Drawing.Point(18, 344);
            this.grbContienSalir.Margin = new System.Windows.Forms.Padding(2);
            this.grbContienSalir.Name = "grbContienSalir";
            this.grbContienSalir.Padding = new System.Windows.Forms.Padding(2);
            this.grbContienSalir.Size = new System.Drawing.Size(454, 36);
            this.grbContienSalir.TabIndex = 19;
            this.grbContienSalir.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtModificacion);
            this.groupBox1.Controls.Add(this.rbtAlta);
            this.groupBox1.Location = new System.Drawing.Point(18, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(367, 36);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // rbtModificacion
            // 
            this.rbtModificacion.AutoSize = true;
            this.rbtModificacion.Location = new System.Drawing.Point(105, 14);
            this.rbtModificacion.Name = "rbtModificacion";
            this.rbtModificacion.Size = new System.Drawing.Size(85, 17);
            this.rbtModificacion.TabIndex = 1;
            this.rbtModificacion.TabStop = true;
            this.rbtModificacion.Text = "Modificación";
            this.rbtModificacion.UseVisualStyleBackColor = true;
            this.rbtModificacion.CheckedChanged += new System.EventHandler(this.rbtModificacion_CheckedChanged);
            // 
            // rbtAlta
            // 
            this.rbtAlta.AutoSize = true;
            this.rbtAlta.Location = new System.Drawing.Point(14, 14);
            this.rbtAlta.Name = "rbtAlta";
            this.rbtAlta.Size = new System.Drawing.Size(43, 17);
            this.rbtAlta.TabIndex = 0;
            this.rbtAlta.TabStop = true;
            this.rbtAlta.Text = "Alta";
            this.rbtAlta.UseVisualStyleBackColor = true;
            this.rbtAlta.CheckedChanged += new System.EventHandler(this.rbtAlta_CheckedChanged);
            // 
            // PermisoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 390);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbContienSalir);
            this.Controls.Add(this.grbContieneGrilla);
            this.Controls.Add(this.grbAlta);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PermisoUsuario";
            this.Text = "PermisoUsuario";
            this.Load += new System.EventHandler(this.PermisoUsuario_Load);
            this.grbAlta.ResumeLayout(false);
            this.grbAlta.PerformLayout();
            this.grbContieneBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisoUsuario)).EndInit();
            this.grbContieneGrilla.ResumeLayout(false);
            this.grbContieneGrilla.PerformLayout();
            this.grbContienSalir.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cboRoles;
        private System.Windows.Forms.GroupBox grbAlta;
        private System.Windows.Forms.GroupBox grbContieneBotones;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvPermisoUsuario;
        private System.Windows.Forms.GroupBox grbContieneGrilla;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscarUsuario;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grbContienSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtModificacion;
        private System.Windows.Forms.RadioButton rbtAlta;
        private System.Windows.Forms.ComboBox cboUsuarios;
    }
}
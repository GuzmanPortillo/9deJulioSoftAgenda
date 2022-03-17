
namespace CapaPresentacion
{
    partial class CargarEventos
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
            this.dtpTiempo = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEvento = new System.Windows.Forms.Label();
            this.lblEstablecimiento = new System.Windows.Forms.Label();
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.cboEstablecimiento = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.msktxtHora = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // dtpTiempo
            // 
            this.dtpTiempo.CustomFormat = "YYYY/MM/DD";
            this.dtpTiempo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTiempo.Location = new System.Drawing.Point(126, 32);
            this.dtpTiempo.Name = "dtpTiempo";
            this.dtpTiempo.Size = new System.Drawing.Size(203, 20);
            this.dtpTiempo.TabIndex = 0;
            this.dtpTiempo.ValueChanged += new System.EventHandler(this.dtpTiempo_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(40, 38);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Location = new System.Drawing.Point(40, 110);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(41, 13);
            this.lblEvento.TabIndex = 2;
            this.lblEvento.Text = "Evento";
            // 
            // lblEstablecimiento
            // 
            this.lblEstablecimiento.AutoSize = true;
            this.lblEstablecimiento.Location = new System.Drawing.Point(40, 154);
            this.lblEstablecimiento.Name = "lblEstablecimiento";
            this.lblEstablecimiento.Size = new System.Drawing.Size(81, 13);
            this.lblEstablecimiento.TabIndex = 3;
            this.lblEstablecimiento.Text = "Establecimiento";
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(127, 107);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(202, 20);
            this.txtEvento.TabIndex = 2;
            this.txtEvento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEvento_KeyPress);
            // 
            // cboEstablecimiento
            // 
            this.cboEstablecimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstablecimiento.FormattingEnabled = true;
            this.cboEstablecimiento.Location = new System.Drawing.Point(128, 146);
            this.cboEstablecimiento.Name = "cboEstablecimiento";
            this.cboEstablecimiento.Size = new System.Drawing.Size(203, 21);
            this.cboEstablecimiento.TabIndex = 3;
            this.cboEstablecimiento.SelectedIndexChanged += new System.EventHandler(this.cboEstablecimiento_SelectedIndexChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(209, 237);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 26);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(313, 237);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(67, 26);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(43, 237);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(78, 26);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(40, 77);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 9;
            this.lblHora.Text = "Hora";
            // 
            // msktxtHora
            // 
            this.msktxtHora.Location = new System.Drawing.Point(128, 74);
            this.msktxtHora.Mask = "00:00";
            this.msktxtHora.Name = "msktxtHora";
            this.msktxtHora.Size = new System.Drawing.Size(201, 20);
            this.msktxtHora.TabIndex = 1;
            this.msktxtHora.ValidatingType = typeof(System.DateTime);
            // 
            // CargarEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 275);
            this.Controls.Add(this.msktxtHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cboEstablecimiento);
            this.Controls.Add(this.txtEvento);
            this.Controls.Add(this.lblEstablecimiento);
            this.Controls.Add(this.lblEvento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpTiempo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CargarEventos";
            this.ShowInTaskbar = false;
            this.Text = "CargarEventos";
            this.Load += new System.EventHandler(this.CargarEventos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTiempo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.Label lblEstablecimiento;
        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.ComboBox cboEstablecimiento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.MaskedTextBox msktxtHora;
    }
}
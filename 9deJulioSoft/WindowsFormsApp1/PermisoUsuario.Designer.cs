
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
            this.dgvPermisoUsuario = new System.Windows.Forms.DataGridView();
            this.grbContieneGrilla = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisoUsuario)).BeginInit();
            this.grbContieneGrilla.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPermisoUsuario
            // 
            this.dgvPermisoUsuario.AllowUserToAddRows = false;
            this.dgvPermisoUsuario.AllowUserToDeleteRows = false;
            this.dgvPermisoUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPermisoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisoUsuario.Location = new System.Drawing.Point(5, 64);
            this.dgvPermisoUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPermisoUsuario.Name = "dgvPermisoUsuario";
            this.dgvPermisoUsuario.RowHeadersWidth = 51;
            this.dgvPermisoUsuario.RowTemplate.Height = 28;
            this.dgvPermisoUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPermisoUsuario.Size = new System.Drawing.Size(601, 146);
            this.dgvPermisoUsuario.TabIndex = 14;
            // 
            // grbContieneGrilla
            // 
            this.grbContieneGrilla.Controls.Add(this.btnGuardar);
            this.grbContieneGrilla.Controls.Add(this.label1);
            this.grbContieneGrilla.Controls.Add(this.cboUsuarios);
            this.grbContieneGrilla.Controls.Add(this.dgvPermisoUsuario);
            this.grbContieneGrilla.Location = new System.Drawing.Point(24, 23);
            this.grbContieneGrilla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbContieneGrilla.Name = "grbContieneGrilla";
            this.grbContieneGrilla.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbContieneGrilla.Size = new System.Drawing.Size(612, 274);
            this.grbContieneGrilla.TabIndex = 16;
            this.grbContieneGrilla.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(436, 229);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(170, 32);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Usuario";
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(107, 21);
            this.cboUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(211, 24);
            this.cboUsuarios.TabIndex = 21;
            this.cboUsuarios.SelectedIndexChanged += new System.EventHandler(this.cboUsuarios_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(537, 331);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 26);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PermisoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 368);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grbContieneGrilla);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PermisoUsuario";
            this.Text = "PermisoUsuario";
            this.Load += new System.EventHandler(this.PermisoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisoUsuario)).EndInit();
            this.grbContieneGrilla.ResumeLayout(false);
            this.grbContieneGrilla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPermisoUsuario;
        private System.Windows.Forms.GroupBox grbContieneGrilla;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboUsuarios;
        private System.Windows.Forms.Button btnSalir;
    }
}
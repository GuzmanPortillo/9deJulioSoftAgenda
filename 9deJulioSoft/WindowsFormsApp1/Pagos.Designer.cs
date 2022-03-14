
namespace CapaPresentacion
{
    partial class Pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagos));
            this.label1 = new System.Windows.Forms.Label();
            this.txtIngresarSocio = new System.Windows.Forms.TextBox();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.lblNroSocio = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnGenerarInforme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1192, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pagos";
            // 
            // txtIngresarSocio
            // 
            this.txtIngresarSocio.Location = new System.Drawing.Point(32, 79);
            this.txtIngresarSocio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIngresarSocio.Name = "txtIngresarSocio";
            this.txtIngresarSocio.Size = new System.Drawing.Size(187, 22);
            this.txtIngresarSocio.TabIndex = 3;
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Location = new System.Drawing.Point(32, 130);
            this.dgvPagos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.RowHeadersWidth = 51;
            this.dgvPagos.RowTemplate.Height = 28;
            this.dgvPagos.Size = new System.Drawing.Size(836, 298);
            this.dgvPagos.TabIndex = 4;
            this.dgvPagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblNroSocio
            // 
            this.lblNroSocio.AutoSize = true;
            this.lblNroSocio.Location = new System.Drawing.Point(41, 48);
            this.lblNroSocio.Name = "lblNroSocio";
            this.lblNroSocio.Size = new System.Drawing.Size(74, 17);
            this.lblNroSocio.TabIndex = 5;
            this.lblNroSocio.Text = "Nro. Socio";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(324, 62);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(132, 42);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(713, 446);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(155, 43);
            this.btnPagar.TabIndex = 7;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.Location = new System.Drawing.Point(743, 62);
            this.btnGenerarInforme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Size = new System.Drawing.Size(125, 42);
            this.btnGenerarInforme.TabIndex = 8;
            this.btnGenerarInforme.Text = "Generar Informe";
            this.btnGenerarInforme.UseVisualStyleBackColor = true;
            this.btnGenerarInforme.Click += new System.EventHandler(this.btnGenerarInforme_Click);
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 512);
            this.Controls.Add(this.btnGenerarInforme);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblNroSocio);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.txtIngresarSocio);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.Pagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIngresarSocio;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.Label lblNroSocio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnGenerarInforme;
    }
}
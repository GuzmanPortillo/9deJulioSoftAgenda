namespace CapaPresentacion
{
    partial class ReporteReservas
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
            this.dgvListaEventos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFecDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFecHasta = new System.Windows.Forms.DateTimePicker();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFecDesde = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEventos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaEventos
            // 
            this.dgvListaEventos.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEventos.Location = new System.Drawing.Point(42, 152);
            this.dgvListaEventos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvListaEventos.Name = "dgvListaEventos";
            this.dgvListaEventos.RowHeadersWidth = 62;
            this.dgvListaEventos.Size = new System.Drawing.Size(968, 228);
            this.dgvListaEventos.TabIndex = 10;
            this.dgvListaEventos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaEventos_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.dtpFecDesde);
            this.panel1.Controls.Add(this.dtpFecHasta);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.lblFechaHasta);
            this.panel1.Controls.Add(this.lblFecDesde);
            this.panel1.Location = new System.Drawing.Point(42, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 104);
            this.panel1.TabIndex = 9;
            // 
            // dtpFecDesde
            // 
            this.dtpFecDesde.Location = new System.Drawing.Point(19, 44);
            this.dtpFecDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFecDesde.Name = "dtpFecDesde";
            this.dtpFecDesde.Size = new System.Drawing.Size(135, 26);
            this.dtpFecDesde.TabIndex = 9;
            // 
            // dtpFecHasta
            // 
            this.dtpFecHasta.Location = new System.Drawing.Point(198, 44);
            this.dtpFecHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFecHasta.Name = "dtpFecHasta";
            this.dtpFecHasta.Size = new System.Drawing.Size(144, 26);
            this.dtpFecHasta.TabIndex = 9;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Location = new System.Drawing.Point(883, 5);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(85, 39);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Exportar";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(370, 38);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 32);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(194, 15);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(101, 20);
            this.lblFechaHasta.TabIndex = 2;
            this.lblFechaHasta.Text = "Fecha Hasta";
            // 
            // lblFecDesde
            // 
            this.lblFecDesde.AutoSize = true;
            this.lblFecDesde.Location = new System.Drawing.Point(15, 15);
            this.lblFecDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecDesde.Name = "lblFecDesde";
            this.lblFecDesde.Size = new System.Drawing.Size(105, 20);
            this.lblFecDesde.TabIndex = 3;
            this.lblFecDesde.Text = "Fecha Desde";
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(913, 400);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(87, 38);
            this.buttonVolver.TabIndex = 11;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReporteReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 450);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.dgvListaEventos);
            this.Controls.Add(this.panel1);
            this.Name = "ReporteReservas";
            this.Text = "Reporte Reservas";
            this.Load += new System.EventHandler(this.ReporteReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEventos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaEventos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpFecDesde;
        private System.Windows.Forms.DateTimePicker dtpFecHasta;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFecDesde;
        private System.Windows.Forms.Button buttonVolver;
    }
}
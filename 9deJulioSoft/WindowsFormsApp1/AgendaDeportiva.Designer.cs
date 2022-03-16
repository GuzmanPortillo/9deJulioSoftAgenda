
namespace CapaPresentacion
{
    partial class AgendaDeportiva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendaDeportiva));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMesAño = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHoy = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDomingo = new System.Windows.Forms.Label();
            this.lblViernes = new System.Windows.Forms.Label();
            this.lblSabado = new System.Windows.Forms.Label();
            this.lblLunes = new System.Windows.Forms.Label();
            this.lblMartes = new System.Windows.Forms.Label();
            this.lblMiercoles = new System.Windows.Forms.Label();
            this.lblJueves = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1158, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agenda Deportiva";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMesAño);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(33, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 83);
            this.panel1.TabIndex = 3;
            // 
            // lblMesAño
            // 
            this.lblMesAño.AutoSize = true;
            this.lblMesAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesAño.Location = new System.Drawing.Point(3, 12);
            this.lblMesAño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMesAño.Name = "lblMesAño";
            this.lblMesAño.Size = new System.Drawing.Size(189, 37);
            this.lblMesAño.TabIndex = 1;
            this.lblMesAño.Text = "Mes, Enero";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHoy);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPreview);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(814, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 83);
            this.panel2.TabIndex = 0;
            // 
            // btnHoy
            // 
            this.btnHoy.Location = new System.Drawing.Point(116, 12);
            this.btnHoy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(76, 49);
            this.btnHoy.TabIndex = 2;
            this.btnHoy.Text = "Hoy";
            this.btnHoy.UseVisualStyleBackColor = true;
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(201, 11);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 49);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(30, 12);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(76, 49);
            this.btnPreview.TabIndex = 0;
            this.btnPreview.Text = "<";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblDomingo);
            this.panel3.Controls.Add(this.lblViernes);
            this.panel3.Controls.Add(this.lblSabado);
            this.panel3.Controls.Add(this.lblLunes);
            this.panel3.Controls.Add(this.lblMartes);
            this.panel3.Controls.Add(this.lblMiercoles);
            this.panel3.Controls.Add(this.lblJueves);
            this.panel3.Location = new System.Drawing.Point(33, 112);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1094, 34);
            this.panel3.TabIndex = 4;
            // 
            // lblDomingo
            // 
            this.lblDomingo.BackColor = System.Drawing.Color.Silver;
            this.lblDomingo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomingo.Location = new System.Drawing.Point(4, 0);
            this.lblDomingo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDomingo.Name = "lblDomingo";
            this.lblDomingo.Size = new System.Drawing.Size(147, 31);
            this.lblDomingo.TabIndex = 15;
            this.lblDomingo.Text = "Domingo";
            this.lblDomingo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblViernes
            // 
            this.lblViernes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblViernes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViernes.Location = new System.Drawing.Point(790, 0);
            this.lblViernes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViernes.Name = "lblViernes";
            this.lblViernes.Size = new System.Drawing.Size(147, 31);
            this.lblViernes.TabIndex = 16;
            this.lblViernes.Text = "Viernes";
            this.lblViernes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSabado
            // 
            this.lblSabado.BackColor = System.Drawing.Color.Silver;
            this.lblSabado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabado.Location = new System.Drawing.Point(946, 3);
            this.lblSabado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSabado.Name = "lblSabado";
            this.lblSabado.Size = new System.Drawing.Size(147, 31);
            this.lblSabado.TabIndex = 14;
            this.lblSabado.Text = "Sabado";
            this.lblSabado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLunes
            // 
            this.lblLunes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblLunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLunes.Location = new System.Drawing.Point(160, 0);
            this.lblLunes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLunes.Name = "lblLunes";
            this.lblLunes.Size = new System.Drawing.Size(156, 31);
            this.lblLunes.TabIndex = 0;
            this.lblLunes.Text = "Lunes";
            this.lblLunes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMartes
            // 
            this.lblMartes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblMartes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMartes.Location = new System.Drawing.Point(326, 0);
            this.lblMartes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMartes.Name = "lblMartes";
            this.lblMartes.Size = new System.Drawing.Size(147, 31);
            this.lblMartes.TabIndex = 11;
            this.lblMartes.Text = "Martes";
            this.lblMartes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMiercoles
            // 
            this.lblMiercoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblMiercoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiercoles.Location = new System.Drawing.Point(482, 0);
            this.lblMiercoles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiercoles.Name = "lblMiercoles";
            this.lblMiercoles.Size = new System.Drawing.Size(147, 31);
            this.lblMiercoles.TabIndex = 12;
            this.lblMiercoles.Text = "Miercoles";
            this.lblMiercoles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJueves
            // 
            this.lblJueves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblJueves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJueves.Location = new System.Drawing.Point(638, 0);
            this.lblJueves.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJueves.Name = "lblJueves";
            this.lblJueves.Size = new System.Drawing.Size(147, 31);
            this.lblJueves.TabIndex = 13;
            this.lblJueves.Text = "Jueves";
            this.lblJueves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 29);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 29);
            this.label6.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 29);
            this.label7.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel9);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 160);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1094, 663);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Location = new System.Drawing.Point(52, 5);
            this.flowLayoutPanel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel9.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(936, 833);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(191, 49);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // AgendaDeportiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 892);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AgendaDeportiva";
            this.Text = "Agenda Deportiva";
            this.Load += new System.EventHandler(this.AgendaDeportiva_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMesAño;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblLunes;
        private System.Windows.Forms.Label lblDomingo;
        private System.Windows.Forms.Label lblViernes;
        private System.Windows.Forms.Label lblSabado;
        private System.Windows.Forms.Label lblMartes;
        private System.Windows.Forms.Label lblMiercoles;
        private System.Windows.Forms.Label lblJueves;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.Button btnHoy;
        private System.Windows.Forms.Button btnSalir;
    }
}
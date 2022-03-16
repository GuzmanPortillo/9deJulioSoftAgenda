
namespace CapaPresentacion
{
    partial class BackupAndRestoreDB
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
            this.txtbkp = new System.Windows.Forms.TextBox();
            this.txtRestore = new System.Windows.Forms.TextBox();
            this.btnDirectorio = new System.Windows.Forms.Button();
            this.BtnDirectorioRest = new System.Windows.Forms.Button();
            this.grbRestore = new System.Windows.Forms.GroupBox();
            this.btnRestoreDB = new System.Windows.Forms.Button();
            this.grbBkp = new System.Windows.Forms.GroupBox();
            this.btnbkpDB = new System.Windows.Forms.Button();
            this.grbSalir = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbRestore.SuspendLayout();
            this.grbBkp.SuspendLayout();
            this.grbSalir.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbkp
            // 
            this.txtbkp.Location = new System.Drawing.Point(31, 48);
            this.txtbkp.Name = "txtbkp";
            this.txtbkp.Size = new System.Drawing.Size(299, 20);
            this.txtbkp.TabIndex = 0;
            // 
            // txtRestore
            // 
            this.txtRestore.Location = new System.Drawing.Point(33, 43);
            this.txtRestore.Name = "txtRestore";
            this.txtRestore.Size = new System.Drawing.Size(299, 20);
            this.txtRestore.TabIndex = 1;
            // 
            // btnDirectorio
            // 
            this.btnDirectorio.Location = new System.Drawing.Point(361, 39);
            this.btnDirectorio.Name = "btnDirectorio";
            this.btnDirectorio.Size = new System.Drawing.Size(76, 29);
            this.btnDirectorio.TabIndex = 2;
            this.btnDirectorio.Text = "Directorio";
            this.btnDirectorio.UseVisualStyleBackColor = true;
            this.btnDirectorio.Click += new System.EventHandler(this.btnDirectorio_Click);
            // 
            // BtnDirectorioRest
            // 
            this.BtnDirectorioRest.Location = new System.Drawing.Point(363, 34);
            this.BtnDirectorioRest.Name = "BtnDirectorioRest";
            this.BtnDirectorioRest.Size = new System.Drawing.Size(76, 29);
            this.BtnDirectorioRest.TabIndex = 3;
            this.BtnDirectorioRest.Text = "Directorio";
            this.BtnDirectorioRest.UseVisualStyleBackColor = true;
            this.BtnDirectorioRest.Click += new System.EventHandler(this.BtnDirectorioRest_Click);
            // 
            // grbRestore
            // 
            this.grbRestore.Controls.Add(this.btnRestoreDB);
            this.grbRestore.Controls.Add(this.txtRestore);
            this.grbRestore.Controls.Add(this.BtnDirectorioRest);
            this.grbRestore.Location = new System.Drawing.Point(45, 184);
            this.grbRestore.Name = "grbRestore";
            this.grbRestore.Size = new System.Drawing.Size(466, 113);
            this.grbRestore.TabIndex = 4;
            this.grbRestore.TabStop = false;
            this.grbRestore.Text = "Restore";
            // 
            // btnRestoreDB
            // 
            this.btnRestoreDB.Location = new System.Drawing.Point(136, 69);
            this.btnRestoreDB.Name = "btnRestoreDB";
            this.btnRestoreDB.Size = new System.Drawing.Size(106, 27);
            this.btnRestoreDB.TabIndex = 4;
            this.btnRestoreDB.Text = "Recuperar ";
            this.btnRestoreDB.UseVisualStyleBackColor = true;
            this.btnRestoreDB.Click += new System.EventHandler(this.btnRestoreDB_Click);
            // 
            // grbBkp
            // 
            this.grbBkp.Controls.Add(this.btnbkpDB);
            this.grbBkp.Controls.Add(this.txtbkp);
            this.grbBkp.Controls.Add(this.btnDirectorio);
            this.grbBkp.Location = new System.Drawing.Point(48, 35);
            this.grbBkp.Name = "grbBkp";
            this.grbBkp.Size = new System.Drawing.Size(463, 117);
            this.grbBkp.TabIndex = 5;
            this.grbBkp.TabStop = false;
            this.grbBkp.Text = "Backup";
            // 
            // btnbkpDB
            // 
            this.btnbkpDB.Location = new System.Drawing.Point(133, 74);
            this.btnbkpDB.Name = "btnbkpDB";
            this.btnbkpDB.Size = new System.Drawing.Size(106, 27);
            this.btnbkpDB.TabIndex = 3;
            this.btnbkpDB.Text = "Backup ";
            this.btnbkpDB.UseVisualStyleBackColor = true;
            this.btnbkpDB.Click += new System.EventHandler(this.btnbkpDB_Click);
            // 
            // grbSalir
            // 
            this.grbSalir.Controls.Add(this.btnSalir);
            this.grbSalir.Location = new System.Drawing.Point(45, 307);
            this.grbSalir.Name = "grbSalir";
            this.grbSalir.Size = new System.Drawing.Size(465, 48);
            this.grbSalir.TabIndex = 6;
            this.grbSalir.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(363, 15);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 27);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // BackupAndRestoreDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 396);
            this.Controls.Add(this.grbSalir);
            this.Controls.Add(this.grbBkp);
            this.Controls.Add(this.grbRestore);
            this.Name = "BackupAndRestoreDB";
            this.Text = "BackupAndRestoreDB";
            this.grbRestore.ResumeLayout(false);
            this.grbRestore.PerformLayout();
            this.grbBkp.ResumeLayout(false);
            this.grbBkp.PerformLayout();
            this.grbSalir.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbkp;
        private System.Windows.Forms.TextBox txtRestore;
        private System.Windows.Forms.Button btnDirectorio;
        private System.Windows.Forms.Button BtnDirectorioRest;
        private System.Windows.Forms.GroupBox grbRestore;
        private System.Windows.Forms.Button btnRestoreDB;
        private System.Windows.Forms.GroupBox grbBkp;
        private System.Windows.Forms.Button btnbkpDB;
        private System.Windows.Forms.GroupBox grbSalir;
        private System.Windows.Forms.Button btnSalir;
    }
}
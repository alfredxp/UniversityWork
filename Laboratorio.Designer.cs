
namespace SistemaVacunacion
{
    partial class Laboratorio
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
            this.LbTituloLab = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.TxtLAB2 = new System.Windows.Forms.TextBox();
            this.Lb2Lab = new System.Windows.Forms.Label();
            this.TxtLAB1 = new System.Windows.Forms.TextBox();
            this.Lb1Lab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbTituloLab
            // 
            this.LbTituloLab.AutoSize = true;
            this.LbTituloLab.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTituloLab.Location = new System.Drawing.Point(266, 50);
            this.LbTituloLab.Name = "LbTituloLab";
            this.LbTituloLab.Size = new System.Drawing.Size(224, 23);
            this.LbTituloLab.TabIndex = 1;
            this.LbTituloLab.Text = "Registro de Laboratorio";
            this.LbTituloLab.Click += new System.EventHandler(this.LbTitulo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(479, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 36);
            this.button1.TabIndex = 24;
            this.button1.Text = "CANCELAR ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.Location = new System.Drawing.Point(148, 228);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(187, 36);
            this.BtnRegistrar.TabIndex = 23;
            this.BtnRegistrar.Text = "REGISTRAR";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // TxtLAB2
            // 
            this.TxtLAB2.Location = new System.Drawing.Point(270, 136);
            this.TxtLAB2.Name = "TxtLAB2";
            this.TxtLAB2.Size = new System.Drawing.Size(341, 20);
            this.TxtLAB2.TabIndex = 16;
            // 
            // Lb2Lab
            // 
            this.Lb2Lab.AutoSize = true;
            this.Lb2Lab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb2Lab.Location = new System.Drawing.Point(79, 136);
            this.Lb2Lab.Name = "Lb2Lab";
            this.Lb2Lab.Size = new System.Drawing.Size(185, 20);
            this.Lb2Lab.TabIndex = 15;
            this.Lb2Lab.Text = "Nombre de Laboratorio:";
            // 
            // TxtLAB1
            // 
            this.TxtLAB1.Location = new System.Drawing.Point(270, 94);
            this.TxtLAB1.Name = "TxtLAB1";
            this.TxtLAB1.Size = new System.Drawing.Size(341, 20);
            this.TxtLAB1.TabIndex = 14;
            // 
            // Lb1Lab
            // 
            this.Lb1Lab.AutoSize = true;
            this.Lb1Lab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb1Lab.Location = new System.Drawing.Point(144, 94);
            this.Lb1Lab.Name = "Lb1Lab";
            this.Lb1Lab.Size = new System.Drawing.Size(118, 20);
            this.Lb1Lab.TabIndex = 13;
            this.Lb1Lab.Text = "ID Laboratorio:";
            // 
            // Laboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.TxtLAB2);
            this.Controls.Add(this.Lb2Lab);
            this.Controls.Add(this.TxtLAB1);
            this.Controls.Add(this.Lb1Lab);
            this.Controls.Add(this.LbTituloLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Laboratorio";
            this.Text = "Laboratorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTituloLab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.TextBox TxtLAB2;
        private System.Windows.Forms.Label Lb2Lab;
        private System.Windows.Forms.TextBox TxtLAB1;
        private System.Windows.Forms.Label Lb1Lab;
    }
}
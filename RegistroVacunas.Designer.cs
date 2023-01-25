
namespace SistemaVacunacion
{
    partial class RegistroVacunas
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
            this.LbTitulo = new System.Windows.Forms.Label();
            this.Lb1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Lb2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Lb3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Lb4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Lb5 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbTitulo
            // 
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.Location = new System.Drawing.Point(312, 38);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(199, 23);
            this.LbTitulo.TabIndex = 0;
            this.LbTitulo.Text = "Registro de Vacunas";
            this.LbTitulo.Click += new System.EventHandler(this.LbTitulo_Click);
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb1.Location = new System.Drawing.Point(168, 101);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(92, 20);
            this.Lb1.TabIndex = 1;
            this.Lb1.Text = "ID Vacuna:";
            this.Lb1.Click += new System.EventHandler(this.Lb1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(268, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(341, 20);
            this.textBox2.TabIndex = 4;
            // 
            // Lb2
            // 
            this.Lb2.AutoSize = true;
            this.Lb2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb2.Location = new System.Drawing.Point(102, 145);
            this.Lb2.Name = "Lb2";
            this.Lb2.Size = new System.Drawing.Size(158, 20);
            this.Lb2.TabIndex = 3;
            this.Lb2.Text = "Nombre de vacuna:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(268, 189);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(341, 20);
            this.textBox3.TabIndex = 6;
            // 
            // Lb3
            // 
            this.Lb3.AutoSize = true;
            this.Lb3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb3.Location = new System.Drawing.Point(168, 189);
            this.Lb3.Name = "Lb3";
            this.Lb3.Size = new System.Drawing.Size(92, 20);
            this.Lb3.TabIndex = 5;
            this.Lb3.Text = "Proveedor:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(268, 231);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(341, 20);
            this.textBox4.TabIndex = 8;
            // 
            // Lb4
            // 
            this.Lb4.AutoSize = true;
            this.Lb4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb4.Location = new System.Drawing.Point(168, 231);
            this.Lb4.Name = "Lb4";
            this.Lb4.Size = new System.Drawing.Size(94, 20);
            this.Lb4.TabIndex = 7;
            this.Lb4.Text = "Laboratorio";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(268, 273);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(341, 20);
            this.textBox5.TabIndex = 10;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Lb5
            // 
            this.Lb5.AutoSize = true;
            this.Lb5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb5.Location = new System.Drawing.Point(157, 273);
            this.Lb5.Name = "Lb5";
            this.Lb5.Size = new System.Drawing.Size(103, 20);
            this.Lb5.TabIndex = 9;
            this.Lb5.Text = "Enfermedad:";
            this.Lb5.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.Location = new System.Drawing.Point(225, 334);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(187, 36);
            this.BtnRegistrar.TabIndex = 11;
            this.BtnRegistrar.Text = "REGISTRAR";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(467, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "CANCELAR ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // RegistroVacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Lb5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Lb4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Lb3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Lb2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lb1);
            this.Controls.Add(this.LbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroVacunas";
            this.Text = "RegistroVacunas";
            this.Load += new System.EventHandler(this.RegistroVacunas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Lb2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Lb3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Lb4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label Lb5;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button button1;
    }
}
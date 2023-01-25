
namespace SistemaVacunacion
{
    partial class Proveedores
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
            this.LbTituloProv = new System.Windows.Forms.Label();
            this.TxtNomProv = new System.Windows.Forms.TextBox();
            this.Lb2Prov = new System.Windows.Forms.Label();
            this.TxtProvID = new System.Windows.Forms.TextBox();
            this.Lb1 = new System.Windows.Forms.Label();
            this.BtnCancelarProv = new System.Windows.Forms.Button();
            this.BtnRegistrarProv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbTituloProv
            // 
            this.LbTituloProv.AutoSize = true;
            this.LbTituloProv.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTituloProv.Location = new System.Drawing.Point(247, 52);
            this.LbTituloProv.Name = "LbTituloProv";
            this.LbTituloProv.Size = new System.Drawing.Size(233, 23);
            this.LbTituloProv.TabIndex = 1;
            this.LbTituloProv.Text = "Registro de Proveedores";
            this.LbTituloProv.Click += new System.EventHandler(this.LbTituloProv_Click);
            // 
            // TxtNomProv
            // 
            this.TxtNomProv.Location = new System.Drawing.Point(251, 150);
            this.TxtNomProv.Name = "TxtNomProv";
            this.TxtNomProv.Size = new System.Drawing.Size(341, 20);
            this.TxtNomProv.TabIndex = 8;
            this.TxtNomProv.TextChanged += new System.EventHandler(this.TxtNomProv_TextChanged);
            // 
            // Lb2Prov
            // 
            this.Lb2Prov.AutoSize = true;
            this.Lb2Prov.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb2Prov.Location = new System.Drawing.Point(60, 150);
            this.Lb2Prov.Name = "Lb2Prov";
            this.Lb2Prov.Size = new System.Drawing.Size(180, 20);
            this.Lb2Prov.TabIndex = 7;
            this.Lb2Prov.Text = "Nombre de proveedor:";
            this.Lb2Prov.Click += new System.EventHandler(this.Lb2Prov_Click);
            // 
            // TxtProvID
            // 
            this.TxtProvID.Location = new System.Drawing.Point(251, 108);
            this.TxtProvID.Name = "TxtProvID";
            this.TxtProvID.Size = new System.Drawing.Size(341, 20);
            this.TxtProvID.TabIndex = 6;
            this.TxtProvID.TextChanged += new System.EventHandler(this.TxtProvID_TextChanged);
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb1.Location = new System.Drawing.Point(127, 106);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(112, 20);
            this.Lb1.TabIndex = 5;
            this.Lb1.Text = "ID Proveedor:";
            this.Lb1.Click += new System.EventHandler(this.Lb1_Click);
            // 
            // BtnCancelarProv
            // 
            this.BtnCancelarProv.BackColor = System.Drawing.Color.Red;
            this.BtnCancelarProv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarProv.Location = new System.Drawing.Point(423, 207);
            this.BtnCancelarProv.Name = "BtnCancelarProv";
            this.BtnCancelarProv.Size = new System.Drawing.Size(197, 36);
            this.BtnCancelarProv.TabIndex = 14;
            this.BtnCancelarProv.Text = "CANCELAR ";
            this.BtnCancelarProv.UseVisualStyleBackColor = false;
            this.BtnCancelarProv.Click += new System.EventHandler(this.BtnCancelarProv_Click);
            // 
            // BtnRegistrarProv
            // 
            this.BtnRegistrarProv.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnRegistrarProv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarProv.Location = new System.Drawing.Point(181, 207);
            this.BtnRegistrarProv.Name = "BtnRegistrarProv";
            this.BtnRegistrarProv.Size = new System.Drawing.Size(187, 36);
            this.BtnRegistrarProv.TabIndex = 13;
            this.BtnRegistrarProv.Text = "REGISTRAR";
            this.BtnRegistrarProv.UseVisualStyleBackColor = false;
            this.BtnRegistrarProv.Click += new System.EventHandler(this.BtnRegistrarProv_Click);
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancelarProv);
            this.Controls.Add(this.BtnRegistrarProv);
            this.Controls.Add(this.TxtNomProv);
            this.Controls.Add(this.Lb2Prov);
            this.Controls.Add(this.TxtProvID);
            this.Controls.Add(this.Lb1);
            this.Controls.Add(this.LbTituloProv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTituloProv;
        private System.Windows.Forms.TextBox TxtNomProv;
        private System.Windows.Forms.Label Lb2Prov;
        private System.Windows.Forms.TextBox TxtProvID;
        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.Button BtnCancelarProv;
        private System.Windows.Forms.Button BtnRegistrarProv;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVacunacion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;

        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubMenuEV.Visible = true;
        }

        private void btnEventoVacunas_Click(object sender, EventArgs e)
        {
            SubMenuVac.Visible = true;
            AbrirPantallaSecundaria(new VacunasAgregadas());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SubMenuVac.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SubMenuVac.Visible = false;
            AbrirPantallaSecundaria(new RegistroVacunas());
        }

        private void SubMenuEV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnV2_Click(object sender, EventArgs e)
        {
            SubMenuVac.Visible = false;
            AbrirPantallaSecundaria(new RegistroVacunas());
        }
        private void BtnEV1_Click(object sender, EventArgs e)
        {
            SubMenuEV.Visible = false;
            AbrirPantallaSecundaria(new Laboratorio());

        }

        private void BtnEV2_Click(object sender, EventArgs e)
        {
            SubMenuEV.Visible = false;
            AbrirPantallaSecundaria(new Proveedores());
        }

        private void BtnEV3_Click(object sender, EventArgs e)
        {
            SubMenuEV.Visible = false;
            AbrirPantallaSecundaria(new Centro_de_vacunacion());
        }

        private void SubMenuEV_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {
        
        }
        
        private void AbrirPantallaSecundaria (object formhija)
        {
            if (this.panelComponentes.Controls.Count > 0)
                this.panelComponentes.Controls.RemoveAt(0);
            Form Fs = formhija as Form;
            Fs.TopLevel = false;
            Fs.Dock = DockStyle.Fill;
            this.panelComponentes.Controls.Add(Fs);
            this.panelComponentes.Tag = Fs;
            Fs.Show();



        }

        private void BtnElimVac_Click(object sender, EventArgs e)
        {
            SubMenuVac.Visible = false;
            AbrirPantallaSecundaria(new EliminarVacuna());
        }
    }

}

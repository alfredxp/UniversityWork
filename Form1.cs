using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVacunacion
{
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("server = DESKTOP-0DEC350; database = Roles_Permisos; INTEGRATED SECURITY = True");

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            {
                conn.Open();
                SqlCommand operacion = new SqlCommand("SELECT email, password FROM usuario WHERE email = @varusuario AND password = @varcontraseña", conn);
                operacion.Parameters.AddWithValue("@varusuario", txtUsuario.Text);
                operacion.Parameters.AddWithValue("@varcontraseña", txtUsuario.Text);
                SqlDataReader reader = operacion.ExecuteReader();

                if (reader.Read())

                    conn.Close();
                {

                    Inicio PantallaPrincipal = new Inicio();
                    PantallaPrincipal.Show();

                }

            }
        }


    private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;

        }

        private void PanelEncabezado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarUsuario registro = new RegistrarUsuario();
            registro.Show();
        }
    }
    }


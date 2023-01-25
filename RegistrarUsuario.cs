using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SistemaVacunacion
{
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server = DESKTOP-0DEC350; database = Roles_Permisos; INTEGRATED SECURITY = True");

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
        }

        private void PanelUsuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnConfirmarUser_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand operacion = new SqlCommand("INSERT INTO usuario (nombre, email, password, idRol,cedula) values (@varnombre, @varemail, @varpassword, @varidRol,@varcedula )", conn);
            operacion.Parameters.AddWithValue("@varnombre", TxtNombre.Text);
            operacion.Parameters.AddWithValue("@varemail", TxtCorreoEL.Text);
            operacion.Parameters.AddWithValue("@varpassword", TxtContraseña.Text);
            operacion.Parameters.AddWithValue("@varidRol", 1);
            operacion.Parameters.AddWithValue("@varcedula", TxtCedula.Text);
            operacion.ExecuteNonQuery();
            operacion.Parameters.Clear();
            MessageBox.Show("Usuario registrado sastifactoriamente.");
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCorreoEL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

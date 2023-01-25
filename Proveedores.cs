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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server = DESKTOP-0DEC350; database = Roles_Permisos; INTEGRATED SECURITY = True");
        private void BtnRegistrarProv_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand operacion = new SqlCommand("INSERT INTO Proveedores (Cod_Proveedor, Nombre_Proveedor, Estatus) values (@varcodigoprov, @varnombreprov, @varestatus)", conn);
            operacion.Parameters.AddWithValue("@varcodigoprov", TxtProvID.Text);
            operacion.Parameters.AddWithValue("@varnombreprov", TxtNomProv.Text);
            operacion.Parameters.AddWithValue("@varestatus", 'A');
            operacion.ExecuteNonQuery();
            operacion.Parameters.Clear();
            MessageBox.Show("Proveedor registrado sastifactoriamente.");
        }

        private void BtnCancelarProv_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtNomProv_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lb2Prov_Click(object sender, EventArgs e)
        {

        }

        private void TxtProvID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lb1_Click(object sender, EventArgs e)
        {

        }

        private void LbTituloProv_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Laboratorio : Form
    {
        public Laboratorio()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server = DESKTOP-0DEC350; database = Roles_Permisos; INTEGRATED SECURITY = True");
        private void LbTitulo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand operacion = new SqlCommand("INSERT INTO Laboratorios (Cod_Laboratorio, Nombre_Laboratorio, Estatus) values (@varcodigolab, @varnombrelab, @varestatus)", conn);
            operacion.Parameters.AddWithValue("@varcodigolab", TxtLAB1.Text);
            operacion.Parameters.AddWithValue("@varnombrelab", TxtLAB2.Text);
            operacion.Parameters.AddWithValue("@varestatus", 'A');
            operacion.ExecuteNonQuery();
            operacion.Parameters.Clear();
            MessageBox.Show("Laboratorio registrado sastifactoriamente.");
        }
    }
}

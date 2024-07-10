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

namespace Prototipo_de_Recursos_Humanos
{
    public partial class Form_horastrab : Form
    {
        public Form_horastrab()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-0S5QCQQ;Initial Catalog=SARH;Integrated Security=True");

        private void pnl_busqueda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM Horas_trabajadas";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_horas.DataSource = dt;
        }
    }
    
}

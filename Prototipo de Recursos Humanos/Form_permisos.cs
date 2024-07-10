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
    public partial class Form_permisos : Form
    {
        public Form_permisos()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-0S5QCQQ;Initial Catalog=SARH;Integrated Security=True");

        private void Form_permisos_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM Permisos";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}

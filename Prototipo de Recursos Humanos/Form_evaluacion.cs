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
    public partial class Form_evaluacion : Form
    {
        public Form_evaluacion()
        {
            InitializeComponent();

            
            
        }

        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-0S5QCQQ;Initial Catalog=SARH;Integrated Security=True");

        private void btn_tabla_Click(object sender, EventArgs e)
        {
            
            dgv_desempeño.Show();
            
            
            
            lbl_area.Hide();
            lbl_cargo.Hide();
            cbx_area.Hide();
            cbx_cargo.Hide();
            btn_lista.Hide();
            lstbx_empleados2.Hide();
            btn_regreso.BringToFront();
            //this.Hide();


            string consulta = "SELECT * FROM Desempeño";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_desempeño.DataSource = dt;
        }

 

        private void Form_evaluacion_Load(object sender, EventArgs e)
        {
            dgv_desempeño.Hide();

            string consulta = "SELECT * FROM Desempeño";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_desempeño.DataSource = dt;
        }

        private void btn_regreso_Click(object sender, EventArgs e)
        {
            btn_tabla.BringToFront();

            dgv_desempeño.Hide();
            lbl_area.Show();
            lbl_cargo.Show();
            cbx_area.Show();
            cbx_cargo.Show();
            btn_lista.Show();
            lstbx_empleados2.Show();
            

        }

        private void btn_lista_Click(object sender, EventArgs e)
        {
            lstbx_empleados2.Items.Add("Juan Perez\n");
            lstbx_empleados2.Items.Add("Maria Lopez\n");
            lstbx_empleados2.Items.Add("Carlos Ruiz\n");
            lstbx_empleados2.Items.Add("Ana Gomez\n");
            lstbx_empleados2.Items.Add("Luis Martinez\n");
            lstbx_empleados2.Items.Add("Antonio Grazman\n");
        }
    }
}

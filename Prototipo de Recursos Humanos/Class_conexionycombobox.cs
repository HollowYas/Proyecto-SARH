using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Prototipo_de_Recursos_Humanos
{
    class Class_conexionycombobox : Form_empleados
    {
        SqlConnection cnn;
        SqlCommand cm;
        SqlDataReader dr;


        public Class_conexionycombobox()
        {

            cnn = new SqlConnection("Data Source=DESKTOP-0S5QCQQ;Initial Catalog=SARH;Integrated Security=True");
            cnn.Open();

        }

        public void rellanarCombobox(ComboBox cb) 
        {
            cm = new SqlCommand("Select Nombre from Empleados",cnn);
            dr = cm.ExecuteReader();
            while (dr.Read()) 
            {
                cb.Items.Add(dr["Nombre"].ToString());
            }

            cb.SelectedItem = 0;
            cnn.Close();

        }

    }
}

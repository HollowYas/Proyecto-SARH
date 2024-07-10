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
    public partial class Form_empleados : Form
    {
        public Form_empleados()
        {
            InitializeComponent();
        }

        private void Form_empleados_Load(object sender, EventArgs e)
        {

            Class_conexionycombobox dt = new Class_conexionycombobox();
            dt.rellanarCombobox(cbx_empleados1);


        }

        private void btn_buscar01_Click(object sender, EventArgs e)
        {
            string Seleccion;
           Seleccion= cbx_empleados1.SelectedItem.ToString();

            if(Seleccion == "Juan Perez") 
            {
                lbl_nombre.Text = "Juan Perez";
                lbl_salariobase.Text = "2000";
                lbl_id1.Text = "E12345";
                ptb_empleados.ImageLocation= @"C:\Users\admin\Desktop\isaac\año 2024\Geometria Computarizada\trabajo de SARH\Prototipo de Recursos Humanos\Prototipo de Recursos Humanos\Resources\Juan perez.jpg";
            }

            if (Seleccion == "Maria Lopez")
            {
                lbl_nombre.Text = "Maria Lopez";
                lbl_salariobase.Text = "1500";
                lbl_id1.Text = "E12346";
                ptb_empleados.ImageLocation = @"C:\Users\admin\Desktop\isaac\año 2024\Geometria Computarizada\trabajo de SARH\Prototipo de Recursos Humanos\Prototipo de Recursos Humanos\Resources\Maria gomez.jpg";
            }

            if (Seleccion == "Carlos Ruiz")
            {
                lbl_nombre.Text = "Carlos Ruiz";
                lbl_salariobase.Text = "2500";
                lbl_id1.Text = "E12347";
                ptb_empleados.ImageLocation = @"C:\Users\admin\Desktop\isaac\año 2024\Geometria Computarizada\trabajo de SARH\Prototipo de Recursos Humanos\Prototipo de Recursos Humanos\Resources\Carlos Ruiz.jpg";
            }



            if (Seleccion == "Luis Martinez")
            {
                lbl_nombre.Text = "Luis Martinez";
                lbl_salariobase.Text = "1000";
                lbl_id1.Text = "E12349";
                ptb_empleados.ImageLocation = @"C:\Users\admin\Desktop\isaac\año 2024\Geometria Computarizada\trabajo de SARH\Prototipo de Recursos Humanos\Prototipo de Recursos Humanos\Resources\Luis.PNG";
            }

            if (Seleccion == "Ana Gomez")
            {
                lbl_nombre.Text = "Ana Gomez";
                lbl_salariobase.Text = "1300";
                lbl_id1.Text = "E12348";
                ptb_empleados.ImageLocation = @"C:\Users\admin\Desktop\isaac\año 2024\Geometria Computarizada\trabajo de SARH\Prototipo de Recursos Humanos\Prototipo de Recursos Humanos\Resources\ana.jpg";
            }


        }


    }
}

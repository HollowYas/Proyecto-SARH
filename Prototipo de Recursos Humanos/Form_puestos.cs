using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_de_Recursos_Humanos
{
    public partial class Form_puestos : Form
    {
        public Form_puestos()
        {
            InitializeComponent();
        }

        private void btn_colaborador_Click(object sender, EventArgs e)
        {
            lbl_cantidad.Text = "63";
            lbl_puesto.Text = "20";
        }

        private void btn_gerente_Click(object sender, EventArgs e)
        {

            lbl_cantidad.Text = "10";
            lbl_puesto.Text = "2";

        }
    }
}

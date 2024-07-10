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
    public partial class Form_acercasarh : Form
    {
        public Form_acercasarh()
        {
            InitializeComponent();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            //instancias de la clase que almacena el texto de los txt y el formulario que posee el ReportView
            Class_datreporte datreporte = new Class_datreporte();
            Form_reportview reportview = new Form_reportview();

            datreporte.id = txt_id.Text;
            datreporte.nombres = txt_nombre.Text;
            datreporte.asuntos = txt_asunto.Text;
            datreporte.fechas = txt_fecha.Text;
            datreporte.horas = txt_hora.Text;
            datreporte.contenidos = txt_contenido.Text;
            reportview.datreportes.Add(datreporte);
            reportview.Show();

        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puede ingresar Letras en esta campo", "Daton no valido",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }
    }
}

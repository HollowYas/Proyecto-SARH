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
    public partial class Form_departamentos : Form
    {
        public Form_departamentos()
        {
            InitializeComponent();
            obj_presentacion.cargar_imagenes(ptb_info);

        }

        Class_pressentacion obj_presentacion = new Class_pressentacion();

        private void btn_seguiente2_Click(object sender, EventArgs e)
        {
            
            obj_presentacion.cambio_adelante(ptb_info);


            if (ptb_info.ImageLocation == @"E:\trabajo de SARH\Prototipo de Recursos Humanos\Prototipo de Recursos Humanos\Resources\pngproduccion.PNG")
            {
                //cambio para Produccion
                lbl_colaboradores.Text = "23";
                lbl_satisfaccion.Text = "Muy Alta";
                lbl_asistencia.Text = "Media";
                lbl_departamento.Text = "Produccion";

            }
            if (ptb_info.ImageLocation == @"E:\trabajo de SARH\Prototipo de Recursos Humanos\Prototipo de Recursos Humanos\Resources\pngadmin.PNG")
            {
                //cambio para admin 
                lbl_colaboradores.Text = "10";
                lbl_satisfaccion.Text = "Muy Alta";
                lbl_asistencia.Text = "Muy alta";
                lbl_departamento.Text = "Administracion";

            }

            if (ptb_info.ImageLocation == @"E:\trabajo de SARH\Prototipo de Recursos Humanos\Prototipo de Recursos Humanos\Resources\pngrrhh.PNG")
            {
                //cambio para rrhh
                lbl_colaboradores.Text = "8";
                lbl_satisfaccion.Text = "Media";
                lbl_asistencia.Text = "Alta";
                lbl_departamento.Text = "Recursos Humanos";

            }

            if (ptb_info.ImageLocation == @"\Prototipo de Recursos Humanos\Prototipo de Recursos Humanos\Resources\pngsistemas.PNG")
            {

                lbl_colaboradores.Text = "15";
                lbl_satisfaccion.Text = "Muy Alta";
                lbl_asistencia.Text = "Alta";
                lbl_departamento.Text = "Sistemas";

            }

            if (ptb_info.ImageLocation == @"E:\trabajo de SARH\Prototipo de Recursos Humanos\Prototipo de Recursos Humanos\Resources\pngventas.PNG")
            {

                lbl_colaboradores.Text = "7";
                lbl_satisfaccion.Text = "baja";
                lbl_asistencia.Text = "Muy Baja";
                lbl_departamento.Text = "Ventas";
                btn_atras3.Show();
            }


        }

        private void btn_atras3_Click(object sender, EventArgs e)
        {
            obj_presentacion.cambio_atras(ptb_info);

            if (ptb_info.ImageLocation == @"E:\trabajo de SARH\Prototipo de Recursos Humanos\Prototipo de Recursos Humanos\Resources\pngproduccion.PNG")
            {
                //cambio para Produccion
                lbl_colaboradores.Text = "23";
                lbl_satisfaccion.Text = "Muy Alta";
                lbl_asistencia.Text = "Media";
                lbl_departamento.Text = "Produccion";

            }
            if (ptb_info.ImageLocation == @"E:\trabajo de SARH\Prototipo de Recursos Humanos\Prototipo de Recursos Humanos\Resources\pngadmin.PNG")
            {
                //cambio para admin 
                lbl_colaboradores.Text = "10";
                lbl_satisfaccion.Text = "Muy Alta";
                lbl_asistencia.Text = "Muy alta";
                lbl_departamento.Text = "Administracion";

            }

            if (ptb_info.ImageLocation == @"E:\trabajo de SARH\Prototipo de Recursos Humanos\Prototipo de Recursos Humanos\Resources\pngrrhh.PNG")
            {
                //cambio para rrhh
                lbl_colaboradores.Text = "8";
                lbl_satisfaccion.Text = "Media";
                lbl_asistencia.Text = "Alta";
                lbl_departamento.Text = "Recursos Humanos";

            }

            if (ptb_info.ImageLocation == @"\Prototipo de Recursos Humanos\Prototipo de Recursos Humanos\Resources\pngsistemas.PNG")
            {

                lbl_colaboradores.Text = "15";
                lbl_satisfaccion.Text = "Muy Alta";
                lbl_asistencia.Text = "Alta";
                lbl_departamento.Text = "Sistemas";

            }

            if (ptb_info.ImageLocation == @"E:\trabajo de SARH\Prototipo de Recursos Humanos\Prototipo de Recursos Humanos\Resources\pngventas.PNG")
            {

                lbl_colaboradores.Text = "7";
                lbl_satisfaccion.Text = "baja";
                lbl_asistencia.Text = "Muy Baja";
                lbl_departamento.Text = "Ventas";

            }

            
            

        }

        private void Form_departamentos_Load(object sender, EventArgs e)
        {
            btn_atras3.Hide();
        }
    }
}

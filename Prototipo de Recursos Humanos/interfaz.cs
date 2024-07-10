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
    public partial class interfaz : Form
    {
        public interfaz()
        {
            InitializeComponent();
            CustomDesing();
        }

        private void btn_salir2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CustomDesing()
        {
            pnl_submenu_administracion.Visible = false;
            pnl_submenu_registro.Visible = false;
            pnl_submenu_evaluacion.Visible = false;
            pnl_submenu_informacion.Visible = false;
            //..
        }

        private void HideSubMenu()
        {
            if (pnl_submenu_administracion.Visible == true)
                pnl_submenu_administracion.Visible = false;

            if (pnl_submenu_registro.Visible == true)
                pnl_submenu_registro.Visible = false;

            if (pnl_submenu_evaluacion.Visible == true)
                pnl_submenu_evaluacion.Visible = false;

            if (pnl_submenu_informacion.Visible == true)
                pnl_submenu_informacion.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btn_administracion_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnl_submenu_administracion); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openForm(new Form_empleados());
            //---
            HideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openForm(new Form_vacaciones());
            //---
            HideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openForm(new Form_permisos());
            //---
            HideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openForm(new Form_asistencia());
            //---
            HideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openForm(new Form_horastrab());
            //---
            HideSubMenu();
        }

        private void btn_informacion_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnl_submenu_registro);
        }

        private void btn_registroinss_Click(object sender, EventArgs e)
        {
            openForm(new Form_inss());
            //---
            HideSubMenu();

        }

        private void btn_evaluacion_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnl_submenu_evaluacion);
        }

        private void btn_evaluadesempeño_Click(object sender, EventArgs e)
        {
            openForm(new Form_evaluacion());
            //---
            HideSubMenu();
        }

        private void btn_informacion_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(pnl_submenu_informacion);
        }

        private void btn_departamento_Click(object sender, EventArgs e)
        {
            openForm(new Form_departamentos());
            //---
            HideSubMenu();
        }

        private void btn_puesto_Click(object sender, EventArgs e)
        {
            openForm(new Form_puestos());
            //---
            HideSubMenu();
        }

        private void btn_acerempresa_Click(object sender, EventArgs e)
        {
            openForm(new Form_acerca());
            //---
            HideSubMenu();
        }

        private void btn_sarh_Click(object sender, EventArgs e)
        {
            openForm(new Form_acercasarh());
            //---
            HideSubMenu();
        }

        //Almacenar el forulario que se abre, cuando se cierre otro
        private Form activeform = null;
        //abrir formulario en el pnl_contenedor, si ya existiera uno abierto este lo cierra
        private void openForm(Form Formhijo)
        {
            //si hay un fomuario abierto este lo cierra
            if (activeform != null)
                activeform.Close();
            activeform = Formhijo;
            Formhijo.TopLevel = false;
            Formhijo.FormBorderStyle = FormBorderStyle.None;
            Formhijo.Dock = DockStyle.Fill;
            pnl_contenedor.Controls.Add(Formhijo);
            pnl_contenedor.Tag = Formhijo;
            //Formhijo.BringToFront();
            Formhijo.Show();
        }

    }
}

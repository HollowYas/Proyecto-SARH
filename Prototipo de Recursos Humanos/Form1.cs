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
    public partial class form_login : Form
    {
        String Contra = "admin";
        String Usuario = "admin";

        public form_login()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_usuario.Text!= Usuario || txt_password.Text != Contra)
            {

                if (txt_usuario.Text != Usuario)
                {
                    MessageBox.Show("Nombre de Usuario no Valido","Credenciales incorrectas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_usuario.Clear();
                    txt_usuario.Focus();
                    return;
                }

                if (txt_password.Text != Contra)
                {
                    MessageBox.Show("Contraseña incorrecta", "Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_password.Clear();
                    txt_password.Focus();
                    return;
                }


            }
            else
            {
                txt_password.Text = "";
                txt_usuario.Text = "";
                Form forminterfaz = new interfaz();
                forminterfaz.Show();

                this.Hide();

            }

            
        }

        private void ptb_ocultar_Click(object sender, EventArgs e)
        {
            //Traer la imagen de mostrar al frente
            ptb_mostrar.BringToFront();
            //Mostramos la contraseña
            txt_password.PasswordChar = '\0';
        }

        private void ptb_mostrar_Click(object sender, EventArgs e)
        {

            //Traer al frente la imagen de ocultar
            ptb_ocultar.BringToFront();
            //Ocultamos la contraseña
            txt_password.PasswordChar = '▓';
        }


    }
}


namespace Prototipo_de_Recursos_Humanos
{
    partial class form_login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_login));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_usuario = new System.Windows.Forms.Panel();
            this.pnl_password = new System.Windows.Forms.Panel();
            this.ptb_ocultar = new System.Windows.Forms.PictureBox();
            this.ptb_mostrar = new System.Windows.Forms.PictureBox();
            this.pnl_boton = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnl_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_usuario.SuspendLayout();
            this.pnl_password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ocultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_mostrar)).BeginInit();
            this.pnl_boton.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(473, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_salir
            // 
            this.btn_salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(23, 22);
            this.btn_salir.Text = "btn_salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(59, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(36, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONTRASEÑA";
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(224)))), ((int)(((byte)(210)))));
            this.txt_usuario.Font = new System.Drawing.Font("Gilroy Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_usuario.Location = new System.Drawing.Point(191, 72);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(125, 22);
            this.txt_usuario.TabIndex = 4;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(224)))), ((int)(((byte)(210)))));
            this.txt_password.Font = new System.Drawing.Font("Gilroy Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(191, 63);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '░';
            this.txt_password.Size = new System.Drawing.Size(120, 22);
            this.txt_password.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(196)))), ((int)(((byte)(213)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(253)))), ((int)(((byte)(225)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "INGRESAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(50, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 113);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(50, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 87);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(105)))), ((int)(((byte)(144)))));
            this.panel1.Controls.Add(this.pnl_logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 112);
            this.panel1.TabIndex = 12;
            // 
            // pnl_logo
            // 
            this.pnl_logo.Controls.Add(this.pictureBox1);
            this.pnl_logo.Location = new System.Drawing.Point(133, 3);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(193, 123);
            this.pnl_logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_usuario
            // 
            this.pnl_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(105)))), ((int)(((byte)(144)))));
            this.pnl_usuario.Controls.Add(this.pictureBox2);
            this.pnl_usuario.Controls.Add(this.label1);
            this.pnl_usuario.Controls.Add(this.txt_usuario);
            this.pnl_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_usuario.Location = new System.Drawing.Point(0, 137);
            this.pnl_usuario.Name = "pnl_usuario";
            this.pnl_usuario.Size = new System.Drawing.Size(473, 176);
            this.pnl_usuario.TabIndex = 13;
            // 
            // pnl_password
            // 
            this.pnl_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(105)))), ((int)(((byte)(144)))));
            this.pnl_password.Controls.Add(this.txt_password);
            this.pnl_password.Controls.Add(this.label2);
            this.pnl_password.Controls.Add(this.pictureBox3);
            this.pnl_password.Controls.Add(this.ptb_ocultar);
            this.pnl_password.Controls.Add(this.ptb_mostrar);
            this.pnl_password.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_password.Location = new System.Drawing.Point(0, 313);
            this.pnl_password.Name = "pnl_password";
            this.pnl_password.Size = new System.Drawing.Size(473, 170);
            this.pnl_password.TabIndex = 14;
            // 
            // ptb_ocultar
            // 
            this.ptb_ocultar.Image = ((System.Drawing.Image)(resources.GetObject("ptb_ocultar.Image")));
            this.ptb_ocultar.Location = new System.Drawing.Point(348, 50);
            this.ptb_ocultar.Name = "ptb_ocultar";
            this.ptb_ocultar.Size = new System.Drawing.Size(48, 48);
            this.ptb_ocultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptb_ocultar.TabIndex = 10;
            this.ptb_ocultar.TabStop = false;
            this.ptb_ocultar.Click += new System.EventHandler(this.ptb_ocultar_Click);
            // 
            // ptb_mostrar
            // 
            this.ptb_mostrar.Image = ((System.Drawing.Image)(resources.GetObject("ptb_mostrar.Image")));
            this.ptb_mostrar.Location = new System.Drawing.Point(348, 52);
            this.ptb_mostrar.Name = "ptb_mostrar";
            this.ptb_mostrar.Size = new System.Drawing.Size(48, 48);
            this.ptb_mostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptb_mostrar.TabIndex = 9;
            this.ptb_mostrar.TabStop = false;
            this.ptb_mostrar.Click += new System.EventHandler(this.ptb_mostrar_Click);
            // 
            // pnl_boton
            // 
            this.pnl_boton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(91)))), ((int)(((byte)(105)))));
            this.pnl_boton.Controls.Add(this.button1);
            this.pnl_boton.Location = new System.Drawing.Point(159, 510);
            this.pnl_boton.Name = "pnl_boton";
            this.pnl_boton.Size = new System.Drawing.Size(134, 59);
            this.pnl_boton.TabIndex = 15;
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(105)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(473, 581);
            this.Controls.Add(this.pnl_boton);
            this.Controls.Add(this.pnl_password);
            this.Controls.Add(this.pnl_usuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnl_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_usuario.ResumeLayout(false);
            this.pnl_usuario.PerformLayout();
            this.pnl_password.ResumeLayout(false);
            this.pnl_password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ocultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_mostrar)).EndInit();
            this.pnl_boton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_usuario;
        private System.Windows.Forms.Panel pnl_password;
        private System.Windows.Forms.Panel pnl_logo;
        private System.Windows.Forms.Panel pnl_boton;
        private System.Windows.Forms.PictureBox ptb_ocultar;
        private System.Windows.Forms.PictureBox ptb_mostrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


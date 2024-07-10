
namespace Prototipo_de_Recursos_Humanos
{
    partial class Form_puestos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_gerente = new System.Windows.Forms.Button();
            this.btn_colaborador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_puesto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_gerente
            // 
            this.btn_gerente.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerente.Location = new System.Drawing.Point(93, 78);
            this.btn_gerente.Name = "btn_gerente";
            this.btn_gerente.Size = new System.Drawing.Size(114, 76);
            this.btn_gerente.TabIndex = 0;
            this.btn_gerente.Text = "Gerente";
            this.btn_gerente.UseVisualStyleBackColor = true;
            this.btn_gerente.Click += new System.EventHandler(this.btn_gerente_Click);
            // 
            // btn_colaborador
            // 
            this.btn_colaborador.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_colaborador.Location = new System.Drawing.Point(376, 78);
            this.btn_colaborador.Name = "btn_colaborador";
            this.btn_colaborador.Size = new System.Drawing.Size(137, 86);
            this.btn_colaborador.TabIndex = 1;
            this.btn_colaborador.Text = "Colaborador";
            this.btn_colaborador.UseVisualStyleBackColor = true;
            this.btn_colaborador.Click += new System.EventHandler(this.btn_colaborador_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Puestos Activos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Puestos Disponibles:";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(373, 250);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(53, 18);
            this.lbl_cantidad.TabIndex = 4;
            this.lbl_cantidad.Text = "-----";
            // 
            // lbl_puesto
            // 
            this.lbl_puesto.AutoSize = true;
            this.lbl_puesto.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_puesto.Location = new System.Drawing.Point(373, 315);
            this.lbl_puesto.Name = "lbl_puesto";
            this.lbl_puesto.Size = new System.Drawing.Size(53, 18);
            this.lbl_puesto.TabIndex = 5;
            this.lbl_puesto.Text = "-----";
            // 
            // Form_puestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(604, 461);
            this.Controls.Add(this.lbl_puesto);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_colaborador);
            this.Controls.Add(this.btn_gerente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_puestos";
            this.Text = "Form_puestos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gerente;
        private System.Windows.Forms.Button btn_colaborador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_puesto;
    }
}
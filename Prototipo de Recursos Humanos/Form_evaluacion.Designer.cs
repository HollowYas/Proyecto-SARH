
namespace Prototipo_de_Recursos_Humanos
{
    partial class Form_evaluacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_tabla = new System.Windows.Forms.Button();
            this.lbl_area = new System.Windows.Forms.Label();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.cbx_area = new System.Windows.Forms.ComboBox();
            this.cbx_cargo = new System.Windows.Forms.ComboBox();
            this.lstbx_empleados2 = new System.Windows.Forms.ListBox();
            this.btn_lista = new System.Windows.Forms.Button();
            this.dgv_desempeño = new System.Windows.Forms.DataGridView();
            this.btn_regreso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_desempeño)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_tabla
            // 
            this.btn_tabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.btn_tabla.Font = new System.Drawing.Font("Gilroy Light", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tabla.Location = new System.Drawing.Point(425, 7);
            this.btn_tabla.Name = "btn_tabla";
            this.btn_tabla.Size = new System.Drawing.Size(116, 56);
            this.btn_tabla.TabIndex = 0;
            this.btn_tabla.Text = "Mostrar Tabla Desempeño";
            this.btn_tabla.UseVisualStyleBackColor = false;
            this.btn_tabla.Click += new System.EventHandler(this.btn_tabla_Click);
            // 
            // lbl_area
            // 
            this.lbl_area.AutoSize = true;
            this.lbl_area.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_area.Font = new System.Drawing.Font("Gilroy Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_area.Location = new System.Drawing.Point(25, 27);
            this.lbl_area.Name = "lbl_area";
            this.lbl_area.Size = new System.Drawing.Size(182, 15);
            this.lbl_area.TabIndex = 1;
            this.lbl_area.Text = "DEPARTAMENTO DE TRABAJO";
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_cargo.Font = new System.Drawing.Font("Gilroy Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargo.Location = new System.Drawing.Point(268, 27);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(54, 15);
            this.lbl_cargo.TabIndex = 2;
            this.lbl_cargo.Text = "CARGO";
            // 
            // cbx_area
            // 
            this.cbx_area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(224)))), ((int)(((byte)(210)))));
            this.cbx_area.Font = new System.Drawing.Font("Gilroy Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_area.FormattingEnabled = true;
            this.cbx_area.Items.AddRange(new object[] {
            "Recursos Humanos",
            "Sistemas",
            "Administracion",
            "Produccion",
            "Ventas"});
            this.cbx_area.Location = new System.Drawing.Point(45, 69);
            this.cbx_area.Name = "cbx_area";
            this.cbx_area.Size = new System.Drawing.Size(121, 21);
            this.cbx_area.TabIndex = 3;
            // 
            // cbx_cargo
            // 
            this.cbx_cargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.cbx_cargo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_cargo.Font = new System.Drawing.Font("Gilroy Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_cargo.FormattingEnabled = true;
            this.cbx_cargo.Items.AddRange(new object[] {
            "Gerente",
            "Trabajador"});
            this.cbx_cargo.Location = new System.Drawing.Point(234, 69);
            this.cbx_cargo.Name = "cbx_cargo";
            this.cbx_cargo.Size = new System.Drawing.Size(121, 21);
            this.cbx_cargo.TabIndex = 4;
            // 
            // lstbx_empleados2
            // 
            this.lstbx_empleados2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(155)))), ((int)(((byte)(206)))));
            this.lstbx_empleados2.Font = new System.Drawing.Font("Gilroy Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbx_empleados2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lstbx_empleados2.FormattingEnabled = true;
            this.lstbx_empleados2.ItemHeight = 17;
            this.lstbx_empleados2.Location = new System.Drawing.Point(63, 175);
            this.lstbx_empleados2.Name = "lstbx_empleados2";
            this.lstbx_empleados2.Size = new System.Drawing.Size(456, 157);
            this.lstbx_empleados2.TabIndex = 5;
            // 
            // btn_lista
            // 
            this.btn_lista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.btn_lista.Font = new System.Drawing.Font("Gilroy Light", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lista.Location = new System.Drawing.Point(425, 69);
            this.btn_lista.Name = "btn_lista";
            this.btn_lista.Size = new System.Drawing.Size(116, 44);
            this.btn_lista.TabIndex = 6;
            this.btn_lista.Text = "Mostrar lista de empleados";
            this.btn_lista.UseVisualStyleBackColor = false;
            this.btn_lista.Click += new System.EventHandler(this.btn_lista_Click);
            // 
            // dgv_desempeño
            // 
            this.dgv_desempeño.AllowUserToDeleteRows = false;
            this.dgv_desempeño.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(155)))), ((int)(((byte)(206)))));
            this.dgv_desempeño.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_desempeño.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_desempeño.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(224)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gilroy ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_desempeño.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_desempeño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_desempeño.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(155)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rhizome Demi Trial", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(224)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_desempeño.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_desempeño.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(155)))), ((int)(((byte)(206)))));
            this.dgv_desempeño.Location = new System.Drawing.Point(28, 146);
            this.dgv_desempeño.Name = "dgv_desempeño";
            this.dgv_desempeño.Size = new System.Drawing.Size(564, 281);
            this.dgv_desempeño.TabIndex = 7;
            this.dgv_desempeño.Visible = false;
            // 
            // btn_regreso
            // 
            this.btn_regreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.btn_regreso.Font = new System.Drawing.Font("Gilroy Light", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regreso.Location = new System.Drawing.Point(425, 7);
            this.btn_regreso.Name = "btn_regreso";
            this.btn_regreso.Size = new System.Drawing.Size(116, 56);
            this.btn_regreso.TabIndex = 8;
            this.btn_regreso.Text = "Regresar ";
            this.btn_regreso.UseVisualStyleBackColor = false;
            this.btn_regreso.Click += new System.EventHandler(this.btn_regreso_Click);
            // 
            // Form_evaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(604, 461);
            this.Controls.Add(this.lstbx_empleados2);
            this.Controls.Add(this.btn_lista);
            this.Controls.Add(this.cbx_cargo);
            this.Controls.Add(this.cbx_area);
            this.Controls.Add(this.lbl_cargo);
            this.Controls.Add(this.lbl_area);
            this.Controls.Add(this.btn_tabla);
            this.Controls.Add(this.btn_regreso);
            this.Controls.Add(this.dgv_desempeño);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_evaluacion";
            this.Text = "Form_evaluacion";
            this.Load += new System.EventHandler(this.Form_evaluacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_desempeño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tabla;
        private System.Windows.Forms.Label lbl_area;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.ComboBox cbx_area;
        private System.Windows.Forms.ComboBox cbx_cargo;
        private System.Windows.Forms.ListBox lstbx_empleados2;
        private System.Windows.Forms.Button btn_lista;
        private System.Windows.Forms.DataGridView dgv_desempeño;
        private System.Windows.Forms.Button btn_regreso;
    }
}
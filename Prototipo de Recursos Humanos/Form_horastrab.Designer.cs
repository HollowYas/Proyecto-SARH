
namespace Prototipo_de_Recursos_Humanos
{
    partial class Form_horastrab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_horastrab));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lstb_area = new System.Windows.Forms.ListBox();
            this.lstb_cargo = new System.Windows.Forms.ListBox();
            this.pnl_busqueda = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.ptb_empleados = new System.Windows.Forms.PictureBox();
            this.dgv_horas = new System.Windows.Forms.DataGridView();
            this.pnl_busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_empleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horas)).BeginInit();
            this.SuspendLayout();
            // 
            // lstb_area
            // 
            this.lstb_area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(105)))), ((int)(((byte)(144)))));
            this.lstb_area.ForeColor = System.Drawing.SystemColors.Window;
            this.lstb_area.FormattingEnabled = true;
            this.lstb_area.Items.AddRange(new object[] {
            "Recursos Humanos",
            "Sistemas",
            "Administracion",
            "Produccion",
            "Ventas"});
            this.lstb_area.Location = new System.Drawing.Point(17, 37);
            this.lstb_area.Name = "lstb_area";
            this.lstb_area.Size = new System.Drawing.Size(120, 30);
            this.lstb_area.TabIndex = 0;
            // 
            // lstb_cargo
            // 
            this.lstb_cargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(91)))), ((int)(((byte)(105)))));
            this.lstb_cargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstb_cargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstb_cargo.ForeColor = System.Drawing.SystemColors.Info;
            this.lstb_cargo.FormattingEnabled = true;
            this.lstb_cargo.Items.AddRange(new object[] {
            "Gerente",
            "Trabajador"});
            this.lstb_cargo.Location = new System.Drawing.Point(187, 37);
            this.lstb_cargo.Name = "lstb_cargo";
            this.lstb_cargo.Size = new System.Drawing.Size(120, 26);
            this.lstb_cargo.TabIndex = 1;
            this.lstb_cargo.TabStop = false;
            // 
            // pnl_busqueda
            // 
            this.pnl_busqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_busqueda.Controls.Add(this.label2);
            this.pnl_busqueda.Controls.Add(this.label1);
            this.pnl_busqueda.Controls.Add(this.lstb_area);
            this.pnl_busqueda.Controls.Add(this.btn_buscar);
            this.pnl_busqueda.Controls.Add(this.lstb_cargo);
            this.pnl_busqueda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_busqueda.Location = new System.Drawing.Point(12, 12);
            this.pnl_busqueda.Name = "pnl_busqueda";
            this.pnl_busqueda.Size = new System.Drawing.Size(580, 174);
            this.pnl_busqueda.TabIndex = 3;
            this.pnl_busqueda.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_busqueda_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cargo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Area de Trabajo";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(91)))), ((int)(((byte)(105)))));
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(105)))), ((int)(((byte)(144)))));
            this.btn_buscar.FlatAppearance.BorderSize = 3;
            this.btn_buscar.Font = new System.Drawing.Font("Gilroy Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(410, 73);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(130, 72);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // ptb_empleados
            // 
            this.ptb_empleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_empleados.Image = ((System.Drawing.Image)(resources.GetObject("ptb_empleados.Image")));
            this.ptb_empleados.Location = new System.Drawing.Point(398, 213);
            this.ptb_empleados.Name = "ptb_empleados";
            this.ptb_empleados.Size = new System.Drawing.Size(182, 181);
            this.ptb_empleados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_empleados.TabIndex = 4;
            this.ptb_empleados.TabStop = false;
            // 
            // dgv_horas
            // 
            this.dgv_horas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(155)))), ((int)(((byte)(206)))));
            this.dgv_horas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_horas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_horas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_horas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(155)))), ((int)(((byte)(206)))));
            this.dgv_horas.Location = new System.Drawing.Point(21, 204);
            this.dgv_horas.Name = "dgv_horas";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gilroy Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(196)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_horas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_horas.Size = new System.Drawing.Size(362, 213);
            this.dgv_horas.TabIndex = 5;
            // 
            // Form_horastrab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(253)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(604, 461);
            this.Controls.Add(this.dgv_horas);
            this.Controls.Add(this.ptb_empleados);
            this.Controls.Add(this.pnl_busqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_horastrab";
            this.Text = "Form_horastrab";
            this.pnl_busqueda.ResumeLayout(false);
            this.pnl_busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_empleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstb_area;
        private System.Windows.Forms.ListBox lstb_cargo;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Panel pnl_busqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptb_empleados;
        private System.Windows.Forms.DataGridView dgv_horas;
    }
}
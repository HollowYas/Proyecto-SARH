using Microsoft.Reporting.WinForms;
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


    public partial class Form_reportview : Form
    {
        public List<Class_datreporte> datreportes = new List<Class_datreporte>();

        public Form_reportview()
        {
            InitializeComponent();
        }

        private void Form_reportview_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1",datreportes));
            this.reportViewer1.RefreshReport();
        }
    }
}

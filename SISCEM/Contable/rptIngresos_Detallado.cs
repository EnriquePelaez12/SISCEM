using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SISCEM
{
    public partial class rptIngresos_Detallado : Form
    {

        public string FecIni { set; get; }
        public string FecFin { set; get; }
        public string FechaIni { set; get; }
        public string FechaFin { set; get; }

        public rptIngresos_Detallado()
        {
            InitializeComponent();
        }

        private void rptIngresos_Detallado_Load(object sender, EventArgs e)
        {
            this.Ingresos_DetalladoTableAdapter.Fill(this.PRESTODataSet.Ingresos_Detallado, FecIni, FecFin);
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("FechaIni", FechaIni));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("FechaFin", FechaFin));
            this.reportViewer1.RefreshReport();
        }
    }
}

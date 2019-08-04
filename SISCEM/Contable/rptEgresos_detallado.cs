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
    public partial class rptEgresos_detallado : Form
    {
        public string FecIni { set; get; }
        public string FecFin { set; get; }
        public string FechaIni { set; get; }
        public string FechaFin { set; get; }

        public rptEgresos_detallado()
        {
            InitializeComponent();
        }

        private void rptEgresos_detallado_Load(object sender, EventArgs e)
        {
            this.Egresos_detalladoTableAdapter.Fill(this.PRESTODataSet.Egresos_detallado, FecIni, FecFin);
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("FechaIni", FechaIni));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("FechaFin", FechaFin));
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}

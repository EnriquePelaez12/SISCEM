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
    public partial class rptRefrendo_Detallado : Form
    {
        public string FecIni { set; get; }
        public string FecFin { set; get; }
        public string FechaIni { set; get; }
        public string FechaFin { set; get; }

        public rptRefrendo_Detallado()
        {
            InitializeComponent();
        }

        private void rptRefrendo_Detallado_Load(object sender, EventArgs e)
        {            
            this.Refrendo_DetalladoTableAdapter.Fill(this.PRESTODataSet.Refrendo_Detallado, FecIni, FecFin);
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("FechaIni", FechaIni));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("FechaFin", FechaIni));
         
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

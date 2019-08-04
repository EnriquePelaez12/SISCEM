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
    public partial class rptdesempenio_detallado : Form
    {
        public string FecIni { set; get; }
        public string FecFin { set; get; }
        public string FechaIni { set; get; }
        public string FechaFin { set; get; }
        
        public rptdesempenio_detallado()
        {
            InitializeComponent();
        }

        private void rptdesempenio_detallado_Load(object sender, EventArgs e)
        {
            
            
            this.Desempenio_detalladoTableAdapter.Fill(this.PRESTODataSet.Desempenio_detallado,FecIni,FecFin);

            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("FechaIni", FechaIni));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("FechaFin", FechaFin));
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

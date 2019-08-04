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
    public partial class rptMovimientoIngreso : Form
    {
        public rptMovimientoIngreso()
        {
            InitializeComponent();
        }
        
        public DateTime FecInicio { set; get; }
        public DateTime FecFin { set; get; }

        private void rptMovimientoIngreso_Load(object sender, EventArgs e)
        {            
            this.IngresosTableAdapter.Fill(this.PRESTODataSet.Ingresos, FecInicio, FecFin);                       
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("rptFechaInicio", FecInicio.ToShortDateString()));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("rptFechaFin", FecFin.ToShortDateString()));
            this.reportViewer1.RefreshReport();            
        }               
    }
}

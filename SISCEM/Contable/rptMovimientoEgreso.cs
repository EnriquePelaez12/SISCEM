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
    public partial class rptMovimientoEgreso : Form
    {
        public rptMovimientoEgreso()
        {
            InitializeComponent();
        }

        public string Tipo { set; get; }
        public DateTime FecInicio { set; get; }
        public DateTime FecFin { set; get; }

        private void rptMovimientoEgreso_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PRESTODataSet.Egresos' table. You can move, or remove it, as needed.
            this.EgresosTableAdapter.Fill(this.PRESTODataSet.Egresos,FecInicio,FecFin);            
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("rptFechaInicio", FecInicio.ToShortDateString()));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("rptFechaFin", FecFin.ToShortDateString()));
            this.reportViewer1.RefreshReport();
        }
    }
}

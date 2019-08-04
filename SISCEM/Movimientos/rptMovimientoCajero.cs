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
    public partial class rptMovimientoCajero : Form
    {
        public rptMovimientoCajero()
        {
            InitializeComponent();
        }
        public int Id { set; get; }
        public string Cajero { set; get; }
        public DateTime FecInicio { set; get; }
        public DateTime FecFin { set; get; }

        private void rptMovimientoCajero_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PRESTODataSet.MovimientoCajero' table. You can move, or remove it, as needed.
            this.MovimientoCajeroTableAdapter.Fill(this.PRESTODataSet.MovimientoCajero,Id, FecInicio, FecFin);
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("rptCajero", Cajero));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("rptFechaInicio", FecInicio.ToShortDateString()));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("rptFechaFin", FecFin.ToShortDateString()));
            this.reportViewer1.RefreshReport();

        }
                   
    }
}

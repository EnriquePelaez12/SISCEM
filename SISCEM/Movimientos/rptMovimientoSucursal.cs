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
    public partial class rptMovimientoSucursal : Form
    {
        public rptMovimientoSucursal()
        {
            InitializeComponent();
        }
        public int Id { set; get; }
        public string Sucursal { set; get; }
        public DateTime FecInicio { set; get; }
        public DateTime FecFin { set; get; }
        
        private void rptMovimientoSucursal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PRESTODataSet.MovimientoSucural' table. You can move, or remove it, as needed.
            this.MovimientoSucuralTableAdapter.Fill(this.PRESTODataSet.MovimientoSucural,Id,FecInicio,FecFin);                       
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("rptSucursal", Sucursal));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("rptFechaInicio", FecInicio.ToShortDateString()));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("rptFechaFin", FecFin.ToShortDateString()));
   
            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class rptRefrendoExtemporaneo : Form
    {
        public rptRefrendoExtemporaneo()
        {
            InitializeComponent();
        }
        public int IdBoleta = 0;
        public string Linea = "1";
        public string refrendo = "";
        private void rptRefrendoExtemporaneo_Load(object sender, EventArgs e)
        {
            this.RefrendoextemporaneoTableAdapter.Fill(this.PRESTODataSet.Refrendoextemporaneo, IdBoleta,Linea);
            // TODO: This line of code loads data into the 'PRESTODataSet.Sucursal' table. You can move, or remove it, as needed.
            this.SucursalTableAdapter.Fill(this.PRESTODataSet.Sucursal, 1);
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Cajero", Program.Usuario));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("refrendo",refrendo));
            this.reportViewer1.RefreshReport();
        }
    }
}

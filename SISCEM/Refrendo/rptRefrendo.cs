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
    public partial class rptRefrendo : Form
    {
        public rptRefrendo()
        {
            InitializeComponent();
        }
        public int IdBoleta = 0;
        public string Total_extra ="0";
        public string Linea = "";
        public string refrendo = "";
        private void rptRefrendo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PRESTODataSet.Refrendo' table. You can move, or remove it, as needed.
            //this.RefrendoTableAdapter.Fill(this.PRESTODataSet.Refrendo, IdBoleta,Linea);
            this.RefrendoTableAdapter.Fill(this.PRESTODataSet.Refrendo, IdBoleta);
            // TODO: This line of code loads data into the 'PRESTODataSet.Sucursal' table. You can move, or remove it, as needed.
            this.SucursalTableAdapter.Fill(this.PRESTODataSet.Sucursal, 1);
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Cajero", Program.Usuario));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("refrendo",refrendo));            
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Total_extra",Total_extra));
            this.reportViewer1.RefreshReport();
        }
    }
}

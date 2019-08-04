using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace SISCEM
{
    public partial class rptPagoRefrendoIlimitado : Form
    {
      public  string cliente ="";
      public  string Prestamo = "";
      public  string almacenaje = "";
      public  string Interes="";
      public  string Iva="";
      public  string Total = "";
      public  string Boleta="";
      public string  Semanas="";
      

        public rptPagoRefrendoIlimitado()
        {
            InitializeComponent();
        }

        private void rptPagoRefrendoIlimitado_Load(object sender, EventArgs e)
        {
              try
            {
                             
                reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("cliente", cliente));
                reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Prestamo", Prestamo));
                reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Boleta", Boleta));
                reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Semanas", Semanas));
                reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Interes", Interes));
                reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Total", Total));
                reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Iva", Iva));
                reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("almacenaje", almacenaje));
                reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Cajero", Program.Usuario));
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Genera r el reporte");
            }

        }
    }
}

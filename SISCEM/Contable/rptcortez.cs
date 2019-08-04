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
    public partial class rptcortez : Form
    {
        public rptcortez()
        {
            InitializeComponent();
        }

        public string Empenio = "";
        public string Desempenio = "";
        public string Ventas = "";
        public string Refrendo = "";
        public string Ingresos = "";
        public string Egresos = "";
        public string Utilidad = "";

        private void rptcortez_Load(object sender, EventArgs e)
        {
            try
            {
                rpvcortez.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Empenio", Empenio));
                rpvcortez.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Desempenio", Desempenio));
                rpvcortez.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Ventas", Ventas));
                rpvcortez.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Refrendo", Refrendo));
                rpvcortez.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Ingresos", Ingresos));
                rpvcortez.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Egresos", Egresos));
                rpvcortez.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Utilidad", Utilidad));
                this.rpvcortez.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Genera r el reporte");
            }

        }
    }
}

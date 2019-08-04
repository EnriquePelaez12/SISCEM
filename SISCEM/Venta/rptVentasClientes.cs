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
    public partial class rptVentasClientes : Form
    {
        public rptVentasClientes()
        {
            InitializeComponent();
        }

        public int Cliente_Id = -1;
        public DateTime FechaInicio;
        public DateTime FechaFin;
        private void rptVentasClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PRESTODataSet.ReporteVenta' table. You can move, or remove it, as needed.
            if (Cliente_Id == -1)
                this.ReporteVentaTableAdapter.Fill(this.PRESTODataSet.ReporteVenta, FechaInicio, FechaFin);
            else
                this.ReporteVentaTableAdapter.FillBy(this.PRESTODataSet.ReporteVenta, FechaInicio, FechaFin, Cliente_Id);
            this.reportViewer1.RefreshReport();
        }
    }
}

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
    public partial class rptEmpenioClientes : Form
    {
        public rptEmpenioClientes()
        {
            InitializeComponent();
        }

        public int Cliente_Id = -1;
        public DateTime FechaInicio;
        public DateTime FechaFin;

        private void rptEmpenioClientes_Load(object sender, EventArgs e)
        { // TODO: This line of code loads data into the 'PRESTODataSet.ReporteEmpenio' table. You can move, or remove it, as needed.
            if (Cliente_Id == -1)
                this.ReporteEmpenioTableAdapter.FillBy(this.PRESTODataSet.ReporteEmpenio, FechaInicio, FechaFin);
            else
                this.ReporteEmpenioTableAdapter.Fill(this.PRESTODataSet.ReporteEmpenio, Cliente_Id, FechaInicio, FechaFin);
            this.reportViewer1.RefreshReport();

        }

    }
}

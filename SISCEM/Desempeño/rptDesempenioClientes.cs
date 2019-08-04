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
    public partial class rptDesempenioClientes : Form
    {
        public rptDesempenioClientes()
        {
            InitializeComponent();
        }

        public int Cliente_Id = -1;
        public DateTime FechaInicio;
        public DateTime FechaFin;


        private void rptDesempenioClientes_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'PRESTODataSet.ReporteDesempenio' table. You can move, or remove it, as needed.
            if (Cliente_Id == -1)
                this.ReporteDesempenioTableAdapter.FillBy(this.PRESTODataSet.ReporteDesempenio, FechaInicio, FechaFin);
            else
                this.ReporteDesempenioTableAdapter.Fill(this.PRESTODataSet.ReporteDesempenio, Cliente_Id, FechaInicio, FechaFin);
            this.reportViewer1.RefreshReport();
        }
        
    }
}

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
    public partial class rptDesgloseBoleta : Form
    {
        public rptDesgloseBoleta()
        {
            InitializeComponent();
        }
        public int IdBoleta = 0;
        private void rptDesgloseBoleta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PRESTODataSet.Desglose_Boleta' table. You can move, or remove it, as needed.
            this.Desglose_BoletaTableAdapter.Fill(this.PRESTODataSet.Desglose_Boleta, IdBoleta);

            this.reportViewer1.RefreshReport();
        }
    }
}

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
    public partial class Desempeniorpt : Form
    {
        private static Desempeniorpt m_FormDefInstanceDesempeniorpt;
        public int IdBoleta = 0;
        public string linea = "";
        public short IdSucursal = 1;
        public static Desempeniorpt DefInstance
        {
            get
            {
                if (m_FormDefInstanceDesempeniorpt == null || m_FormDefInstanceDesempeniorpt.IsDisposed)
                    m_FormDefInstanceDesempeniorpt = new Desempeniorpt();
                return m_FormDefInstanceDesempeniorpt;
            }
            set
            {
                m_FormDefInstanceDesempeniorpt = value;
            }
        }

        public Desempeniorpt()
        {
            InitializeComponent();
        }

        private void rptvdesempenio_Load(object sender, EventArgs e)
        {
            this.rptvdesempenio.RefreshReport();
        }

        private void Desempeniorpt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PRESTODataSet.Desempenio_Detalle' table. You can move, or remove it, as needed.
            this.Desempenio_DetalleTableAdapter.Fill(this.PRESTODataSet.Desempenio_Detalle, IdBoleta);
            // TODO: This line of code loads data into the 'PRESTODataSet.Sucursal' table. You can move, or remove it, as needed.
            this.SucursalTableAdapter.Fill(this.PRESTODataSet.Sucursal, IdSucursal);
            // TODO: This line of code loads data into the 'PRESTODataSet.Desempenio' table. You can move, or remove it, as needed.
            this.DesempenioTableAdapter.Fill(this.PRESTODataSet.Desempenio, IdBoleta,linea);

            rptvdesempenio.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Cajero", Program.Usuario));
            rptvdesempenio.RefreshReport();
        }
    }
}

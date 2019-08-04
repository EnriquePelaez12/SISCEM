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
    public partial class Ventarpt : Form
    {
        private static Ventarpt m_FormDefInstanceVentarpt;
        public int codigo = 0;
        public short IdSucursal = 1;
        public int Cliente = 0;
        public string Total = "";
        public static Ventarpt DefInstance
        {
            get
            {
                if (m_FormDefInstanceVentarpt == null || m_FormDefInstanceVentarpt.IsDisposed)
                    m_FormDefInstanceVentarpt = new Ventarpt();
                return m_FormDefInstanceVentarpt;
            }
            set
            {
                m_FormDefInstanceVentarpt = value;
            }
        }
        

        public Ventarpt()
        {
            InitializeComponent();
        }

        private void Ventarpt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PRESTODataSet.Desglose_Boleta' table. You can move, or remove it, as needed.
            //this.Desglose_BoletaTableAdapter.Fill(this.PRESTODataSet.Desglose_Boleta,);
            // TODO: This line of code loads data into the 'PRESTODataSet.Desglose_Boleta1' table. You can move, or remove it, as needed.
            this.Desglose_Boleta1TableAdapter.Fill(this.PRESTODataSet.Desglose_Boleta1,codigo);
            rptventa.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Total",Total));
            // TODO: This line of code loads data into the 'PRESTODataSet.Cliente' table. You can move, or remove it, as needed.
            this.ClienteTableAdapter.Fill(this.PRESTODataSet.Cliente,Cliente);          
               // TODO: This line of code loads data into the 'PRESTODataSet.Sucursal' table. You can move, or remove it, as needed.
            this.SucursalTableAdapter.Fill(this.PRESTODataSet.Sucursal, IdSucursal);
            // TODO: This line of code loads data into the 'PRESTODataSet.Desempenio' table. You can move, or remove it, as needed.
            //this.Desglose_BoletaTableAdapter.Fill(this.PRESTODataSet.Desglose_Boleta,codigo);
            //this.Desglose_BoletaTableAdapter.Fill(this.PRESTODataSet.Desglose_Boleta,)
            //rptventa.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Cajero", "Prueba de Cajero"));
            rptventa.RefreshReport();
        }
        
    }
}

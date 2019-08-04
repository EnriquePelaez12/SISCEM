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
    public partial class ReportesClientes : Form
    {
        public ReportesClientes()
        {
            InitializeComponent();

        }
        private static ReportesClientes m_FormDefInstanceReportesClientes;

        public static ReportesClientes DefInstance
        {
            get
            {
                if (m_FormDefInstanceReportesClientes == null || m_FormDefInstanceReportesClientes.IsDisposed)
                    m_FormDefInstanceReportesClientes = new ReportesClientes();
                return m_FormDefInstanceReportesClientes;
            }
            set
            {
                m_FormDefInstanceReportesClientes = value;
            }
        }


        private void ReportesClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem == null ||
               cmbTipoReporte.SelectedItem == null)
                MessageBox.Show("Debe seleccionar todos los filtros");
            else
            {
                if (cmbCliente.SelectedItem.ToString() == "Individual" && txtClienteId.Text == "")
                {
                    MessageBox.Show("Debe introducir un Id de Cliente");
                    txtClienteId.Focus();
                }
                else
                {
                    switch (cmbTipoReporte.SelectedItem.ToString())
                    {
                        case "Ventas":
                            rptVentasClientes frmVC = new rptVentasClientes();
                            if (cmbCliente.SelectedItem.ToString() == "Individual")
                                frmVC.Cliente_Id = Convert.ToInt32(txtClienteId.Text);
                            frmVC.FechaInicio = dtpFechaInicio.Value;
                            frmVC.FechaFin = dtpFechaFin.Value;
                            frmVC.ShowDialog(this);
                            frmVC.Dispose();
                            break;
                        case "Empeños":
                            rptEmpenioClientes frmEC = new rptEmpenioClientes();
                            if (cmbCliente.SelectedItem.ToString() == "Individual")
                             frmEC.Cliente_Id = Convert.ToInt32(txtClienteId.Text);
                            frmEC.FechaInicio = dtpFechaInicio.Value;
                            frmEC.FechaFin = dtpFechaFin.Value;
                            frmEC.ShowDialog(this);
                            frmEC.Dispose();
                            break;
                        case "Desempeños":
                            rptDesempenioClientes frmDC = new rptDesempenioClientes();
                            if (cmbCliente.SelectedItem.ToString() == "Individual")
                                frmDC.Cliente_Id = Convert.ToInt32(txtClienteId.Text);
                            frmDC.FechaInicio = dtpFechaInicio.Value;
                            frmDC.FechaFin = dtpFechaFin.Value;
                            frmDC.ShowDialog(this);
                            frmDC.Dispose();
                            break;
                    }
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem == null ||
                cmbTipoReporte.SelectedItem == null)
                MessageBox.Show("Debe seleccionar todos los filtros");
            else
            {
                if (cmbCliente.SelectedItem.ToString() == "Individual" && txtClienteId.Text == "")
                {
                    MessageBox.Show("Debe introducir un Id de Cliente");
                    txtClienteId.Focus();
                }
                else
                {
                    switch (cmbTipoReporte.SelectedItem.ToString())
                    {
                        case "Ventas":
                            PRESTODataSet.ReporteVentaDataTable dtV = new PRESTODataSet.ReporteVentaDataTable();
                            PRESTODataSetTableAdapters.ReporteVentaTableAdapter daV = new PRESTODataSetTableAdapters.ReporteVentaTableAdapter();
                            if (cmbCliente.SelectedItem.ToString() == "Individual")
                                daV.FillBy(dtV, dtpFechaInicio.Value, dtpFechaFin.Value, Convert.ToInt32(txtClienteId.Text));
                            else
                                daV.Fill(dtV, dtpFechaInicio.Value, dtpFechaFin.Value);
                            dgvDatos.DataSource = dtV;
                            btnGenerarReporte.Enabled = true;
                            break;
                        case "Empeños":
                            PRESTODataSet.ReporteEmpenioDataTable dtE = new PRESTODataSet.ReporteEmpenioDataTable();
                            PRESTODataSetTableAdapters.ReporteEmpenioTableAdapter daE = new PRESTODataSetTableAdapters.ReporteEmpenioTableAdapter();
                            if (cmbCliente.SelectedItem.ToString() == "Individual")
                                daE.Fill(dtE, Convert.ToInt32(txtClienteId.Text), dtpFechaInicio.Value, dtpFechaFin.Value);
                            else
                                daE.FillBy(dtE, dtpFechaInicio.Value, dtpFechaFin.Value);
                            dgvDatos.DataSource = dtE;
                            btnGenerarReporte.Enabled = true;
                            break;
                        case "Desempeños":
                            PRESTODataSet.ReporteDesempenioDataTable dtD = new PRESTODataSet.ReporteDesempenioDataTable();
                            PRESTODataSetTableAdapters.ReporteDesempenioTableAdapter daD = new PRESTODataSetTableAdapters.ReporteDesempenioTableAdapter();
                            if (cmbCliente.SelectedItem.ToString() == "Individual")
                                daD.Fill(dtD, Convert.ToInt32(txtClienteId.Text), dtpFechaInicio.Value, dtpFechaFin.Value);
                            else
                                daD.FillBy(dtD, dtpFechaInicio.Value, dtpFechaFin.Value);
                            dgvDatos.DataSource = dtD;
                            btnGenerarReporte.Enabled = true;
                            break;
                    }
                }
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem.ToString() == "Individual")
            {
                this.txtClienteId.Enabled = true;
            }
            else
            {
                this.txtClienteId.Enabled = false;
                this.txtClienteId.Text = "";
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

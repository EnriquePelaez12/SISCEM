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
    public partial class Empenio_detallado : Form
    {
        public Empenio_detallado()
        {
            InitializeComponent();
        }

        private static Empenio_detallado m_FormDefInstanceEmpenio_detallado;

        public static Empenio_detallado DefInstance
        {
            get
            {
                if (m_FormDefInstanceEmpenio_detallado == null || m_FormDefInstanceEmpenio_detallado.IsDisposed)
                    m_FormDefInstanceEmpenio_detallado = new Empenio_detallado();
                return m_FormDefInstanceEmpenio_detallado;
            }
            set
            {
                m_FormDefInstanceEmpenio_detallado = value;
            }
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            string FechaIni = dtpFecInicio.Value.ToString("dd/MM/yyyy");
            string FechaFin = dtpFecFin.Value.ToString("dd/MM/yyyy");

            rptEmpenio_detallado frmempeni_detalle = new rptEmpenio_detallado();
            frmempeni_detalle.FecIni = dtpFecInicio.Value.ToString("yyyyMMdd");
            frmempeni_detalle.FecFin = dtpFecFin.Value.ToString("yyyyMMdd");
            frmempeni_detalle.FechaIni = FechaIni;
            frmempeni_detalle.FechaFin = FechaFin;
            frmempeni_detalle.ShowDialog(this);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

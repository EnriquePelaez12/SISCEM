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
    public partial class Ventas_detallado : Form
    {
        private static Ventas_detallado m_FormDefInstanceVentas_detallado;

        public static Ventas_detallado DefInstance
        {
            get
            {
                if (m_FormDefInstanceVentas_detallado == null || m_FormDefInstanceVentas_detallado.IsDisposed)
                    m_FormDefInstanceVentas_detallado = new Ventas_detallado();
                return m_FormDefInstanceVentas_detallado;
            }
            set
            {
                m_FormDefInstanceVentas_detallado = value;
            }
        }

        public Ventas_detallado()
        {
            InitializeComponent();
        }

        
        private void btnreporte_Click_1(object sender, EventArgs e)
        {
            string FechaIni = dtpFecInicio.Value.ToString("dd/MM/yyyy");
            string FechaFin = dtpFecFin.Value.ToString("dd/MM/yyyy");

            rptvantas_detallado frmventas_detalle = new rptvantas_detallado();
            frmventas_detalle.FecIni = dtpFecInicio.Value.ToString("yyyyMMdd");
            frmventas_detalle.FecFin = dtpFecFin.Value.ToString("yyyyMMdd");
            frmventas_detalle.FechaIni = FechaIni;
            frmventas_detalle.FechaFin = FechaFin;

            frmventas_detalle.ShowDialog(this);
        }
    }
}

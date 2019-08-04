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
    public partial class Refrendo_Detallado : Form
    {
        private static Refrendo_Detallado m_FormDefInstanceRefrendo_Detallado;

        public static Refrendo_Detallado DefInstance
        {
            get
            {
                if (m_FormDefInstanceRefrendo_Detallado == null || m_FormDefInstanceRefrendo_Detallado.IsDisposed)
                    m_FormDefInstanceRefrendo_Detallado = new Refrendo_Detallado();
                return m_FormDefInstanceRefrendo_Detallado;
            }
            set
            {
                m_FormDefInstanceRefrendo_Detallado = value;
            }
        }

        public Refrendo_Detallado()
        {
            InitializeComponent();
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            string FechaIni = dtpFecInicio.Value.ToString("dd/MM/yyyy");
            string FechaFin = dtpFecFin.Value.ToString("dd/MM/yyyy");

            rptRefrendo_Detallado frmrefrendo_detalle = new rptRefrendo_Detallado();
            frmrefrendo_detalle.FecIni = dtpFecInicio.Value.ToString("yyyyMMdd");
            frmrefrendo_detalle.FecFin = dtpFecFin.Value.ToString("yyyyMMdd");
            frmrefrendo_detalle.FechaIni = FechaIni;
            frmrefrendo_detalle.FechaFin = FechaFin;
            frmrefrendo_detalle.ShowDialog(this);
        }
    }
}

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
    public partial class Egresos_Detallado : Form
    {
        public Egresos_Detallado()
        {
            InitializeComponent();
        }

        private static Egresos_Detallado m_FormDefInstanceEgresos_Detallado;

        public static Egresos_Detallado DefInstance
        {
            get
            {
                if (m_FormDefInstanceEgresos_Detallado == null || m_FormDefInstanceEgresos_Detallado.IsDisposed)
                    m_FormDefInstanceEgresos_Detallado = new Egresos_Detallado();
                return m_FormDefInstanceEgresos_Detallado;
            }
            set
            {
                m_FormDefInstanceEgresos_Detallado = value;
            }
        }


        private void btnreporte_Click(object sender, EventArgs e)
        {
            string FechaIni = dtpFecInicio.Value.ToString("dd/MM/yyyy");
            string FechaFin = dtpFecFin.Value.ToString("dd/MM/yyyy");
            
            rptEgresos_detallado frmegresos_detalle = new rptEgresos_detallado();
            frmegresos_detalle.FecIni = dtpFecInicio.Value.ToString("yyyyMMdd");
            frmegresos_detalle.FecFin = dtpFecFin.Value.ToString("yyyyMMdd");
            frmegresos_detalle.FechaIni = FechaIni;
            frmegresos_detalle.FechaFin = FechaFin;

            frmegresos_detalle.ShowDialog(this);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

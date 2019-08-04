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
    public partial class Ingresos_Detallados : Form
    {

        public Ingresos_Detallados()
        {
            InitializeComponent();
        }

        private static Ingresos_Detallados m_FormDefInstanceIngresos_Detallados;

        public static Ingresos_Detallados DefInstance
        {
            get
            {
                if (m_FormDefInstanceIngresos_Detallados == null || m_FormDefInstanceIngresos_Detallados.IsDisposed)
                    m_FormDefInstanceIngresos_Detallados = new Ingresos_Detallados();
                return m_FormDefInstanceIngresos_Detallados;
            }
            set
            {
                m_FormDefInstanceIngresos_Detallados = value;
            }
        }
        


        private void btnreporte_Click(object sender, EventArgs e)
        {
            string FechaIni = dtpFecInicio.Value.ToString("dd/MM/yyyy");
            string FechaFin = dtpFecFin.Value.ToString("dd/MM/yyyy");

            rptIngresos_Detallado frmingresosdetllado = new rptIngresos_Detallado();
            frmingresosdetllado.FecIni = dtpFecInicio.Value.ToString("yyyyMMdd");
            frmingresosdetllado.FecFin = dtpFecFin.Value.ToString("yyyyMMdd");
            frmingresosdetllado.FechaIni = FechaIni;
            frmingresosdetllado.FechaFin = FechaFin;

            frmingresosdetllado.ShowDialog(this);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

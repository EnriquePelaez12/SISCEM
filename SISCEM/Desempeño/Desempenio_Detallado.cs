using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SISCEM
{
    public partial class Desempenio_Detallado : Form
    {
        public Desempenio_Detallado()
        {
            InitializeComponent();
        }

        private static Desempenio_Detallado m_FormDefInstanceDesempenio_Detallado;

        public static Desempenio_Detallado DefInstance
        {
            get
            {
                if (m_FormDefInstanceDesempenio_Detallado == null || m_FormDefInstanceDesempenio_Detallado.IsDisposed)
                    m_FormDefInstanceDesempenio_Detallado = new Desempenio_Detallado();
                return m_FormDefInstanceDesempenio_Detallado;
            }
            set
            {
                m_FormDefInstanceDesempenio_Detallado = value;
            }
        }
        
        private void Desempenio_Detallado_Load(object sender, EventArgs e)
        {

        }


        private void btnreporte_Click(object sender, EventArgs e)
        {
            string FechaIni = dtpFecInicio.Value.ToString("dd/MM/yyyy");
            string FechaFin = dtpFecFin.Value.ToString("dd/MM/yyyy");

             rptdesempenio_detallado frmdesempeni_detalle = new rptdesempenio_detallado();                    
             frmdesempeni_detalle.FecIni = dtpFecInicio.Value.ToString("yyyyMMdd");
             frmdesempeni_detalle.FecFin = dtpFecFin.Value.ToString("yyyyMMdd");
             frmdesempeni_detalle.FechaIni = FechaIni;
             frmdesempeni_detalle.FechaFin = FechaFin;

             frmdesempeni_detalle.ShowDialog(this);
         }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

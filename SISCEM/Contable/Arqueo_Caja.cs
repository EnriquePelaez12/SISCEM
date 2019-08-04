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
    public partial class Arqueo_Caja : Form
    {
        private static Arqueo_Caja m_FormDefInstanceArqueo_caja;
        public static Arqueo_Caja DefInstance
        {
            get
            {
                if (m_FormDefInstanceArqueo_caja == null || m_FormDefInstanceArqueo_caja.IsDisposed)
                    m_FormDefInstanceArqueo_caja = new Arqueo_Caja();
                return m_FormDefInstanceArqueo_caja;
            }
            set
            {
                m_FormDefInstanceArqueo_caja = value;
            }
        }

        public Arqueo_Caja()
        {
            InitializeComponent();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            try
            {
                            
            int mil = Convert.ToInt32(lbl1000.Text) * Convert.ToInt32(txt1000.Text);
            int quinientos = Convert.ToInt32(lbl500.Text) * Convert.ToInt32(txt500.Text);
            int doscientos = Convert.ToInt32(lbl200.Text) * Convert.ToInt32(txt200.Text);
            int cien = Convert.ToInt32(lbl100.Text) * Convert.ToInt32(txt100.Text);
            int cincuenta = Convert.ToInt32(lbl50.Text) * Convert.ToInt32(txt50.Text);
            int veinte = Convert.ToInt32(lbl20.Text) * Convert.ToInt32(txt20.Text);
            int diez = Convert.ToInt32(lbl10.Text) * Convert.ToInt32(txt10.Text);
            int cinco = Convert.ToInt32(lbl5.Text) * Convert.ToInt32(txt5.Text);
            int dos = Convert.ToInt32(lbl2.Text) * Convert.ToInt32(txt2.Text);
            int uno = Convert.ToInt32(lbl1.Text) * Convert.ToInt32(txt1.Text);
            int total = mil + quinientos + doscientos + cien + cincuenta + veinte + diez + cinco + dos + uno;
            txttotal.Text = Convert.ToString(total);
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique la informacion ingresada");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }
        private void limpiar()
        {
            txt1000.Text = "0"; txt500.Text = "0"; txt200.Text = "0";
            txt100.Text = "0"; txt50.Text = "0"; txt20.Text = "0";
            txt10.Text = "0"; txt5.Text = "0"; txt2.Text = "0";
            txt1.Text = "0";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Arqueo_Caja_Load(object sender, EventArgs e)
        {
            txt1000.Text = "0"; txt500.Text = "0"; txt200.Text = "0";
            txt100.Text = "0"; txt50.Text = "0"; txt20.Text = "0";
            txt10.Text = "0"; txt5.Text = "0"; txt2.Text = "0";
            txt1.Text = "0"; txttotal.Text = "";
        }
    }
}

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
    public partial class Cancela_boleta : Form
    {
        BD basedatos = new BD();
        BaseDeDatos bdatos = new BaseDeDatos();

        private static Cancela_boleta m_FormDefInstanceCancela_boleta;

        public static Cancela_boleta DefInstance
        {
            get
            {
                if (m_FormDefInstanceCancela_boleta == null || m_FormDefInstanceCancela_boleta.IsDisposed)
                    m_FormDefInstanceCancela_boleta = new Cancela_boleta();
                return m_FormDefInstanceCancela_boleta;
            }
            set
            {
                m_FormDefInstanceCancela_boleta = value;
            }
        }

        public Cancela_boleta()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            BD basedatos = new BD();
            SqlConnection conexion;
            //Creando conexion
            conexion = basedatos.conexionsql();
            //Abriendo conexion
            conexion.Open();

            string dtme = Convert.ToString(DateTime.Now.ToShortDateString());
            DateTime fecha = Convert.ToDateTime(dtme);

            DateTime fecha_vencimiento = Convert.ToDateTime(dtme);
            fecha_vencimiento = fecha_vencimiento.AddDays(28);

            DateTime fecha_comercializacion = fecha_vencimiento;
            fecha_comercializacion = fecha_vencimiento.AddDays(3);

            string actualizar = "update Boleta_Encabezado set Estado='Cancelado' where Boleta_id = " + txtboleta.Text;

            if (bdatos.executecommand(actualizar))
            {
                MessageBox.Show("Boleta Cancelada correctamente");
                txtboleta.Text = "";

            }
            else
            {
                MessageBox.Show("Error al Cancelar la boleta");
            }
            conexion.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

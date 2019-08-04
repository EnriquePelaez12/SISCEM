using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SISCEM
{
    public partial class Actualiza_Boleta : Form
    {
        BD basedatos = new BD();
        BaseDeDatos bdatos = new BaseDeDatos();

        private static Actualiza_Boleta m_FormDefInstanceActualiza_Boleta;

        public static Actualiza_Boleta DefInstance
        {
            get
            {
                if (m_FormDefInstanceActualiza_Boleta == null || m_FormDefInstanceActualiza_Boleta.IsDisposed)
                    m_FormDefInstanceActualiza_Boleta = new Actualiza_Boleta();
                return m_FormDefInstanceActualiza_Boleta;
            }
            set
            {
                m_FormDefInstanceActualiza_Boleta = value;
            }
        }

        public Actualiza_Boleta()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
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

            string actualizar = "update Boleta_Encabezado set Estado='Vigente',Boleta_Fecha_Vencimiento= '" + fecha_vencimiento.ToString("yyyy-MM-dd hh:mm") + "',Boleta_Fecha_Comercializacion= '" + fecha_comercializacion.ToString("yyyy-MM-dd hh:mm") + "' where Boleta_id = " + txtboletaid.Text;

            if (bdatos.executecommand(actualizar))
            {
                MessageBox.Show("Boleta Actualizada correctamente");

            }
            else
            {
                MessageBox.Show("Error al actualizar la boleta");
            }
            conexion.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtboletaid.Text = "";
        }

        private void Actualiza_Boleta_Load(object sender, EventArgs e)
        {

        }

        private void btnsali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

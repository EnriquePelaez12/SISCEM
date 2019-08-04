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
    public partial class ConsultaRefrendo : Form
    {
        BaseDeDatos bdatos = new BaseDeDatos();

        public ConsultaRefrendo()
        {
            InitializeComponent();
        }

        private static ConsultaRefrendo m_FormDefInstanceConsultaRefrendo;

        public static ConsultaRefrendo DefInstance
        {
            get
            {
                if (m_FormDefInstanceConsultaRefrendo == null || m_FormDefInstanceConsultaRefrendo.IsDisposed)
                    m_FormDefInstanceConsultaRefrendo = new ConsultaRefrendo();
                return m_FormDefInstanceConsultaRefrendo;
            }
            set
            {
                m_FormDefInstanceConsultaRefrendo = value;
            }
        }

        private void buscaxcliente()
        {
            gvBoleta.DataSource = bdatos.SelectDataTable(" Select Refrendo_id,Boleta_Id,Cliente_Nombre,Prestamo,Interes,Almacenaje,Iva,Total,Fecha from Refrendo_Total " +
                                                        " Where  Cliente_nombre like '%" + txtnombre.Text + "%'");
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtrefrendo.Text != "")
                {
                    BD basedatos = new BD();
                    SqlConnection conexion;
                    //Creando conexion
                    conexion = basedatos.conexionsql();
                    //Abriendo conexion
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("Select Refrendo_id,Boleta_Id,Cliente_Nombre,Prestamo,Interes,Almacenaje,Iva,Total,Fecha from Refrendo_Total "+
                                                        " Where Refrendo_id=" + txtrefrendo.Text, conexion);
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    using (da)
                    {
                        da.Fill(dt);
                    }
                    gvBoleta.DataSource = dt;
                   // txtrefrendo.ReadOnly = true;
                    txtrefrendo.Text = "";

                }
                else
                {
                    MessageBox.Show("Ingrese el número de refrendo");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese un numero de refendo valido");
                txtrefrendo.Text = "";
            }
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            this.buscaxcliente();
            txtnombre.Text = "";
        }
    }
}

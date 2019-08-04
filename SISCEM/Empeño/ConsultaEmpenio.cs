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
    public partial class ConsultaEmpenio : Form
    {
        BaseDeDatos bdatos = new BaseDeDatos();

        public ConsultaEmpenio()
        {
            InitializeComponent();
        }

        private static ConsultaEmpenio m_FormDefInstanceConsultaEmpenio;

        public static ConsultaEmpenio DefInstance
        {
            get
            {
                if (m_FormDefInstanceConsultaEmpenio == null || m_FormDefInstanceConsultaEmpenio.IsDisposed)
                    m_FormDefInstanceConsultaEmpenio = new ConsultaEmpenio();
                return m_FormDefInstanceConsultaEmpenio;
            }
            set
            {
                m_FormDefInstanceConsultaEmpenio = value;
            }
        }


        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtempenio.Text != "")
                {
                    BD basedatos = new BD();
                    SqlConnection conexion;
                    //Creando conexion
                    conexion = basedatos.conexionsql();
                    //Abriendo conexion
                    //conexion.Open();
                    SqlCommand comando = new SqlCommand("Select Boleta_Id,B.Cliente_Nombre,Prestamo,Avaluo,Estado,Boleta_Fecha,Boleta_Fecha_Vencimiento,Boleta_Fecha_Comercializacion from	Boleta_Encabezado A With (Nolock), "+
				                                         "                       Cliente B With (Nolock) "+
                                                         "       Where A.Cliente_Id	= B.Cliente_Id "+
                                                         "       And Boleta_Id		= " + txtempenio.Text, conexion);
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    using (da)
                    {
                        da.Fill(dt);
                    }
                    gvBoleta.DataSource = dt;
                    // txtrefrendo.ReadOnly = true;
                    txtempenio.Text = "";
                }
                else
                {
                    MessageBox.Show("Ingrese el número de refrendo");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese un numero de refendo valido");
                txtempenio.Text = "";
            }
        }

        private void ConsultaEmpenio_Load(object sender, EventArgs e)
        {

        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            buscaxcliente();
            txtnombre.Text = "";
        }
        private void buscaxcliente()
        {
            gvBoleta.DataSource = bdatos.SelectDataTable("Select Boleta_Id,B.Cliente_Nombre,Prestamo,Avaluo,Estado,Boleta_Fecha,Boleta_Fecha_Vencimiento,Boleta_Fecha_Comercializacion from	Boleta_Encabezado A With (Nolock), " +
                                                         "                       Cliente B With (Nolock) " +
                                                         "       Where A.Cliente_Id	= B.Cliente_Id " +
                                                         "       And		Cliente_nombre like '%" + txtnombre.Text + "%'");
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

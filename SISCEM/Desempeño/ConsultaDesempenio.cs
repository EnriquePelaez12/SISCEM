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
    public partial class ConsultaDesempenio : Form
    {
        BaseDeDatos bdatos = new BaseDeDatos();

        public ConsultaDesempenio()
        {
            InitializeComponent();
        }
        private static ConsultaDesempenio m_FormDefInstanceConsultaDesempenio;

        public static ConsultaDesempenio DefInstance
        {
            get
            {
                if (m_FormDefInstanceConsultaDesempenio == null || m_FormDefInstanceConsultaDesempenio.IsDisposed)
                    m_FormDefInstanceConsultaDesempenio = new ConsultaDesempenio();
                return m_FormDefInstanceConsultaDesempenio;
            }
            set
            {
                m_FormDefInstanceConsultaDesempenio = value;
            }
        }


        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdesempenio.Text != "")
                {
                    BD basedatos = new BD();
                    SqlConnection conexion;
                    //Creando conexion
                    conexion = basedatos.conexionsql();
                    //Abriendo conexion
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("Select B.Cliente_Nombre,C.IdDesempenio,C.IdBoleta,C.Monto,C.Fecha from Boleta_Encabezado A With (Nolock), "+
			                                             "                 Cliente B With (Nolock),"+
			                                             "                Desempenio C With (Nolock)"+
                                                         "   Where	A.Cliente_Id	= B.Cliente_Id"+
                                                         "   And		A.Boleta_Id		= C.IdBoleta"+
                                                         "   And		C.IdDesempenio	=" + txtdesempenio.Text, conexion);
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    using (da)
                    {
                        da.Fill(dt);
                    }
                    gvBoleta.DataSource = dt;
                    txtdesempenio.Text = "";

                }
                else
                {
                    MessageBox.Show("Ingrese el número de Desempeño");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese un numero de Desempeño valido");
                txtdesempenio.Text = "";
            }
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            this.buscaxcliente();
            txtnombre.Text = "";
        }
        private void buscaxcliente()
        {
            gvBoleta.DataSource = bdatos.SelectDataTable(" Select B.Cliente_Nombre,C.IdDesempenio,C.IdBoleta,C.Monto,C.Fecha from Boleta_Encabezado A With (Nolock), " +
                                                         "                 Cliente B With (Nolock)," +
                                                         "                Desempenio C With (Nolock)" +
                                                         "   Where	A.Cliente_Id	= B.Cliente_Id" +
                                                         "   And		A.Boleta_Id		= C.IdBoleta" +
                                                         "   And		Cliente_nombre like '%" + txtnombre.Text + "%'");
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

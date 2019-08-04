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
    public partial class Consulta_Codigo_Venta : Form
    {
        BaseDeDatos bdatos = new BaseDeDatos();

        public Consulta_Codigo_Venta()
        {
            InitializeComponent();
        }
        private static Consulta_Codigo_Venta m_FormDefInstanceConsulta_Codigo_Venta;

        public static Consulta_Codigo_Venta DefInstance
        {
            get
            {
                if (m_FormDefInstanceConsulta_Codigo_Venta == null || m_FormDefInstanceConsulta_Codigo_Venta.IsDisposed)
                    m_FormDefInstanceConsulta_Codigo_Venta = new Consulta_Codigo_Venta();
                return m_FormDefInstanceConsulta_Codigo_Venta;
            }
            set
            {
                m_FormDefInstanceConsulta_Codigo_Venta = value;
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtboleta_id.Text != "")
                {
                    BD basedatos = new BD();
                    SqlConnection conexion;
                    //Creando conexion

                    conexion = basedatos.conexionsql();
                    //Abriendo conexion
                    //conexion.Open();
                    SqlCommand comando = new SqlCommand("SELECT  Codigo_Id, Boleta_Id, Categoria_Id, Categoria_Nombre, Kilateje, SubCategoria_Nombre, Estado, Descripcion, Peso, Peso_Piedra, Prestamo, Avaluo, Estatus " +
                                                            " FROM            Desglose_Boleta " +
                                                            "WHERE        Boleta_Id =" + txtboleta_id.Text , conexion);
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    using (da)
                    {
                        da.Fill(dt);
                    }
                    gvBoleta.DataSource = dt;
                    txtboleta_id.ReadOnly = true;
                    txtboleta_id.Text = "";
                }
                else
                {
                    MessageBox.Show("Ingrese el número de boleta");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese un numero de boleta valido");
                txtboleta_id.Text = "";
            }
        }

        private void Consulta_Codigo_Venta_Load(object sender, EventArgs e)
        {

        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            //buscaxcliente();
            
        }

        //private void buscaxcliente()
        //{
        //    gvBoleta.DataSource = bdatos.SelectDataTable(" Select B.Cliente_Nombre,C.IdDesempenio,C.IdBoleta,C.Monto,C.Fecha from Boleta_Encabezado A With (Nolock), " +
        //                                                 "                 Cliente B With (Nolock)," +
        //                                                 "                Desempenio C With (Nolock)" +
        //                                                 "   Where	A.Cliente_Id	= B.Cliente_Id" +
        //                                                 "   And		A.Boleta_Id		= C.IdBoleta" +
        //                                                 "   And		Cliente_nombre like '%" + txtnombre.Text + "%'");
        //}

      
    }
}

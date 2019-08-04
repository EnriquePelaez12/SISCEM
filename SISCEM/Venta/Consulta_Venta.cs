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
    public partial class Consulta_Venta : Form
    {
        BaseDeDatos bdatos = new BaseDeDatos();

        public Consulta_Venta()
        {
            InitializeComponent();
        }

        private static Consulta_Venta m_FormDefInstanceConsulta_Venta;

        public static Consulta_Venta DefInstance
        {
            get
            {
                if (m_FormDefInstanceConsulta_Venta == null || m_FormDefInstanceConsulta_Venta.IsDisposed)
                    m_FormDefInstanceConsulta_Venta = new Consulta_Venta();
                return m_FormDefInstanceConsulta_Venta;
            }
            set
            {
                m_FormDefInstanceConsulta_Venta = value;
            }
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            this.buscaxcliente();
        }
        private void buscaxcliente()
        {
            gvBoleta.DataSource = bdatos.SelectDataTable("Select Venta_Id,Boleta_Id,Categoria_Nombre,Cliente_Nombre,Kilataje,Descripcion,Peso,Peso_Piedra,Fecha,Total from venta Where Cliente_Nombre like '%" + txtnombre.Text + "%'");
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtventa_id.Text != "")
                {
                    BD basedatos = new BD();
                    SqlConnection conexion;
                    //Creando conexion
                    conexion = basedatos.conexionsql();
                    //Abriendo conexion
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("Select Venta_Id,Boleta_Id,Categoria_Nombre,Cliente_Nombre,Kilataje,Descripcion,Peso,Peso_Piedra,Fecha,Total from venta Where venta_id=" + txtventa_id.Text, conexion);
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    using (da)
                    {
                        da.Fill(dt);
                    }
                    gvBoleta.DataSource = dt;
                    txtventa_id.Text = "";

                }
                else
                {
                    MessageBox.Show("Ingrese el número de Venta");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese un numero de Venta valido");
                txtventa_id.Text = "";
            }
        }
    }
}

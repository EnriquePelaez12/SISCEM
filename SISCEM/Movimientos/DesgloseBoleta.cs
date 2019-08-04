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
    public partial class DesgloseBoleta : Form
    {
        BD basedatos = new BD();
        BaseDeDatos bdatos = new BaseDeDatos();

        private static DesgloseBoleta m_FormDefInstanceDesgloseBoleta;

        public static DesgloseBoleta DefInstance
        {
            get
            {
                if (m_FormDefInstanceDesgloseBoleta == null || m_FormDefInstanceDesgloseBoleta.IsDisposed)
                    m_FormDefInstanceDesgloseBoleta = new DesgloseBoleta();
                return m_FormDefInstanceDesgloseBoleta;
            }
            set
            {
                m_FormDefInstanceDesgloseBoleta = value;
            }
        }

        public DesgloseBoleta()
        {
            InitializeComponent();
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
                    SqlCommand comando = new SqlCommand("select D.Cliente_Nombre, D.Categoria_Nombre, D.Subcategoria_Nombre, D.Descripcion, D.Estado, D.Kilateje, D.Peso, D.Peso_Piedra, D.Prestamo, D.Avaluo, D.Boleta_Fecha, D.Boleta_Fecha_Vencimiento from Boleta_Detalle D,	 Boleta_Encabezado E where E.Boleta_Id=D.Boleta_Id And   E.Boleta_Id=" + txtboleta_id.Text + "  And   E.Estado='Vencido'  ", conexion);
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    using (da)
                    {
                        da.Fill(dt);
                    }
                    gvBoleta.DataSource = dt;
                    txtboleta_id.ReadOnly = true;
                
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

        private void btnDesgloseBoleta_Click(object sender, EventArgs e)
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
                    using (conexion)
                    {
                        conexion.Open();
                        SqlCommand comando = new SqlCommand("Insert Into Desglose_Boleta(Boleta_Id,Categoria_Id,Categoria_Nombre,Kilateje,SubCategoria_Nombre,Estado,Descripcion,Peso,Peso_Piedra,Prestamo,Avaluo,Estatus) select Boleta_Id,Categoria_Id,Categoria_Nombre,Kilateje,Subcategoria_Nombre,Estado,Descripcion,Peso,Peso_Piedra,Prestamo,Avaluo,'Activo' from Boleta_Detalle where Boleta_Id=" + txtboleta_id.Text, conexion);
                        int res = comando.ExecuteNonQuery();
                        conexion.Close();
                        if (res>0)
                        {
                            rptDesgloseBoleta rpt = new rptDesgloseBoleta();
                            rpt.IdBoleta = Convert.ToInt32(txtboleta_id.Text);
                            rpt.ShowDialog(this);
                            rpt.Dispose();

                            string actualizar = "update Boleta_Encabezado set Estado = 'Desglosada'  where Boleta_id = " + txtboleta_id.Text;

                            if (bdatos.executecommand(actualizar))
                            {
                                MessageBox.Show("Boleta Desglosada correctamente");
                                txtboleta_id.ReadOnly = false;

                            }
                            else
                            {
                                MessageBox.Show("Error al Desglosar");
                            }
                        }
                        else
                            MessageBox.Show("Error al desglosar la boleta. Vuelva a Intentarlo");
                        gvBoleta.DataSource = null;
                        txtboleta_id.Text = "";
                    }                              
                
                }
                else
                {
                    MessageBox.Show("Ingrese el número de boleta");
                }


            }
            catch (Exception)
            {

                MessageBox.Show("");
            }
        }

        private void txtboleta_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.btnbuscar.Select();
            }
           
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            gvBoleta.DataSource = null;
            txtboleta_id.Text = "";
            txtboleta_id.ReadOnly = false;
        }

        private void DesgloseBoleta_Load(object sender, EventArgs e)
        {
            lblusuario.Text = "Cajero: " + Program.Usuario;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

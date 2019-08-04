using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SISCEM
{
    public partial class Categorias : Form
    {
        private static Categorias m_FormDefInstanceCategorias;
        public static Categorias DefInstance
        {
            get
            {
                if (m_FormDefInstanceCategorias == null || m_FormDefInstanceCategorias.IsDisposed)
                    m_FormDefInstanceCategorias = new Categorias();
                return m_FormDefInstanceCategorias;
            }
            set
            {
                m_FormDefInstanceCategorias = value;
            }
        }


        BD basedatos =new BD();
        BaseDeDatos bdatos = new BaseDeDatos();

        public Categorias()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            
            txtnombre.Text = "";
            txtcategoria_id.Text = "";
            txtcategoriaid.Text = "";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
             try
            {

                    if ( txtnombre.Text=="")
                        MessageBox.Show("Le falta escribir algunos datos.", "Error:", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    else
                    {

                        string dtme = Convert.ToString(DateTime.Now.ToShortDateString());
                        DateTime fecha = Convert.ToDateTime(dtme);
                        string agregar = "insert into Categoria (Emp_id,Categoria_Nombre,Categoria_Fec_Actualizacion) values (1,'" + txtnombre.Text + "','" + fecha.ToString("yyyy-MM-dd hh:mm") + "')";

                        if (bdatos.executecommand(agregar))
                        {
                            MessageBox.Show("Registro agregado correctamente");
                            dgvcategoria.DataSource = bdatos.SelectDataTable("select Categoria_Id,Categoria_Nombre,Categoria_Fec_Actualizacion as Fec_Actualizacion from Categoria");
                            this.limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar");
                        }
                    }
                     //else
                     //   {

                     //   DateTime fecha = Convert.ToDateTime(DateTime.Now.ToLocalTime());
                     //   SqlConnection conexion =basedatos.conexionsql();
                     //   conexion.Open();
                     //   string comado = "insert into categoria_articulo (Emp_id,Categoria_Nombre,Categoria_Fec_Actualizacion) VALUES (@Emp_id,@Categoria_Nombre,@Categoria_Fec_Actualizacion);";
                     //   SqlCommand micomando =new SqlCommand(comado,conexion);
                     //   micomando.Parameters.Add("@Emp_id", SqlDbType.Int).Value =1;                        
                     //   micomando.Parameters.Add("@Categoria_Nombre",SqlDbType.VarChar,100).Value=txtnombre.Text;
                     //   micomando.Parameters.Add("@Categoria_Fec_Actualizacion",DateTime.Today).Value = fecha;
                     //   micomando.ExecuteNonQuery();
                     //   conexion.Close();
                     //   MessageBox.Show("Registro insertado correctamente");
                     //   limpiar();
                     //   }

             }//try
                catch (SqlException excep)
                   {
                        MessageBox.Show(excep.Message);
                   }//catch
           }

        private void Categorias_Load(object sender, EventArgs e)
        {
            dgvcategoria.DataSource = bdatos.SelectDataTable("select Categoria_Id,Categoria_Nombre,Categoria_Fec_Actualizacion as Fec_Actualizacion from Categoria");
        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            try
            {

                string dtme = Convert.ToString(DateTime.Now.ToShortDateString());
                DateTime fecha = Convert.ToDateTime(dtme);
                if (txtcategoriaid.Text == "")
                {
                    MessageBox.Show("ingrese un numero de Categoria.", "Error:", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                else
                {
                    string actualizar = "update Categoria set Categoria_Nombre = '" + txtnombre.Text + "',Categoria_Fec_Actualizacion = '" + fecha.ToString("yyyy-MM-dd hh:mm")+"'  where Categoria_id = " + txtcategoriaid.Text;

                    if (bdatos.executecommand(actualizar))
                    {
                        MessageBox.Show("Registro actualizado correctamente");
                        dgvcategoria.DataSource = bdatos.SelectDataTable("select Categoria_Id,Categoria_Nombre,Categoria_Fec_Actualizacion as Fec_Actualizacion from Categoria");
                        this.limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado");
            }

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcategoria_id.Text == "")
                {
                    MessageBox.Show("Igrese un valor");
                }
                else
                {
                    dgvcategoria.DataSource = bdatos.SelectDataTable("select   Categoria_Id,Categoria_Nombre,Categoria_Fec_Actualizacion as Fec_Actualizacion from Categoria where Categoria_id = " + txtcategoria_id.Text);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvcategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow dgv = dgvcategoria.Rows[e.RowIndex];
                txtcategoriaid.Text = dgv.Cells[0].Value.ToString();
                txtnombre.Text = dgv.Cells[1].Value.ToString();                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un valor");
            }
        }

        private void btnsali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        }       
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SISCEM
{
    public partial class Subcategorias : Form
    {
        private static Subcategorias m_FormDefInstanceSubcategorias;
        public static Subcategorias DefInstance
        {
            get
            {
                if (m_FormDefInstanceSubcategorias == null || m_FormDefInstanceSubcategorias.IsDisposed)
                    m_FormDefInstanceSubcategorias = new Subcategorias();
                return m_FormDefInstanceSubcategorias;
            }
            set
            {
                m_FormDefInstanceSubcategorias = value;
            }
        }


        BaseDeDatos bdatos = new BaseDeDatos();
        BD basedatos = new BD();
        public Subcategorias()
        {
            InitializeComponent();
        }

        private void Subcategorias_Load(object sender, EventArgs e)
        {
            SqlConnection Conexion = basedatos.conexionsql();
            dgvsubcategorias.DataSource = bdatos.SelectDataTable("Select B.Categoria_nombre,A.Subcategoria_Id,a.Subcategoria_Nombre,a.Categoria_Fec_Actualizacion "+ 
             " From sub_categoria A, "+
	         " Categoria B "+
             " Where A.Categoria_id=B.Categoria_id");

            string Ccategorias="Select Categoria_id,categoria_nombre from Categoria";
            DataSet ds_catego = new DataSet();
            SqlDataAdapter Catego = new SqlDataAdapter(Ccategorias, Conexion);
            Catego.Fill(ds_catego, "Categorias");
            cmbcategoria.DataSource = ds_catego.Tables[0].DefaultView;                        
            cmbcategoria.ValueMember = "Categoria_id";
            cmbcategoria.DisplayMember = "Categoria_Nombre";
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtidsubcategoria.Text == "")
                {
                    MessageBox.Show("Igrese un valor");
                }
                else
                {
                    dgvsubcategorias.DataSource = bdatos.SelectDataTable("Select B.Categoria_nombre,A.Subcategoria_Id,a.Subcategoria_Nombre,a.Categoria_Fec_Actualizacion "+ 
                                                                         " From sub_categoria A, "+
	                                                                     " Categoria B "+
                                                                         " Where A.Categoria_id=B.Categoria_id "+
                                                                         " And A.Subcategoria_id = " + txtidsubcategoria.Text);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvsubcategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgvsubcategorias.Rows[e.RowIndex];
                cmbcategoria.Text = dgv.Cells[0].Value.ToString();
                txtsubcategoria_id.Text = dgv.Cells[1].Value.ToString();
                txtnombresubcategoria.Text = dgv.Cells[2].Value.ToString();
                               
           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un valor");
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            
            try
            {
                string dtme = Convert.ToString(DateTime.Now.ToShortDateString());
                DateTime fecha = Convert.ToDateTime(dtme);
                if (txtsubcategoria_id.Text == "")
                {
                    MessageBox.Show("ingrese un numero de Subcategoria.", "Error:", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                else
                {
                    string actualizar = "update Sub_categoria set Categoria_id = " + cmbcategoria.SelectedValue.ToString()
                                             + ",Subcategoria_Nombre = '" + txtnombresubcategoria.Text                                             
                                             + "',Categoria_Fec_Actualizacion = '" + fecha.ToString("yyyy-MM-dd hh:mm")
                                             + "' where Subcategoria_id = " + txtsubcategoria_id.Text;

                    if (bdatos.executecommand(actualizar))
                    {
                        MessageBox.Show("Registro actualizado correctamente");
                         dgvsubcategorias.DataSource = bdatos.SelectDataTable("Select B.Categoria_nombre,A.Subcategoria_Id,a.Subcategoria_Nombre,a.Categoria_Fec_Actualizacion "+ 
                                                                                 " From sub_categoria A, "+
	                                                                             " Categoria B "+
                                                                                 " Where A.Categoria_id=B.Categoria_id");
                        //this.limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la informacion");
            }
        }

        private void limpiar()
        {
            txtsubcategoria_id.Text = "";
            txtnombresubcategoria.Text = "";
            txtidsubcategoria.Text = "";
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtnombresubcategoria.Text == "")
                    MessageBox.Show("Le falta escribir algunos datos.", "Error:", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                else
                {

                    string dtme = Convert.ToString(DateTime.Now.ToShortDateString());
                    DateTime fecha = Convert.ToDateTime(dtme);
                    string agregar = "Insert into Sub_categoria (Emp_Id,Categoria_Id,Subcategoria_Nombre,Categoria_Fec_Actualizacion) Values (" + 1 + "," + cmbcategoria.SelectedValue.ToString() + ",'" + txtnombresubcategoria.Text + "','" + fecha.ToString("yyyy-MM-dd hh:mm") + "')";

                    if (bdatos.executecommand(agregar))
                    {
                        MessageBox.Show("Registro agregado correctamente");
                        SqlConnection Conexion = basedatos.conexionsql();
                        dgvsubcategorias.DataSource = bdatos.SelectDataTable("Select B.Categoria_nombre,A.Subcategoria_Id,a.Subcategoria_Nombre,a.Categoria_Fec_Actualizacion " +
                         " From sub_categoria A, " +
                         " Categoria B " +
                         " Where A.Categoria_id=B.Categoria_id");
                        this.limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar");
                    }
                }              

            }//try
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }//catch
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     }             
}

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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private static Usuarios m_FormDefInstanceUsuarios;
        public static Usuarios DefInstance
        {
            get
            {
                if (m_FormDefInstanceUsuarios == null || m_FormDefInstanceUsuarios.IsDisposed)
                    m_FormDefInstanceUsuarios = new Usuarios();
                return m_FormDefInstanceUsuarios;
            }
            set
            {
                m_FormDefInstanceUsuarios = value;
            }
        }

        BD basedatos = new BD();
        BaseDeDatos bdatos = new BaseDeDatos();

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void limpiar()
        {
            txtnombre.Text = "";
            txtusuario.Text = "";
            txtpass.Text = "";
            
           
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            dgvusuario.DataSource = bdatos.SelectDataTable("Select Usuario_Id,Usuario_Nombre,Usuario_Login,Usuario_Password,Usuario_Fec_Actualizacion from Usuario");

        }

     
        private string _cellValue = String.Empty;


        private void btnguardar_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtnombre.Text == "" || txtusuario.Text == "" || txtpass.Text == "" )
                    MessageBox.Show("Le falta escribir algunos datos.", "Error:", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                else
                {
                    string dtme = Convert.ToString(DateTime.Now.ToShortDateString());
                    DateTime fecha = Convert.ToDateTime(dtme);
                    string agregar = "Insert into Usuario (Usuario_Nombre,Usuario_login,Usuario_Password,Usuario_Fec_actualizacion,Usuario_Activo) " +
                                      " Values  ('" + txtnombre.Text + "','" + txtusuario.Text + "','" + txtpass.Text + "','" +fecha.ToString("yyyy-MM-dd hh:mm") +"'," + 1 +")";

                    if (bdatos.executecommand(agregar))
                    {
                        MessageBox.Show("Registro agregado correctamente");
                        dgvusuario.DataSource = bdatos.SelectDataTable("Select Usuario_Id,Usuario_Nombre,Usuario_Login,Usuario_Password,Usuario_Fec_Actualizacion from Usuario");
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

        private void dgvusuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgvusuario.Rows[e.RowIndex];

                txtnombre.Text = dgv.Cells[1].Value.ToString();
                txtusuario.Text = dgv.Cells[2].Value.ToString();
                txtpass.Text = dgv.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un valor");
            }
        }

        private void dgvusuario_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                DataGridViewRow id_detalle = dgvusuario.Rows[e.RowIndex];
                lblcontador.Text = id_detalle.Cells[0].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("No existe registros que cargar ");
            }
          
        }


        private void btnmodificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string dtme = Convert.ToString(DateTime.Now.ToShortDateString());
                DateTime fecha = Convert.ToDateTime(dtme);
                if (lblcontador.Text == "")
                {
                    MessageBox.Show("seleccione un usuario.", "Error:", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                else
                {
                    string actualizar = "update Usuario set Usuario_Nombre = '" + txtnombre.Text
                                             + "',Usuario_login = '" + txtusuario.Text
                                             + "',Usuario_Password = '" + txtpass.Text
                                             + "',Usuario_Fec_Actualizacion = '" + fecha.ToString("yyyy-MM-dd hh:mm")
                                             + "' where usuario_id = " + lblcontador.Text;



                    if (bdatos.executecommand(actualizar))
                    {
                        MessageBox.Show("Registro actualizado correctamente");
                        dgvusuario.DataSource = bdatos.SelectDataTable("Select Usuario_Id,Usuario_Nombre,Usuario_Login,Usuario_Password,Usuario_Fec_Actualizacion from Usuario");
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
                MessageBox.Show("Error al actualizar la informacion");
            }

        }
    }
}

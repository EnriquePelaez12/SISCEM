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
    public partial class Alta_Empleado : Form
    {
        BD basedatos =new BD();


        private static Alta_Empleado m_FormDefInstanceAlta_Empleado;
        public static Alta_Empleado DefInstance
        {
            get
            {
                if (m_FormDefInstanceAlta_Empleado == null || m_FormDefInstanceAlta_Empleado.IsDisposed)
                    m_FormDefInstanceAlta_Empleado = new Alta_Empleado();
                return m_FormDefInstanceAlta_Empleado;
            }
            set
            {
                m_FormDefInstanceAlta_Empleado = value;
            }
        }
        
        public Alta_Empleado()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtnombre.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
             try
            {

                    if (txtnombre.Text==""|| txtdireccion.Text == "" || txttelefono.Text=="")
                        MessageBox.Show("Le falta escribir algunos datos.", "Error:", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                     else
                        {

                        DateTime fecha = Convert.ToDateTime(DateTime.Now.ToLocalTime());
                        SqlConnection conexion =basedatos.conexionsql();
                        conexion.Open();
                        string comado = "insert into Empleado (Empleado_Nombre,Empleado_Direccion,Emp_Fecha_Actualizacion,Empleado_Telefono,Rol_Id)values(@Empleado_Nombre,@Empleado_Direccion,@Emp_Fecha_Actualizacion,@Empleado_Telefono,@Rol_Id);";
                        SqlCommand micomando =new SqlCommand(comado,conexion);
                        micomando.Parameters.Add("@Empleado_Nombre", SqlDbType.VarChar, 200).Value = txtnombre.Text;
                        micomando.Parameters.Add("@Empleado_Direccion", SqlDbType.VarChar, 300).Value = txtdireccion.Text;
                        micomando.Parameters.Add("@Emp_Fecha_Actualizacion",DateTime.Today).Value = fecha;
                        micomando.Parameters.Add("@Empleado_Telefono", SqlDbType.VarChar, 15).Value = txtdireccion.Text;
                        micomando.Parameters.Add("@Rol_Id",SqlDbType.VarChar,100).Value=1;
                        micomando.ExecuteNonQuery();
                        conexion.Close();
                        MessageBox.Show("Registro insertado correctamente");
                        limpiar();
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


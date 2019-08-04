using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SISCEM
{
    public partial class Empresa : Form
    {
        private static Empresa m_FormDefInstanceEmpresa;
        public static Empresa DefInstance
        {
            get
            {
                if (m_FormDefInstanceEmpresa == null || m_FormDefInstanceEmpresa.IsDisposed)
                    m_FormDefInstanceEmpresa = new Empresa();
                return m_FormDefInstanceEmpresa;
            }
            set
            {
                m_FormDefInstanceEmpresa = value;
            }
        }
                
        BaseDeDatos bdatos = new BaseDeDatos();
        public Empresa()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtempresa.Text = "";
            txtcedula.Text = "";
            txtdireccion.Text = "";
            txtemail.Text = "";
            txtmision.Text = "";
            txtrazonsocial.Text = "";
            txttelefono.Text = "";
            txtempresa_id.Text = "";
            txtempresaid.Text = "";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtempresa.Text == "" || txtcedula.Text == "" || txtdireccion.Text == "" || txtemail.Text == "" || txtmision.Text == "" || txtrazonsocial.Text == "" || txttelefono.Text == "")
                    MessageBox.Show("Le falta escribir algunos datos.", "Error:", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                else
                {

                    string dtme = Convert.ToString(DateTime.Now.ToShortDateString());
                    DateTime fecha = Convert.ToDateTime(dtme);
                    string agregar = "Insert into Empresa (Emp_Nombre,Emp_Cedula,Emp_Direccion,Emp_Email,Emp_Telefono,Emp_Mision,Emp_Razon_Social,Emp_Fecha_Actualizacion) Values  ('" + txtempresa.Text + "','" + txtcedula.Text + "','" + txtdireccion.Text + "','" + txtemail.Text + "','" + txttelefono.Text + "','" + txtmision.Text + "','" + txtrazonsocial.Text + "','" + fecha.ToString("yyyy-MM-dd hh:mm") + "')";

                    if (bdatos.executecommand(agregar))
                    {
                        MessageBox.Show("Registro agregado correctamente");
                        dgvempresa.DataSource = bdatos.SelectDataTable("Select Emp_id,Emp_Nombre,Emp_Cedula,Emp_Direccion,Emp_Email,Emp_Telefono,Emp_Mision,Emp_Razon_Social,Emp_Fecha_Actualizacion From Empresa");
                        this.limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar");
                    }
                }

                //else
                //{

                //    DateTime fecha = Convert.ToDateTime(DateTime.Now.ToLocalTime());
                //    SqlConnection conexion = basedatos.conexionsql();
                //    conexion.Open();
                //    string comado = "insert into Empresa (Emp_Nombre,Emp_Cedula,Emp_Direccion,Emp_Email,Emp_Telefono,Emp_Mision,Emp_Razon_Social,Emp_Fecha_Actualizacion) values (@Emp_Nombre,@Emp_Cedula,@Emp_Direccion,@Emp_Email,@Emp_Telefono,@Emp_Mision,@Emp_Razon_Social,@Emp_Fecha_Actualizacion);";
                //    SqlCommand micomando = new SqlCommand(comado, conexion);
                //    micomando.Parameters.Add("@Emp_Nombre", SqlDbType.VarChar, 200).Value = txtempresa.Text;
                //    micomando.Parameters.Add("@Emp_Cedula", SqlDbType.VarChar, 100).Value = txtcedula.Text;
                //    micomando.Parameters.Add("@Emp_Direccion", SqlDbType.VarChar, 100).Value = txtdireccion.Text;
                //    micomando.Parameters.Add("@Emp_Email", SqlDbType.VarChar, 100).Value = txtemail.Text;
                //    micomando.Parameters.Add("@Emp_Telefono", SqlDbType.VarChar, 100).Value = txttelefono.Text;
                //    micomando.Parameters.Add("@Emp_Mision", SqlDbType.VarChar, 20).Value = txtmision.Text;
                //    micomando.Parameters.Add("@Emp_Razon_Social", SqlDbType.VarChar, 300).Value = txtrazonsocial.Text;        
                //    micomando.Parameters.Add("@Emp_Fecha_Actualizacion", DateTime.Today).Value = fecha;
                //    micomando.ExecuteNonQuery();
                //    conexion.Close();
                //    MessageBox.Show("Registro insertado correctamente");
                //    limpiar();
                //}

            }//try
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }//catch
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtempresaid.Text == "")
                {
                    MessageBox.Show("Igrese un valor");
                }
                else
                {
                    dgvempresa.DataSource = bdatos.SelectDataTable("Select Emp_id,Emp_Nombre,Emp_Cedula,Emp_Direccion,Emp_Email,Emp_Telefono,Emp_Mision,Emp_Razon_Social,Emp_Fecha_Actualizacion From Empresa where Emp_id = " + txtempresaid.Text);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Empresa_Load(object sender, EventArgs e)
        {
           dgvempresa.DataSource = bdatos.SelectDataTable("Select Emp_id,Emp_Nombre,Emp_Cedula,Emp_Direccion,Emp_Email,Emp_Telefono,Emp_Mision,Emp_Razon_Social,Emp_Fecha_Actualizacion From Empresa");
         
        }

        private void dgvempresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgvempresa.Rows[e.RowIndex];

                txtempresa_id.Text = dgv.Cells[0].Value.ToString();
                txtempresa.Text = dgv.Cells[1].Value.ToString();
                txtcedula.Text = dgv.Cells[2].Value.ToString();
                txtdireccion.Text = dgv.Cells[3].Value.ToString();
                txtemail.Text = dgv.Cells[4].Value.ToString();
                txttelefono.Text = dgv.Cells[5].Value.ToString();
                txtmision.Text = dgv.Cells[6].Value.ToString();
                txtrazonsocial.Text = dgv.Cells[7].Value.ToString();
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
                if (txtempresa_id.Text == "")
                {
                    MessageBox.Show("ingrese un numero de sucursal.", "Error:", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                else
                {
                    string actualizar = "update Empresa set Emp_Nombre = '" + txtempresa.Text
                                             + "',Emp_Cedula = '" + txttelefono.Text
                                             + "',Emp_Direccion = '" + txtdireccion.Text
                                             + "' ,Emp_Email= '" + txtemail.Text
                                             + "',Emp_Telefono= '" + txttelefono.Text
                                             + "',Emp_Mision = '" + txtmision.Text
                                             + "',Emp_Razon_Social = '" + txtrazonsocial.Text
                                             + "',Emp_Fecha_Actualizacion = '" + fecha.ToString("yyyy-MM-dd hh:mm")
                                             + "' where Emp_id = " + txtempresa_id.Text;

                    if (bdatos.executecommand(actualizar))
                    {
                        MessageBox.Show("Registro actualizado correctamente");
                        dgvempresa.DataSource = bdatos.SelectDataTable("Select Emp_id,Emp_Nombre,Emp_Cedula,Emp_Direccion,Emp_Email,Emp_Telefono,Emp_Mision,Emp_Razon_Social,Emp_Fecha_Actualizacion From Empresa");
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   
}

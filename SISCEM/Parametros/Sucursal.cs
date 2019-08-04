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
    public partial class Sucursal : Form
    {
        private static Sucursal m_FormDefInstanceSucursal;
        public static Sucursal DefInstance
        {
            get
            {
                if (m_FormDefInstanceSucursal == null || m_FormDefInstanceSucursal.IsDisposed)
                    m_FormDefInstanceSucursal = new Sucursal();
                return m_FormDefInstanceSucursal;
            }
            set
            {
                m_FormDefInstanceSucursal = value;
            }
        }


        BD basedatos = new BD();
        BaseDeDatos bdatos = new BaseDeDatos();
               
        public Sucursal()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtnombre.Text = "";
            txtemail.Text = "";
            txtdireccion.Text = "";
            txtcedula.Text = "";
            txtrazonsocial.Text = "";
            txttelefono.Text = "";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtnombre.Text == "" || txtemail.Text == "" || txtdireccion.Text == "" || txtcedula.Text == "" || txtrazonsocial.Text == "" || txttelefono.Text == "")
                    MessageBox.Show("Le falta escribir algunos datos.", "Error:", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                else
                {

                    string dtme = Convert.ToString(DateTime.Now.ToShortDateString());
                    DateTime fecha = Convert.ToDateTime(dtme);
                    string agregar = "Insert into Sucursal (Emp_Id,Suc_Regimen_Nombre,Suc_Regimen_Telefono,Suc_Regimen_email,Suc_Regimen_Cedula_Juridica,Suc_Regimen_Razon_Social,Suc_Regimen_Direccion,Suc_Activo,Suc_Fec_Actualizacion) Values  (1,'" + txtnombre.Text + "','" + txttelefono.Text + "','" + txtemail.Text + "','" + txtcedula.Text + "','"  + txtrazonsocial.Text + "','" + txtdireccion.Text + "','" + txtactivo.Text + "','" + fecha.ToString("yyyy-MM-dd hh:mm") + "')";

                    if (bdatos.executecommand(agregar))
                    {
                        MessageBox.Show("Registro agregado correctamente");
                        dgvsucursal.DataSource = bdatos.SelectDataTable("select  suc_id,Suc_Regimen_Nombre,suc_Regimen_Telefono,Suc_Regimen_email,Suc_Regimen_Cedula_Juridica,Suc_Regimen_Razon_Social,Suc_Regimen_Direccion,Suc_Activo,Suc_Fec_Actualizacion from Sucursal");
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
                //    string comado = "Insert into Sucursal (Emp_Id,Suc_Regimen_Nombre,Suc_Regimen_Telefono,Suc_Regimen_email,Suc_Regimen_Cedula_Juridica,Suc_Regimen_Razon_Social,Suc_Regimen_Direccion,Suc_Activo,Suc_Fec_Actualizacion) Values (@Emp_Id,@Suc_Regimen_Nombre,@Suc_Regimen_Telefono,@Suc_Regimen_email,@Suc_Regimen_Cedula_Juridica,@Suc_Regimen_Razon_Social,@Suc_Regimen_Direccion,@Suc_Activo,@Suc_Fec_Actualizacion);";
                //    SqlCommand micomando = new SqlCommand(comado, conexion);
                //    micomando.Parameters.Add("@Emp_Id", SqlDbType.VarChar, 200).Value =1;
                //    micomando.Parameters.Add("@Suc_Regimen_Nombre", SqlDbType.VarChar, 100).Value = txtnombre.Text;
                //    micomando.Parameters.Add("@Suc_Regimen_Telefono", SqlDbType.VarChar, 20).Value = txttelefono.Text;
                //    micomando.Parameters.Add("@Suc_Regimen_Cedula_Juridica", SqlDbType.VarChar, 50).Value = txtcedula.Text;
                //    micomando.Parameters.Add("@Suc_Regimen_Razon_Social", SqlDbType.VarChar, 200).Value = txtrazonsocial.Text;
                //    micomando.Parameters.Add("@Suc_Regimen_Direccion", SqlDbType.VarChar, 200).Value = txtdireccion.Text;
                //    micomando.Parameters.Add("@Suc_Activo", SqlDbType.Bit).Value = txtactivo.Text; 
                //    micomando.Parameters.Add("@Suc_Fec_Actualizacion", DateTime.Today).Value = fecha;
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

       

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                string dtme = Convert.ToString(DateTime.Now.ToShortDateString());
                DateTime fecha = Convert.ToDateTime(dtme);
                if (txtidsucursal.Text == "")
                {
                    MessageBox.Show("ingrese un numero de sucursal.", "Error:", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                else
                {
                    //string actualizar = "update sucursal set Suc_Regimen_Nombre = '" + txtnombre.Text + "',suc_Regimen_Telefono = '" + txttelefono.Text + "',Suc_Regimen_email = '" + txtemail.Text + "' ,Suc_Regimen_Cedula_Juridica= '" + txtcedula.Text + "',Suc_Regimen_Razon_Social= '" + txtrazonsocial.Text + "',Suc_Regimen_Direccion = '" + txtdireccion.Text + "',Suc_Activo = " + chkactivo.Checked.ToString() + ",Suc_Fec_Actualizacion = '" + fecha.ToString("yyyy-MM-dd hh:mm") + "' where suc_id = " + txtidsucursal.Text;
                    string actualizar = "update sucursal set Suc_Regimen_Nombre = '" + txtnombre.Text + "',suc_Regimen_Telefono = '" + txttelefono.Text + "',Suc_Regimen_email = '" + txtemail.Text + "' ,Suc_Regimen_Cedula_Juridica= '" + txtcedula.Text + "',Suc_Regimen_Razon_Social= '" + txtrazonsocial.Text + "',Suc_Regimen_Direccion = '" + txtdireccion.Text + "',Suc_Activo = " + txtactivo.Text + ",Suc_Fec_Actualizacion = '" + fecha.ToString("yyyy-MM-dd hh:mm") + "' where suc_id = " + txtidsucursal.Text;

                    if (bdatos.executecommand(actualizar))
                    {
                        MessageBox.Show("Registro actualizado correctamente");
                        dgvsucursal.DataSource = bdatos.SelectDataTable("select  suc_id,Suc_Regimen_Nombre,suc_Regimen_Telefono,Suc_Regimen_email,Suc_Regimen_Cedula_Juridica,Suc_Regimen_Razon_Social,Suc_Regimen_Direccion,Suc_Activo,Suc_Fec_Actualizacion from Sucursal");
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
                if (txtsuc_id.Text == "")
                {
                    MessageBox.Show("Igrese un valor");
                }
                else
                {
                    dgvsucursal.DataSource = bdatos.SelectDataTable("select  suc_id,Suc_Regimen_Nombre,suc_Regimen_Telefono,Suc_Regimen_email,Suc_Regimen_Cedula_Juridica,Suc_Regimen_Razon_Social,Suc_Regimen_Direccion,Suc_Activo,Suc_Fec_Actualizacion from Sucursal where Suc_id = " + txtsuc_id.Text);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sucursal_Load(object sender, EventArgs e)
        {
            dgvsucursal.DataSource = bdatos.SelectDataTable("select  suc_id,Suc_Regimen_Nombre,suc_Regimen_Telefono,Suc_Regimen_email,Suc_Regimen_Cedula_Juridica,Suc_Regimen_Razon_Social,Suc_Regimen_Direccion,case Suc_Activo when 'true' then 1 else 0 end Suc_Activo,Suc_Fec_Actualizacion from Sucursal");
        }

        private void dgvsucursal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgvsucursal.Rows[e.RowIndex];

                txtidsucursal.Text = dgv.Cells[0].Value.ToString();
                txtnombre.Text = dgv.Cells[1].Value.ToString();
                txttelefono.Text = dgv.Cells[2].Value.ToString();
                txtemail.Text = dgv.Cells[3].Value.ToString();
                txtcedula.Text = dgv.Cells[4].Value.ToString();
                txtrazonsocial.Text = dgv.Cells[5].Value.ToString();
                txtdireccion.Text = dgv.Cells[6].Value.ToString();
                txtactivo.Text = dgv.Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un valor");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

                      
    }
}

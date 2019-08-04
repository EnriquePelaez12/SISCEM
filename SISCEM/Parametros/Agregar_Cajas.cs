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
    public partial class Agregar_Cajas : Form
    {
        private static Agregar_Cajas m_FormDefInstanceAgregar_Cajas;
        public static Agregar_Cajas DefInstance
        {
            get
            {
                if (m_FormDefInstanceAgregar_Cajas == null || m_FormDefInstanceAgregar_Cajas.IsDisposed)
                    m_FormDefInstanceAgregar_Cajas = new Agregar_Cajas();
                return m_FormDefInstanceAgregar_Cajas;
            }
            set
            {
                m_FormDefInstanceAgregar_Cajas = value;
            }
        }


        BaseDeDatos bdatos = new BaseDeDatos();
        public Agregar_Cajas()
        {
            InitializeComponent();
        }

        private void Agregar_Cajas_Load(object sender, EventArgs e)
        {

            dgvcaja.DataSource = bdatos.SelectDataTable("select Caja_id,Suc_id,rol_id,Caja_nombre from Caja");
            
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcajaid.Text == "")
                {
                    MessageBox.Show("ingrese un numero de caja.", "Error:", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                else
                {
                    string actualizar = "update Caja set suc_id = " + txtsucursal.Text + ",Caja_nombre = '" + txtnombre.Text + "',Rol_id = " + txtrol.Text + " where Caja_id = " + txtcajaid.Text;

                    if (bdatos.executecommand(actualizar))
                    {
                        MessageBox.Show("Registro actualizado correctamente");
                        dgvcaja.DataSource = bdatos.SelectDataTable("select Caja_id,Suc_id,rol_id,Caja_nombre from caja");
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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (txtcajaid.Text == "")
            {
                MessageBox.Show("ingrese un numero de caja.", "Error:", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            else
            {

                string eliminar = "delete Caja where Caja_id = " + txtid.Text;

                if (bdatos.executecommand(eliminar))
                {
                    MessageBox.Show("Registro eliminado correctamente");
                    dgvcaja.DataSource = bdatos.SelectDataTable("select * from Caja");
                }
                else
                {
                    MessageBox.Show("Error al eliminar");
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtcajaid.Text==""|| txtnombre.Text == "" || txtrol.Text=="" || txtsucursal.Text=="")
                        MessageBox.Show("Llene los campos faltantes.", "Error:", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                     
            else
            {

                string dtme = Convert.ToString(DateTime.Now.ToShortDateString());
                DateTime fecha = Convert.ToDateTime(dtme);
                string agregar = "insert into Caja (Emp_id,suc_id,Caja_id,rol_id,Caja_nombre,Caja_Fec_Actualizacion ) values (1," + txtsucursal.Text + "," + txtcajaid.Text + "," + txtrol.Text + ",'" + txtnombre.Text + "','" + fecha.ToString("yyyy-MM-dd hh:mm") + "')";

                if (bdatos.executecommand(agregar))
                {
                    MessageBox.Show("Registro agregado correctamente");
                    dgvcaja.DataSource = bdatos.SelectDataTable("select Caja_id,Suc_id,rol_id,Caja_nombre from caja");
                    this.limpiar();
                }
                else
                {
                    MessageBox.Show("Error al agregar");
                }
            }
        }

        private void limpiar()
        {
            txtcajaid.Text = "";
            txtid.Text = "";
            txtnombre.Text = "";
            txtrol.Text = "";
            txtsucursal.Text="";
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.limpiar();
            dgvcaja.DataSource = bdatos.SelectDataTable("select Caja_id,Suc_id,rol_id,Caja_nombre from caja");
        }

        private void dgvcaja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgvcaja.Rows[e.RowIndex];
                txtcajaid.Text = dgv.Cells[0].Value.ToString();
                txtsucursal.Text = dgv.Cells[1].Value.ToString();
                txtrol.Text = dgv.Cells[2].Value.ToString();
                txtnombre.Text = dgv.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un valor");
            }
            
            
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text == "")
                {
                    MessageBox.Show("Igrese un valor");
                }
                else
                {
                    dgvcaja.DataSource = bdatos.SelectDataTable("select  Caja_id,Suc_id,rol_id,Caja_nombre from Caja where caja_id = " + txtid.Text);
                }

            }
             
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SISCEM
{
    public partial class Ingresos : Form
    {
        public Ingresos()
        {
            InitializeComponent();
        }

         private static Ingresos m_FormDefInstanceIngresos;
        public static Ingresos DefInstance
        {
            get
            {
                if (m_FormDefInstanceIngresos == null || m_FormDefInstanceIngresos.IsDisposed)
                    m_FormDefInstanceIngresos = new Ingresos();
                return m_FormDefInstanceIngresos;
            }
            set
            {
                m_FormDefInstanceIngresos = value;
            }
        }

        BaseDeDatos bdatos = new BaseDeDatos();

        private void Ingresos_Load(object sender, EventArgs e)
        {
            dgvconcepto.DataSource = bdatos.SelectDataTable("select concepto_id,concepto,importe,Fecha_actualizacion from Ingresos");
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtconcepto.Text = "";
            txtimporte.Text = "";
        }

        private void limpiar ()
        {
            txtconcepto.Text = "";
            txtimporte.Text = "";
            lblaeliminar.Text = "";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
              if (txtconcepto.Text == "" || txtimporte.Text == "")
                MessageBox.Show("Llene los campos faltantes.", "Error:", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

            else
            {

                string dtme = Convert.ToString(DateTime.Now.ToShortDateString());
                DateTime fecha = Convert.ToDateTime(dtme);
                string agregar = "insert into Ingresos (Concepto,Importe,Fecha_Actualizacion ) values ('" + txtconcepto.Text + "'," + txtimporte.Text + ",'" + fecha.ToString("yyyy-MM-dd hh:mm") + "')";
                if (bdatos.executecommand(agregar))
                {
                    MessageBox.Show("Registro agregado correctamente");
                    dgvconcepto.DataSource = bdatos.SelectDataTable("select concepto_id,concepto,importe,Fecha_actualizacion from Ingresos");
                    this.limpiar();
                }
                else
                {
                    MessageBox.Show("Error al agregar");
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if(lblaeliminar.Text=="")
            {
                MessageBox.Show("Seleccione un registro a eliminar");
            }
            else
            {                

                string eliminaregistro = ("Delete From Ingresos where Concepto_id= " + lblaeliminar.Text);
                bdatos.executecommand(eliminaregistro);

                dgvconcepto.DataSource = bdatos.SelectDataTable("select concepto_id,concepto,importe,fecha_actualizacion From ingresos ");
                this.limpiar();
            }
           
        }

        private void dgvconcepto_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             try
            {

                DataGridViewRow id_detalle = dgvconcepto.Rows[e.RowIndex];
                lblaeliminar.Text = id_detalle.Cells[0].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("No existe registros que cargar ");
            }
        }
        
    }
}

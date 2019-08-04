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
    public partial class Busqueda_Cliente : Form
    {
        private static Busqueda_Cliente m_FormDefInstanceBusqueda_Cliente;
        public static Busqueda_Cliente DefInstance
        {
            get
            {
                if (m_FormDefInstanceBusqueda_Cliente == null || m_FormDefInstanceBusqueda_Cliente.IsDisposed)
                    m_FormDefInstanceBusqueda_Cliente = new Busqueda_Cliente();
                return m_FormDefInstanceBusqueda_Cliente;
            }
            set
            {
                m_FormDefInstanceBusqueda_Cliente = value;
            }
        }

        BaseDeDatos bdatos = new BaseDeDatos();

        // propiedad
        public string id { get; set; }
        public string Nombre { get; set; }
        public string Cotitular { get; set; }
        public string Direccion { get; set; }
        public string email { get; set; }
        

        public Busqueda_Cliente()
        {
            InitializeComponent();
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            dgvcliente.DataSource = bdatos.SelectDataTable(" Select Cliente_id,Cliente_Nombre,Cotitular,Cliente_Direccion,Cliente_Email" +                                                            
                                                           " From Cliente where Cliente_nombre like '%"+ txtnombre.Text+"%'");

            
            //Empeño.DefInstance.Parent= this;
            //Empeño.DefInstance.Show();
        }

        private void dgvcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgvcliente.Rows[e.RowIndex];
                txtid.Text = dgv.Cells[0].Value.ToString();
                id = dgv.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Seleccione un valor");
            }
            
        }
                
        private void btnsalir_Click(object sender, EventArgs e)
        {   
            DialogResult = DialogResult.OK; //cierra el formulario

            this.Close();
        }

        private void dgvcliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int valor;
                valor = Convert.ToInt32(txtid.Text);
                if (valor > 0)
                {

                    DataGridViewRow dgv = dgvcliente.Rows[e.RowIndex];
                    txtid.Text = dgv.Cells[0].Value.ToString();
                    id = dgv.Cells[0].Value.ToString();
                    Nombre = dgv.Cells[1].Value.ToString();
                    Cotitular = dgv.Cells[2].Value.ToString();
                    Direccion = dgv.Cells[3].Value.ToString();
                    email = dgv.Cells[4].Value.ToString();
                    DialogResult = DialogResult.OK; //cierra el formulario
                    this.Close();
                    //this.Close();

                }
            }
            
            catch (Exception)
            {

                MessageBox.Show("Verifique a su Administrador", "Error:", MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
            }     
           
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.btnseleccionar.Select();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblnombre_Click(object sender, EventArgs e)
        {

        }

        private void Busqueda_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

               
    }
}

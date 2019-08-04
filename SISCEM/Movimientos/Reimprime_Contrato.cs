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
    public partial class Reimprime_Contrato : Form
    {
        private static Reimprime_Contrato m_FormDefInstanceReimprime_Contrato;

        public static Reimprime_Contrato DefInstance
        {
            get
            {
                if (m_FormDefInstanceReimprime_Contrato == null || m_FormDefInstanceReimprime_Contrato.IsDisposed)
                    m_FormDefInstanceReimprime_Contrato = new Reimprime_Contrato();
                return m_FormDefInstanceReimprime_Contrato;
            }
            set
            {
                m_FormDefInstanceReimprime_Contrato = value;
            }
        }

        public Reimprime_Contrato()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtprestamo.Text = "";
            txtboleta_id.Text = "";
            txtcliente.Text = "";
            txtcliente_id.Text = "";
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtboleta_id.Text !="")
                {                    
                        BD basedatos = new BD();
                        SqlConnection conexion;
                        //Creando conexion
                        conexion = basedatos.conexionsql();
                        //Abriendo conexion
                        conexion.Open();
                        SqlCommand comando = new SqlCommand("Select A.Cliente_id,A.cliente_nombre,b.Prestamo from Cliente A,Boleta_encabezado B Where A.Cliente_id=B.Cliente_id And B.Estado='Vigente' And B.Boleta_id=" + txtboleta_id.Text + "", conexion);
                        SqlDataReader dr = comando.ExecuteReader();

                        if (dr.Read())
                        {
                            txtcliente_id.Text = dr[0].ToString();
                            txtcliente.Text = dr[1].ToString();
                            txtprestamo.Text = dr[2].ToString();
                            
                        }
                        else { MessageBox.Show("La boleta no existe"); txtboleta_id.ReadOnly = false; }
                        
                }
                else
                {
                    MessageBox.Show("Ingrese el número de boleta");
                }                
            }
            catch (Exception)
            {

                MessageBox.Show("Verifica la informacion introducida");
                this.limpiar();
            }
        }

        private void Reimprime_Contrato_Load(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            Reimpresionrpt empe = new Reimpresionrpt();
            empe.boleta_id = Convert.ToInt32(txtboleta_id.Text);
            empe.cliente_id = Convert.ToInt32(txtcliente_id.Text);
            empe.ShowDialog(this);
            empe.Dispose();
            empe = null;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

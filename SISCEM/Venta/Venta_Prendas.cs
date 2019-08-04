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
    public partial class Venta_Prendas : Form
    {
        BD basedatos = new BD();
        BaseDeDatos bdatos = new BaseDeDatos();
        private static Venta_Prendas m_FormDefInstanceVenta_Prendas;
        public static Venta_Prendas DefInstance
        {
            get
            {
                if (m_FormDefInstanceVenta_Prendas == null || m_FormDefInstanceVenta_Prendas.IsDisposed)
                    m_FormDefInstanceVenta_Prendas = new Venta_Prendas();
                return m_FormDefInstanceVenta_Prendas;
            }
            set
            {
                m_FormDefInstanceVenta_Prendas = value;
            }
        }

        private void numero_Venta()
        {
            try
            {
                string contador;
                SqlConnection Conexion = basedatos.conexionsql();
                Conexion.Open();
                string sql = "select max(Venta_Id) as Venta_Id from Venta";

                SqlCommand command = new SqlCommand(sql, Conexion);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    contador = Convert.ToString(reader["Venta_Id"]);
                    lblid.Text = Convert.ToString(Convert.ToInt32(contador) + 1);
                }
                Conexion.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Venta_Prendas()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            
            txtcategoria.Text = "";
            txtdescripcion.Text = "";
            txtpeso.Text = "";
            txtpiedra.Text = "";
            txttotal.Text = "";
            txtboleta.Text = "";
            txtcodigo.Text = "";
            txtkilataje.Text = "";
            txtcliente_id.Text = "";
            txtnombre_cliente.Text = "";
            txtcodigo.ReadOnly = false;
            txtcliente_id.ReadOnly = false;

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {

            
            if (txtcodigo.Text != "")
            {
                BD basedatos = new BD();
                string prestamo ="";
                SqlConnection conexion;
                //Creando conexion
                conexion = basedatos.conexionsql();
                //Abriendo conexion
                conexion.Open();
                SqlCommand comando = new SqlCommand(" select Boleta_id,Categoria_Nombre,kilateje,Peso,peso_piedra,Descripcion,prestamo  From  Desglose_Boleta Where Codigo_id=" + txtcodigo.Text + " And Estatus='Activo' ", conexion);
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    txtboleta.Text = dr[0].ToString();
                    txtcategoria.Text = dr[1].ToString();
                    txtkilataje.Text = dr[2].ToString();
                    txtpeso.Text = dr[3].ToString();
                    txtpiedra.Text = dr[4].ToString();
                    txtdescripcion.Text = dr[5].ToString();
                    prestamo = dr[6].ToString();

                    string comercializacion = " Select importe from Interes where Interes_Nombre='Comercializacion'";

                    string importecomercialiacion = Convert.ToString(bdatos.selectstring(comercializacion));
                    double comer = 0;
                    comer = Convert.ToDouble(importecomercialiacion);
                    comer = comer / 100;
                    double importe = Convert.ToDouble(prestamo);
                    double total = comer * importe;
                    txttotal.Text = Convert.ToString(total + importe);
                   // txtcodigo.ReadOnly = true;
                }
                else { MessageBox.Show("No existen el codigo"); this.limpiar(); }
           
            }
            else
            {
                MessageBox.Show("Ingrese el código de la prenda");

            }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique la informacion ingresada ");
                txtcodigo.Text = "";
                
            }
        }

        private void insertaventa()
        {
            try
            {

                if (txtboleta.Text == "" || txtcategoria.Text == "" || txtkilataje.Text == "" || txtpeso.Text == "" || txtpiedra.Text == "" || txtdescripcion.Text == "" || txttotal.Text == "" )
                    MessageBox.Show("Ingrese un codigo.", "Error:", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                else
                {
                    string dtme = Convert.ToString(DateTime.Now.ToShortDateString());
                    DateTime fecha = Convert.ToDateTime(dtme);
                    string agregar = "Insert into Venta (Boleta_Id,Categoria_Nombre,Cliente_Nombre,Kilataje,Descripcion,Peso,Peso_Piedra,Total,Fecha,Usuario_Id) " +
                                      " Values  (" + txtboleta.Text + ",'" + txtcategoria.Text + "','" + txtnombre_cliente.Text + "','" + txtkilataje.Text + "','" + txtdescripcion.Text + "','" + txtpeso.Text + "','" + txtpiedra.Text + "','" + txttotal.Text + "','" + fecha.ToString("yyyy-MM-dd hh:mm") + "'," + Program.UsuarioId + ")";

                    if (bdatos.executecommand(agregar))
                    {
                        string actualizar = "update desglose_boleta set Estatus = 'Baja'  where Codigo_id = " + txtcodigo.Text;

                        if (bdatos.executecommand(actualizar))
                        {
                           // MessageBox.Show("Codigo dado de bajo correctamente");

                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar");
                        }
                       

                        //MessageBox.Show("Registro agregado correctamente");
                       
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


        private void btnprocesar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtcodigo.Text != "" && txtcliente_id.Text != "" && txtnombre_cliente.Text != "")
                {
                    Ventarpt rptventa = new Ventarpt();
                    rptventa.codigo = Convert.ToInt32(txtcodigo.Text);
                    rptventa.Cliente = Convert.ToInt32(txtcliente_id.Text);
                    rptventa.Total = txttotal.Text;
                    rptventa.ShowDialog(this);
                    insertaventa();
                    rptventa.Dispose();

                    Gurda_PDF datos = new Gurda_PDF();
                    datos.Boleta = lblid.Text;
                    datos.Cliente = txtnombre_cliente.Text;
                    datos.Nombre = lblnombre.Text;
                    datos.Movimiento = lblventa.Text;
                    datos.ShowDialog(this);
                    datos.Dispose();

                    this.limpiar();
                    
                }
                else { MessageBox.Show("Ingrese un codigo valido"); }
            }
            catch (Exception)
            {

                MessageBox.Show("Error el generar el proceso");
           }
            
        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            try
            {
            Busqueda_Cliente busqueda = new Busqueda_Cliente();
            if (busqueda.ShowDialog() == DialogResult.OK)                
            txtcliente_id.Text = busqueda.id;
            txtnombre_cliente.Text = busqueda.Nombre;
            txtcliente_id.ReadOnly = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Error al ingresar a la busqued de clientes");
            }
            
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.btnbuscar.Select();
            }
           
        }

        private void txtcliente_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {

                    DataSet ds = bdatos.SelectDataSet("Select cliente_nombre from Cliente where cliente_id= " + txtcliente_id.Text + "", "Cliente");
                    txtnombre_cliente.Text = ds.Tables[0].Rows[0]["Cliente_nombre"].ToString();
                    txtcliente_id.ReadOnly = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese un cliente valido");
                txtcliente_id.Text = "";
                txtnombre_cliente.Text = "";
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void Venta_Prendas_Load(object sender, EventArgs e)
        {
            numero_Venta();
            lblusuario.Text = "Cajero: " + Program.Usuario;
        }
    }
}

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
    public partial class Actualiza_Kilates : Form
    {
        BD basedatos = new BD();
        BaseDeDatos bdatos = new BaseDeDatos();
        private static Actualiza_Kilates m_FormDefInstanceActualiza_Kilates;
        public static Actualiza_Kilates DefInstance
        {
            get
            {
                if (m_FormDefInstanceActualiza_Kilates == null || m_FormDefInstanceActualiza_Kilates.IsDisposed)
                    m_FormDefInstanceActualiza_Kilates = new Actualiza_Kilates();
                return m_FormDefInstanceActualiza_Kilates;
            }
            set
            {
                m_FormDefInstanceActualiza_Kilates = value;
            }
        }

        public Actualiza_Kilates()
        {
            InitializeComponent();
        }

        //private void llenagrid()
        //{

        //    SqlConnection conexion = basedatos.conexionsql();
        //    conexion.Open();
        //    SqlCommand comando = new SqlCommand("Select kilataje_id,kilataje_valor,precio_compra,precio_venta From kilataje order by kilataje_id;", conexion);
        //    SqlDataAdapter dataAdaptador = new SqlDataAdapter(comando);
        //    DataSet ds = new DataSet();
        //    dataAdaptador.Fill(ds, "kilataje");
        //    dgvctalalogo.DataSource = ds.Tables[0];

        //}

        private void Actualiza_Kilates_Load(object sender, EventArgs e)
        {

            dgvkilataje.DataSource = bdatos.SelectDataTable("Select kilataje_id,kilataje_valor,Precio_compra,Precio_venta,Fec_Actualizacion From kilataje");

        }

        private void limpiar()
        {
            txtidkilate.Text = "";
            txtkilatajeid.Text = "";
            txtpreciocompra.Text = "";
            txtprecioventa.Text = "";
            txtvalor.Text = "";

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtidkilate.Text == "")
                {
                    MessageBox.Show("Igrese un valor");
                }
                else
                {
                    dgvkilataje.DataSource = bdatos.SelectDataTable("Select kilataje_id,kilataje_valor,Precio_compra,Precio_venta,Fec_Actualizacion From kilataje where kilataje_id = " + txtidkilate.Text);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvkilataje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgvkilataje.Rows[e.RowIndex];

                txtkilatajeid.Text = dgv.Cells[0].Value.ToString();
                txtvalor.Text = dgv.Cells[1].Value.ToString();
                txtpreciocompra.Text = dgv.Cells[2].Value.ToString();
                txtprecioventa.Text = dgv.Cells[3].Value.ToString();
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
                if (txtkilatajeid.Text == "")
                {
                    MessageBox.Show("ingrese un numero de kilataje.", "Error:", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                else
                {
                    string actualizar = "update kilataje set kilataje_valor = '" + txtvalor.Text
                                             + "',Categoria_id = '" + 1
                                             + "',Precio_compra = '" + txtpreciocompra.Text
                                             + "' ,Precio_venta= '" + txtprecioventa.Text
                                             + "',Fec_Actualizacion = '" + fecha.ToString("yyyy-MM-dd hh:mm")
                                             + "' where kilataje_id = " + txtkilatajeid.Text;


                    if (bdatos.executecommand(actualizar))
                    {
                        MessageBox.Show("Registro actualizado correctamente");
                        dgvkilataje.DataSource = bdatos.SelectDataTable("Select kilataje_id,kilataje_valor,Precio_compra,Precio_venta,Fec_Actualizacion From kilataje");
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
                MessageBox.Show("Error al actualizar");
            }
            }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtvalor.Text == "" || txtprecioventa.Text == "" || txtpreciocompra.Text == "")
                    MessageBox.Show("Le falta escribir algunos datos.", "Error:", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                else
                {

                    string dtme = Convert.ToString(DateTime.Now.ToShortDateString());
                    DateTime fecha = Convert.ToDateTime(dtme);
                    string agregar = "Insert into kilataje (kilataje_valor,Categoria_id,Precio_compra,Precio_venta,Fec_Actualizacion) Values  (" + txtvalor.Text + "," + 1 + "," + txtpreciocompra.Text + "," + txtprecioventa.Text + ",'" + fecha.ToString("yyyy-MM-dd hh:mm") + "')";

                    if (bdatos.executecommand(agregar))
                    {
                        MessageBox.Show("Registro agregado correctamente");
                        dgvkilataje.DataSource = bdatos.SelectDataTable("Select kilataje_id,kilataje_valor,Precio_compra,Precio_venta,Fec_Actualizacion From kilataje");
                        this.limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar");
            }

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }


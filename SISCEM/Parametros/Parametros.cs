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
    public partial class Parametros : Form
    {
        public Parametros()
        {
            InitializeComponent();
        }

         BD basedatos = new BD();
        BaseDeDatos bdatos = new BaseDeDatos();
        private static Parametros m_FormDefInstanceParametros;

        public static Parametros DefInstance
        {
            get
            {
                if (m_FormDefInstanceParametros == null || m_FormDefInstanceParametros.IsDisposed)
                    m_FormDefInstanceParametros = new Parametros();
                return m_FormDefInstanceParametros;
            }
            set
            {
                m_FormDefInstanceParametros = value;
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (txttasainteresanual.Text == "" || txtcomercializacion.Text=="" || txtcostoanualtotal.Text=="" || txtdesempeñoextemporaneo.Text=="" || txtelectronicos.Text=="" || txtoro.Text=="" || txtreposicioncontrato.Text=="" || txttasainteresanual.Text=="" )
                {
                    MessageBox.Show("Todos los campos deben estar llenos.", "Error:", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                else
                {
                    string actualizar = "Update intereses Set Tasa_Interes_Anual ='" + txttasainteresanual.Text
	                                    +"',Costo_Anual_Total='" + txtcostoanualtotal.Text
	                                    +"',Oro='" + txtoro.Text
	                                    +"',Electronicos='" + txtelectronicos.Text
	                                    +"',Almacenaje='" + txtalmacenaje.Text
	                                    +"',Comercializacion='" + txtcomercializacion.Text
	                                    +"',Desempenio_Extemporaneo='" + txtdesempeñoextemporaneo.Text
	                                    +"',Reposicion_contrato='" + txtreposicioncontrato.Text +"'";

                    if (bdatos.executecommand(actualizar))
                    {
                        MessageBox.Show("Registro actualizado correctamente");                        
                        
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

        private void Carga_parametros()
        {
                    try
                    {
                    
                        BD basedatos = new BD();
                        SqlConnection conexion;
                        //Creando conexion
                        conexion = basedatos.conexionsql();
                        //Abriendo conexion
                        conexion.Open();
                        SqlCommand comando = new SqlCommand("Select Tasa_Interes_Anual,Costo_Anual_Total,Oro,Electronicos,Almacenaje,Comercializacion,Desempenio_Extemporaneo,Reposicion_contrato from intereses", conexion);
                        SqlDataReader dr = comando.ExecuteReader();

                        if (dr.Read())
                        {
                            txttasainteresanual.Text =  dr[0].ToString();
                            txtcostoanualtotal.Text = dr[1].ToString();
                            txtoro.Text = dr[2].ToString();
                            txtelectronicos.Text = dr[3].ToString();
                            txtalmacenaje.Text = dr[4].ToString();
                            txtcomercializacion.Text = dr[5].ToString();
                            txtdesempeñoextemporaneo.Text = dr[6].ToString();
                            txtreposicioncontrato.Text = dr[7].ToString();
                        }
                   }

            catch (Exception)
            {

                MessageBox.Show("Error al cargar los datos", "Error:", MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
            }  
        }

        private void Parametros_Load(object sender, EventArgs e)
        {
            this.Carga_parametros();
        }

        }
    }


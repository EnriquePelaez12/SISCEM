using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SISCEM
{
    public partial class Movimientos : Form
    {
        public Movimientos()
        {
            InitializeComponent();
        }

        private static Movimientos m_FormDefInstanceMovimientos;

        public static Movimientos DefInstance
        {
            get
            {
                if (m_FormDefInstanceMovimientos == null || m_FormDefInstanceMovimientos.IsDisposed)
                    m_FormDefInstanceMovimientos = new Movimientos();
                return m_FormDefInstanceMovimientos;
            }
            set
            {
                m_FormDefInstanceMovimientos = value;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                BD basedatos = new BD();
                SqlConnection conexion;
                //Creando conexion
                conexion = basedatos.conexionsql();
                //Abriendo conexion
                conexion.Open();
                string query = string.Empty;
                if (cmbMovimiento.SelectedItem.ToString() == "Cajero")
                    query = "select Empleado_Nombre from Empleado where Empleado_Id=" + txtId.Text;
                else
                    query = "select Suc_Regimen_Nombre from Sucursal where Suc_Id=" + txtId.Text;
                SqlCommand comando = new SqlCommand(query, conexion);
                txtNombre.Text = comando.ExecuteScalar().ToString();
                conexion.Close();
                btnReporte.Enabled = true;
                btnReporte.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ingrese Id de Cajero/Sucursal");
            }
        }

        private void Movimientos_Load(object sender, EventArgs e)
        {
            btnReporte.Enabled = false;
            btnReporte.Enabled = false;
        }


  

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                BD basedatos = new BD();
                SqlConnection conexion;
                //Creando conexion
                conexion = basedatos.conexionsql();
                //Abriendo conexion
                conexion.Open();
                string queryRefrendo = string.Empty;
                string queryVentas = string.Empty;
                string queryEmpenio = string.Empty;
                if (cmbMovimiento.SelectedItem.ToString() == "Cajero")
                {
                    queryRefrendo = "select SUM(Total) Total from Refrendo Where Usuario_Id=@Id and CAST(CONVERT(nvarchar(10), FechaCreacion, 101) as date) between CAST(@FecIni as date) and CAST(@FecFin+1 as date)";
                    queryVentas = "select SUM(Total) Total from Venta Where Usuario_Id=@Id and CAST(CONVERT(nvarchar(10), Fecha, 101) as date) between CAST(@FecIni as date) and CAST(@FecFin+1 as date)";
                    queryEmpenio = "select SUM(Avaluo) Total from Boleta_Encabezado Where Usuario_Id=@Id and CAST(CONVERT(nvarchar(10), Boleta_Fecha, 101) as date) between CAST(@FecIni as date) and CAST(@FecFin+1 as date)";
                }
                else
                {
                    queryRefrendo = "select SUM(Total) Total from Refrendo A inner join Sucursal B on A.Usuario_Id>0 Where B.Suc_Id=@Id and CAST(CONVERT(nvarchar(10), FechaCreacion, 101) as date) between CAST(@FecIni+1 as date) and CAST(@FecFin as date)";
                    queryVentas = "select SUM(Total) Total from Venta A inner join Sucursal B on A.Usuario_Id>0 Where B.Suc_Id=@Id and CAST(CONVERT(nvarchar(10), Fecha, 101) as date) between CAST(@FecIni as date) and CAST(@FecFin+1 as date)";
                    queryEmpenio = "select SUM(Avaluo) Total from Boleta_Encabezado A inner join Sucursal B on A.Usuario_Id>0 Where B.Suc_Id=@Id and CAST(CONVERT(nvarchar(10), Boleta_Fecha, 101) as date) between CAST(@FecIni as date) and CAST(@FecFin+1 as date)";
                }
                SqlCommand comando = new SqlCommand(queryRefrendo, conexion);
                comando.Parameters.Add(new SqlParameter("Id", txtId.Text));
                comando.Parameters.Add(new SqlParameter("FecIni", dtpFecInicio.Value));
                comando.Parameters.Add(new SqlParameter("FecFin", dtpFecFin.Value));
                Double Total = 0;
                Double.TryParse(comando.ExecuteScalar().ToString(), out Total);
                DataTable dt = new DataTable("Movimientos");
                dt.Columns.Add("Movimiento", typeof(String));
                dt.Columns.Add("Total", typeof(Double));
                
                dt.Rows.Add(new object[] { "Refrendo", Total });
                comando.CommandText = queryVentas;
                Double.TryParse(comando.ExecuteScalar().ToString(), out Total);

                dt.Rows.Add(new object[] { "Ventas", Total });
                comando.CommandText = queryEmpenio;
                Double.TryParse(comando.ExecuteScalar().ToString(), out Total);

                dt.Rows.Add(new object[] { "Empeños", Total });
                dgvMovimientos.DataSource = dt;
                conexion.Close();
            }
            else
            {
                MessageBox.Show("Ingrese Id de Cajero/Sucursal");
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                if (cmbMovimiento.SelectedItem.ToString() == "Cajero")
                {
                    rptMovimientoCajero frmCajero = new rptMovimientoCajero();
                    frmCajero.Id = Convert.ToInt32(txtId.Text);
                    frmCajero.Cajero = txtNombre.Text;
                    frmCajero.FecInicio = dtpFecInicio.Value;
                    frmCajero.FecFin = dtpFecFin.Value;
                    frmCajero.ShowDialog(this);
                }
                else
                {
                    rptMovimientoSucursal frmSucursal = new rptMovimientoSucursal();
                    frmSucursal.Id = Convert.ToInt32(txtId.Text);
                    frmSucursal.Sucursal = txtNombre.Text;
                    frmSucursal.FecInicio = dtpFecInicio.Value;
                    frmSucursal.FecFin = dtpFecFin.Value;
                    frmSucursal.ShowDialog(this);
                }
            }
            else
            {
                MessageBox.Show("Ingrese Id de Cajero/Sucursal");
            }
        }

      
    
       
    }

            
}

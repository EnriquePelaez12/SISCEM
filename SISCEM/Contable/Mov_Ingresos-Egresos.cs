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
    public partial class Mov_Ingresos_Egresos : Form
    {
        public Mov_Ingresos_Egresos()
        {
            InitializeComponent();
        }

        private static Mov_Ingresos_Egresos m_FormDefInstanceMov_Ingresos_Egresos;

        public static Mov_Ingresos_Egresos DefInstance
        {
            get
            {
                if (m_FormDefInstanceMov_Ingresos_Egresos == null || m_FormDefInstanceMov_Ingresos_Egresos.IsDisposed)
                    m_FormDefInstanceMov_Ingresos_Egresos = new Mov_Ingresos_Egresos();
                return m_FormDefInstanceMov_Ingresos_Egresos;
            }
            set
            {
                m_FormDefInstanceMov_Ingresos_Egresos = value;
            }
        }



        private void btnconsultar_Click(object sender, EventArgs e)
        {
            try
            {

                BD basedatos = new BD();
                SqlConnection conexion;
                //Creando conexion
                conexion = basedatos.conexionsql();
                //Abriendo conexion
                conexion.Open();
                string queryIngreso = string.Empty;
                string queryEgreso = string.Empty;
                if (cmbMovimiento.SelectedItem.ToString() == "Ingresos")
                {
                    queryIngreso = "select SUM(Importe)as Total from Ingresos Where  CAST(CONVERT(nvarchar(10), Fecha_Actualizacion, 101) as date) between CAST(@FecIni as date) and CAST(@FecFin+1 as date) ";
                    SqlCommand comando = new SqlCommand(queryIngreso, conexion);                    
                    comando.Parameters.Add(new SqlParameter("FecIni", dtpFecInicio.Value));
                    comando.Parameters.Add(new SqlParameter("FecFin", dtpFecFin.Value));
                    Double Total = 0;
                    Double.TryParse(comando.ExecuteScalar().ToString(), out Total);
                    DataTable dt = new DataTable("Movimientos");
                    dt.Columns.Add("Movimiento", typeof(String));
                    dt.Columns.Add("Total", typeof(Double));
                    dt.Rows.Add(new object[] { "Ingresos", Total });
                    dgvMovimientos.DataSource = dt;
                    conexion.Close();
                    
                }
                else
                {
                    queryEgreso = "select SUM(Importe) Total from Egresos Where  CAST(CONVERT(nvarchar(10), Fecha_Actualizacion, 101) as date) between CAST(@FecIni as date) and CAST(@FecFin+1 as date) ";
                    SqlCommand comando = new SqlCommand(queryEgreso, conexion);
                    comando.Parameters.Add(new SqlParameter("FecIni", dtpFecInicio.Value));
                    comando.Parameters.Add(new SqlParameter("FecFin", dtpFecFin.Value));
                    Double Total = 0;
                    Double.TryParse(comando.ExecuteScalar().ToString(), out Total);
                    DataTable dt = new DataTable("Movimientos");
                    dt.Columns.Add("Movimiento", typeof(String));
                    dt.Columns.Add("Total", typeof(Double));
                    dt.Rows.Add(new object[] { "Egresos", Total });
                    dgvMovimientos.DataSource = dt;
                    conexion.Close();
                }
                
                
                

            }
            catch (Exception)
            {

                MessageBox.Show("Error al consultar");
            }
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            
                if (cmbMovimiento.SelectedItem.ToString() == "Ingresos")
                {
                   
                    rptMovimientoIngreso frmingreso = new rptMovimientoIngreso();                                        
                    frmingreso.FecInicio = dtpFecInicio.Value;
                    frmingreso.FecFin = dtpFecFin.Value;
                    frmingreso.ShowDialog(this);
                }
                else
                {
                    rptMovimientoEgreso frmegreso = new rptMovimientoEgreso();                                        
                    frmegreso.FecInicio = dtpFecInicio.Value;
                    frmegreso.FecFin = dtpFecFin.Value;
                    frmegreso.ShowDialog(this);
                }
            
        }
       
    }
}

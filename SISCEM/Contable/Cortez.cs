using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SISCEM
{
    public partial class Cortez : Form
    {
        public Cortez()
        {
            InitializeComponent();
        }

        private static Cortez m_FormDefInstanceCortez;

        public static Cortez DefInstance
        {
            get
            {
                if (m_FormDefInstanceCortez == null || m_FormDefInstanceCortez.IsDisposed)
                    m_FormDefInstanceCortez = new Cortez();
                return m_FormDefInstanceCortez;
            }
            set
            {
                m_FormDefInstanceCortez = value;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
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
                string queryDesempenio = string.Empty;
                string queryIngresos = string.Empty;
                string queryEgresos = string.Empty;

                queryRefrendo = "Select Case When (Sum(Total))>0 Then Sum(Total) else 0  End From Refrendo_Total Where Convert(Varchar,Fecha,101) >= @FechaIni And Convert(Varchar,Fecha,101) <= @FechaFin";
                queryVentas = "Select Case When (Sum(Total))>0 Then Sum(Total) else 0  End From venta Where Convert(Varchar,Fecha,101) >= @FechaIni And Convert(Varchar,Fecha,101) <= @FechaFin";
                queryEmpenio = "Select Case When (Sum(Prestamo))>0 Then Sum(Prestamo) else 0  End from Boleta_Encabezado Where Convert(Varchar,Boleta_Fecha,101) >= @FechaIni And Convert(Varchar,Boleta_Fecha,101) <= @FechaFin";
                queryDesempenio = "Select Case When (Sum(Monto))>0 Then Sum(Monto) else 0  End from Desempenio Where Convert(Varchar,Fecha,101) >= @FechaIni And Convert(Varchar,Fecha,101) <= @FechaFin";
                queryIngresos = "Select Case When (Sum(importe))>0 Then Sum(importe) else 0  End From Ingresos Where Convert(Varchar,Fecha_Actualizacion,101) >= @FechaIni And Convert(Varchar,Fecha_Actualizacion,101) <= @FechaFin";
                queryEgresos = "Select Case When (Sum(importe))>0 Then Sum(importe) else 0  End  From Egresos Where Convert(Varchar,Fecha_Actualizacion,101) >= @FechaIni And Convert(Varchar,Fecha_Actualizacion,101) <= @FechaFin";
                
                //Refrendo
                SqlCommand comandorefrendo = new SqlCommand(queryRefrendo, conexion);
                comandorefrendo.Parameters.Add(new SqlParameter("FechaIni", dtpFecInicio.Value));
                comandorefrendo.Parameters.Add(new SqlParameter("FechaFin", dtpFecFin.Value));
                txtrefrendo.Text = comandorefrendo.ExecuteScalar().ToString();
                //Ventas
                SqlCommand comandoVentas = new SqlCommand(queryVentas, conexion);
                comandoVentas.Parameters.Add(new SqlParameter("FechaIni", dtpFecInicio.Value));
                comandoVentas.Parameters.Add(new SqlParameter("FechaFin", dtpFecFin.Value));
                txtventas.Text = comandoVentas.ExecuteScalar().ToString();
                //Empeno
                SqlCommand comandoempenio = new SqlCommand(queryEmpenio, conexion);
                comandoempenio.Parameters.Add(new SqlParameter("FechaIni", dtpFecInicio.Value));
                comandoempenio.Parameters.Add(new SqlParameter("FechaFin", dtpFecFin.Value));
                txtempenio.Text = comandoempenio.ExecuteScalar().ToString();
                //Desempeño
                SqlCommand comandoDesempenio = new SqlCommand(queryDesempenio, conexion);
                comandoDesempenio.Parameters.Add(new SqlParameter("FechaIni", dtpFecInicio.Value));
                comandoDesempenio.Parameters.Add(new SqlParameter("FechaFin", dtpFecFin.Value));
                txtdesempenio.Text = comandoDesempenio.ExecuteScalar().ToString();
                //Ingresos
                SqlCommand comandoingresos = new SqlCommand(queryIngresos, conexion);
                comandoingresos.Parameters.Add(new SqlParameter("FechaIni", dtpFecInicio.Value));
                comandoingresos.Parameters.Add(new SqlParameter("FechaFin", dtpFecFin.Value));
                txtingresos.Text = comandoingresos.ExecuteScalar().ToString();
                //Egresos
                SqlCommand comandoegresos = new SqlCommand(queryEgresos, conexion);
                comandoegresos.Parameters.Add(new SqlParameter("FechaIni", dtpFecInicio.Value));
                comandoegresos.Parameters.Add(new SqlParameter("FechaFin", dtpFecFin.Value));
                txtegresos.Text = comandoegresos.ExecuteScalar().ToString();
                
                //Converciones
                decimal empenio = Convert.ToDecimal(txtempenio.Text);
                decimal ventas = Convert.ToDecimal(txtventas.Text);
                decimal refrendo = Convert.ToDecimal(txtrefrendo.Text);
                decimal desempenio = Convert.ToDecimal(txtdesempenio.Text);
                decimal ingresos = Convert.ToDecimal(txtingresos.Text);
                decimal egresos = Convert.ToDecimal(txtegresos.Text);

                //Utilidad
                decimal Total = 0;
                Total = (ingresos + desempenio + ventas+refrendo)-(empenio + egresos);
                txtutilidad.Text = Convert.ToString(Total);                

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la transaccion");
            }
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            
            rptcortez rpcortez = new rptcortez();
            rpcortez.Empenio = txtempenio.Text;
            rpcortez.Ventas = txtventas.Text;
            rpcortez.Refrendo = txtrefrendo.Text;
            rpcortez.Desempenio = txtdesempenio.Text;
            rpcortez.Ingresos = txtingresos.Text;
            rpcortez.Egresos = txtegresos.Text;
            rpcortez.Utilidad = txtutilidad.Text;
            rpcortez.ShowDialog(this);
            rpcortez.Dispose();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;


namespace SISCEM
{
    public partial class Reimpresionrpt : Form
    {
        public Reimpresionrpt()
        {
            InitializeComponent();
        }
        BD basedatos = new BD();
        SqlConnection conexion;

        public int boleta_id = 0;
        public int cliente_id = 0;
        public int tipo = 0;
        BaseDeDatos bdatos = new BaseDeDatos();

        private void Reimpresionrpt_Load(object sender, EventArgs e)
        {
            conexion = basedatos.conexionsql();
            //Abriendo conexion
            conexion.Open();
            SqlCommand comando = new SqlCommand("select Categoria_Id From Boleta_encabezado where Boleta_id= '" + boleta_id + "' ", conexion);

            SqlDataReader dr = comando.ExecuteReader();
            int resultado;
            if (dr.Read())
            {
                resultado = Convert.ToInt32(dr[0].ToString());

                if (resultado == 1)
                {
                    lanza_impresion_oro();
                }
                else
                {
                    lanza_impresion_electronicos();
                }

            }
            
            this.reportViewer1.RefreshReport();
        }

        private void lanza_impresion_electronicos()
        {
            BD basedatos = new BD();
            string strPagos = "Select Prestamo,Avaluo,Boleta_Fecha from Boleta_encabezado Where Boleta_id=" + boleta_id +"";
            SqlDataAdapter da = new SqlDataAdapter(strPagos, basedatos.conexionsql());
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //PRESTODataSet.PagosDataTable dt = new PRESTODataSet.PagosDataTable();
            DataTable dt = new DataTable("Pagos");
            dt.Columns.Add("IdBoleta", typeof(int));
            dt.Columns.Add("Importe", typeof(double));
            dt.Columns.Add("Interes", typeof(double));
            dt.Columns.Add("Almacenaje", typeof(double));
            dt.Columns.Add("IVA", typeof(double));
            dt.Columns.Add("PorRefrendo", typeof(double));
            dt.Columns.Add("PorDesempenio", typeof(double));
            dt.Columns.Add("FechaPago", typeof(string));
            
            if (ds != null)
                if (ds.Tables.Count > 0)
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        switch (ds.Tables[0].Rows[0][0].ToString())
                        {
                            case "1":
                            default:
                                double Prestamo = Convert.ToDouble(ds.Tables[0].Rows[0][0]);
                                DateTime fecha = Convert.ToDateTime (ds.Tables[0].Rows[0][2]);
                                for (int i = 1; i < 5; i++)
                                {
                                    DataRow dr = dt.NewRow();
                                    dr[0] = boleta_id;
                                    dr[1] = Prestamo;
                                    //double Interes = (Prestamo * .00486) * (i * 7);
                                    double Interes = (Prestamo * .00454) * (i * 7);
                                    dr[2] = Math.Round(Interes, 2);
                                    double Almacenaje = Prestamo * 0.006 * i;
                                    dr[3] = Math.Round(Almacenaje, 2);
                                    double IVA = (Interes + Almacenaje) * 0.16;
                                    dr[4] = Math.Round(IVA, 2);
                                    double Refrendo = (Interes + Almacenaje + IVA);
                                    dr[5] = Math.Round(Refrendo, 2);
                                    dr[6] = Prestamo + Refrendo;
                                    dr[7] = "S " + i.ToString() + "-hasta el->" + fecha.AddDays(i * 7).ToString("dd/MM/yyyy");                         
                                    dt.Rows.Add(dr);
                                }
                                break;
                        }
                    }

           

            reportViewer1.LocalReport.DataSources.Clear();
            Boleta_EncabezadoTableAdapter.Fill(PRESTODataSet.Boleta_Encabezado, boleta_id);
            Boleta_DetalleTableAdapter.Fill(PRESTODataSet.Boleta_Detalle, boleta_id);
            InteresesTableAdapter.Fill(PRESTODataSet.Intereses);
            ClienteTableAdapter.Fill(PRESTODataSet.Cliente, cliente_id);
            SucursalTableAdapter.Fill(PRESTODataSet.Sucursal, 1);

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsReimprime", dt));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsBoleta_Encabezado", PRESTODataSet.Tables["Boleta_Encabezado"]));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsBoletaDetalle", PRESTODataSet.Tables["Boleta_Detalle"]));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsIntereses", PRESTODataSet.Tables["Intereses"]));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsCliente", PRESTODataSet.Tables["Cliente"]));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsSucursal", PRESTODataSet.Tables["Sucursal"]));

            this.reportViewer1.RefreshReport();

        }

        private void lanza_impresion_oro()
        {
            BD basedatos = new BD();
            string strPagos = "Select Prestamo,Avaluo,Boleta_Fecha from Boleta_encabezado Where Boleta_id=" + boleta_id + "";
            SqlDataAdapter da = new SqlDataAdapter(strPagos, basedatos.conexionsql());
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //PRESTODataSet.PagosDataTable dt = new PRESTODataSet.PagosDataTable();
            DataTable dt = new DataTable("Pagos");
            dt.Columns.Add("IdBoleta", typeof(int));
            dt.Columns.Add("Importe", typeof(double));
            dt.Columns.Add("Interes", typeof(double));
            dt.Columns.Add("Almacenaje", typeof(double));
            dt.Columns.Add("IVA", typeof(double));
            dt.Columns.Add("PorRefrendo", typeof(double));
            dt.Columns.Add("PorDesempenio", typeof(double));
            dt.Columns.Add("FechaPago", typeof(string));
            
            if (ds != null)
                if (ds.Tables.Count > 0)
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        switch (ds.Tables[0].Rows[0][0].ToString())
                        {
                            case "1":
                            default:
                                double Prestamo = Convert.ToDouble(ds.Tables[0].Rows[0][0]);
                                DateTime fecha = Convert.ToDateTime(ds.Tables[0].Rows[0][2]);
                                for (int i = 1; i < 5; i++)
                                {
                                    DataRow dr = dt.NewRow();
                                    dr[0] = boleta_id;
                                    dr[1] = Prestamo;
                                    //double Interes = (Prestamo * .00486) * (i * 7);
                                    double Interes = (Prestamo * .00129) * (i * 7);
                                    dr[2] = Math.Round(Interes, 2);
                                    double Almacenaje = Prestamo * 0.006 * i;
                                    dr[3] = Math.Round(Almacenaje, 2);
                                    double IVA = (Interes + Almacenaje) * 0.16;
                                    dr[4] = Math.Round(IVA, 2);
                                    double Refrendo = (Interes + Almacenaje + IVA);
                                    dr[5] = Math.Round(Refrendo, 2);
                                    dr[6] = Prestamo + Refrendo;
                                    dr[7] = "S " + i.ToString() + "-hasta el->" + fecha.AddDays(i * 7).ToString("dd/MM/yyyy");                                    
                                    dt.Rows.Add(dr);
                                }
                                break;
                        }
                    }

       

            reportViewer1.LocalReport.DataSources.Clear();
            Boleta_EncabezadoTableAdapter.Fill(PRESTODataSet.Boleta_Encabezado, boleta_id);
            Boleta_DetalleTableAdapter.Fill(PRESTODataSet.Boleta_Detalle, boleta_id);
            InteresesTableAdapter.Fill(PRESTODataSet.Intereses);
            ClienteTableAdapter.Fill(PRESTODataSet.Cliente, cliente_id);
            SucursalTableAdapter.Fill(PRESTODataSet.Sucursal, 1);

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsReimprime", dt));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsBoleta_Encabezado", PRESTODataSet.Tables["Boleta_Encabezado"]));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsBoletaDetalle", PRESTODataSet.Tables["Boleta_Detalle"]));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsIntereses", PRESTODataSet.Tables["Intereses"]));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsCliente", PRESTODataSet.Tables["Cliente"]));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsSucursal", PRESTODataSet.Tables["Sucursal"]));

            this.reportViewer1.RefreshReport();
        }

    }
}

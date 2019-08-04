using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace SISCEM
{
    public partial class Empeniorpt : Form
    {

        BD basedatos = new BD();
        SqlConnection conexion;

        private static Empeniorpt m_FormDefInstanceEmpeniorpt;
        public static Empeniorpt DefInstance
        {
            get
            {
                if (m_FormDefInstanceEmpeniorpt == null || m_FormDefInstanceEmpeniorpt.IsDisposed)
                    m_FormDefInstanceEmpeniorpt = new Empeniorpt();
                return m_FormDefInstanceEmpeniorpt;
            }
            set
            {
                m_FormDefInstanceEmpeniorpt = value;
            }
        }


        public int boleta_id = 0;
        public int cliente_id = 0;
        public int tipo = 0;

        

        public Empeniorpt()
        {
            InitializeComponent();
        }

       

        private void Empeniorpt_Load(object sender, EventArgs e)
        {
            conexion = basedatos.conexionsql();
            //Abriendo conexion
            conexion.Open();
            SqlCommand comando = new SqlCommand("select Categoria_Id From Boleta_encabezado where Boleta_id= '" + boleta_id + "' ", conexion);

            SqlDataReader dr = comando.ExecuteReader();
            int resultado;
            if (dr.Read())
            {
               resultado=Convert.ToInt32( dr[0].ToString());

               if (resultado == 1)
               {
                   lanza_impresion_oro();
               }
               else
               {
                   lanza_impresion_electronicos();
               }
               
            }
            
        }

        private void lanza_impresion_electronicos()
        {
            BD basedatos = new BD();
            string strPagos = "select Plazo, SUM(Prestamo) Prestamo, SUM(Avaluo) Avaluo from PRESTO.dbo.Boleta_Detalle where Boleta_Id=" + boleta_id + " group by Plazo";
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
            dt.Columns.Add("Fecha_Semana", typeof(string));
            dt.Columns.Add("Linea", typeof(string));
            if (ds != null)
                if (ds.Tables.Count > 0)
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        switch (ds.Tables[0].Rows[0][0].ToString())
                        {
                            case "1":
                            default:
                                double Prestamo = Convert.ToDouble(ds.Tables[0].Rows[0][1]);
                                for (int i = 1; i < 5; i++)
                                {
                                    DataRow dr = dt.NewRow();
                                    dr[0] = boleta_id;
                                    dr[1] = Prestamo;
                                    //double Interes = (Prestamo * .00486) * (i * 7);
                                    //0.00397
                                    //4069
                                    double Interes = (Prestamo * 0.004069) * (i * 7);
                                    dr[2] = Math.Round(Interes,2);
                                    double Almacenaje = Prestamo * 0.006 * i;
                                    dr[3] = Math.Round(Almacenaje,2);
                                    double IVA = (Interes + Almacenaje) * 0.16;
                                    dr[4] = Math.Round(IVA,2);
                                    double Refrendo = (Interes + Almacenaje + IVA);
                                    dr[5] = Math.Round(Refrendo,2);
                                    dr[6] = Prestamo + Refrendo;
                                    dr[7] = "S " + i.ToString() + "-hasta el->" + DateTime.Now.AddDays(i * 7).ToString("dd/MM/yyyy");
                                    dr[8] = DateTime.Now.AddDays(i * 7).ToString("dd/MM/yyyy");
                                    dr[9] = i * 1;
                                    dt.Rows.Add(dr);
                                }
                                break;
                        }
                    }

            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Insert Into Pagos Values(" + dr[0] + "," + dr[1] + "," + dr[2] + "," + dr[3] + "," + dr[4] + "," + dr[5] + "," + dr[6] + ",'" + dr[7] + "','" + dr[8] + "','" + dr[9] + "')", basedatos.conexionsql());
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            reportViewer1.LocalReport.DataSources.Clear();
            Boleta_EncabezadoTableAdapter.Fill(PRESTODataSet.Boleta_Encabezado, boleta_id);
            Boleta_DetalleTableAdapter.Fill(PRESTODataSet.Boleta_Detalle, boleta_id);
            InteresesTableAdapter.Fill(PRESTODataSet.Intereses);
            ClienteTableAdapter.Fill(PRESTODataSet.Cliente, cliente_id);
            SucursalTableAdapter.Fill(PRESTODataSet.Sucursal, 1);

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsEmpenio", dt));
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
            string strPagos = "select Plazo, SUM(Prestamo) Prestamo, SUM(Avaluo) Avaluo from PRESTO.dbo.Boleta_Detalle where Boleta_Id=" + boleta_id + " group by Plazo";
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
            dt.Columns.Add("Fecha_Semana", typeof(string));
            dt.Columns.Add("Linea", typeof(string));
            if (ds != null)
                if (ds.Tables.Count > 0)
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        switch (ds.Tables[0].Rows[0][0].ToString())
                        {
                            case "1":
                            default:
                                double Prestamo = Convert.ToDouble(ds.Tables[0].Rows[0][1]);
                                for (int i = 1; i < 5; i++)
                                {
                                    DataRow dr = dt.NewRow();
                                    dr[0] = boleta_id;
                                    dr[1] = Prestamo;
                                    //double Interes = (Prestamo * .00486) * (i * 7);
                                    //double Interes = (Prestamo * .00129) * (i * 7);
                                    double Interes = (Prestamo * .00223) * (i * 7);
                                    dr[2] = Math.Round(Interes,2);
                                    double Almacenaje = Prestamo * 0.006 * i;
                                    dr[3] = Math.Round(Almacenaje,2);
                                    double IVA = (Interes + Almacenaje) * 0.16;
                                    dr[4] = Math.Round(IVA,2);
                                    double Refrendo = (Interes + Almacenaje + IVA);
                                    dr[5] = Math.Round(Refrendo,2);
                                    dr[6] = Prestamo + Refrendo;
                                    dr[7] = "S " + i.ToString() + "-hasta el->" + DateTime.Now.AddDays(i * 7).ToString("dd/MM/yyyy");
                                    dr[8] = DateTime.Now.AddDays(i * 7).ToString("dd/MM/yyyy");
                                    dr[9] = i * 1;
                                    dt.Rows.Add(dr);
                                }
                                break;
                        }
                    }

            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Insert Into Pagos Values(" + dr[0] + "," + dr[1] + "," + dr[2] + "," + dr[3] + "," + dr[4] + "," + dr[5] + "," + dr[6] + ",'" + dr[7] + "','" + dr[8] + "','" + dr[9] + "')", basedatos.conexionsql());
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            reportViewer1.LocalReport.DataSources.Clear();
            Boleta_EncabezadoTableAdapter.Fill(PRESTODataSet.Boleta_Encabezado, boleta_id);
            Boleta_DetalleTableAdapter.Fill(PRESTODataSet.Boleta_Detalle, boleta_id);
            InteresesTableAdapter.Fill(PRESTODataSet.Intereses);
            ClienteTableAdapter.Fill(PRESTODataSet.Cliente, cliente_id);
            SucursalTableAdapter.Fill(PRESTODataSet.Sucursal, 1);

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsEmpenio", dt));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsBoleta_Encabezado", PRESTODataSet.Tables["Boleta_Encabezado"]));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsBoletaDetalle", PRESTODataSet.Tables["Boleta_Detalle"]));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsIntereses", PRESTODataSet.Tables["Intereses"]));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsCliente", PRESTODataSet.Tables["Cliente"]));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsSucursal", PRESTODataSet.Tables["Sucursal"]));

            this.reportViewer1.RefreshReport();
        }

    }
}

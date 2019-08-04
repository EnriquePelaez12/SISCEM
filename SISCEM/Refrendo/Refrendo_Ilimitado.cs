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
    public partial class Refrendo_Ilimitado : Form
    {
        BD basedatos = new BD();
        BaseDeDatos bdatos = new BaseDeDatos();
        public int Rsemana = 0;

        public string valuador_refrendo = "";

        private static Refrendo_Ilimitado m_FormDefInstanceRefrendo_Ilimitado;

        public static Refrendo_Ilimitado DefInstance
        {
            get
            {
                if (m_FormDefInstanceRefrendo_Ilimitado == null || m_FormDefInstanceRefrendo_Ilimitado.IsDisposed)
                    m_FormDefInstanceRefrendo_Ilimitado = new Refrendo_Ilimitado();
                return m_FormDefInstanceRefrendo_Ilimitado;
            }
            set
            {
                m_FormDefInstanceRefrendo_Ilimitado = value;
            }
        }

        private void limpiar()
        {
            txtboleta_id.Text = "0"; txtcliente.Text = "";
            txttotal.Text = ""; txtalmacenaje.Text = "";
            txtinteres.Text = ""; txtiva.Text = "";
            txtprestamo.Text = "";
            txtboleta_id.ReadOnly = false;
        }

        public Refrendo_Ilimitado()
        {
            InitializeComponent();
            
        }

        private void numero_refrendo()
        {
            try
            {
                string contador;
                SqlConnection Conexion = basedatos.conexionsql();
                Conexion.Open();
                string sql = "select max(refrendo) as refrendo from refrendo";

                SqlCommand command = new SqlCommand(sql, Conexion);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    contador = Convert.ToString(reader["refrendo"]);
                    lblrefrendo.Text = Convert.ToString(Convert.ToInt32(contador) + 1);
                }
                Conexion.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {

                double prestamo     = 0;
                double almacenaje   = 0;
                double iva          = 0;
                double interes      = 0;
                string cliente      = "";
                string Fecha        = "";
                int  Ndias          = 0;
                string dias         = "";
                double Nsemana      = 0;
              //public  int Rsemana         = 0;

                if (txtboleta_id.Text != "" )
                {
                        BD basedatos = new BD();
                        SqlConnection conexion;
                        //Creando conexion
                        conexion = basedatos.conexionsql();
                        //Abriendo conexion
                        conexion.Open();
                        SqlCommand comando = new SqlCommand("Select top 1 C.Cliente_nombre,A.Importe as Prestamo,A.Interes,A.Almacenaje,A.Iva,Convert(varchar,B.Boleta_Fecha,112) as fecha From Pagos  A,  Boleta_Encabezado B, Cliente C where A.idboleta = B.Boleta_id and  B.Estado<>'Desempeñado'  And B.Cliente_id = C.Cliente_id And A.IdBoleta=" + txtboleta_id.Text + " Order by A.linea asc", conexion);
                        SqlDataReader dr = comando.ExecuteReader();

                        if (dr.Read())
                        {
                            
                            cliente      =   dr[0].ToString();
                            prestamo     =   Convert.ToDouble(dr[1]);
                            interes      =   Convert.ToDouble(dr[2]);
                            almacenaje   =   Convert.ToDouble(dr[3]);
                            iva          =   Convert.ToDouble(dr[4]);
                            Fecha        =  dr[5].ToString();
                           // ndias        =  dr[6];
                            
                        }
                        conexion.Close();

                       // DateTime Fechaactual = DateTime.Now;
                        //DateTime Fechaactual = DateTime.ParseExact(Fechaactual, "yyyymmdd", System.Globalization.CultureInfo.InvariantCulture);
                        //DateTime Fechavieja = DateTime.ParseExact(Fecha, "yyyymmdd", System.Globalization.CultureInfo.CurrentUICulture);//.InvariantCulture);
                       // DateTime Fechavieja = Convert.ToDateTime(Fecha);// (Fecha, "yyyymmdd", System.Globalization.CultureInfo.CurrentUICulture);//.InvariantCulture);

                        
                        conexion.Open();
                        SqlCommand cmd = new SqlCommand("Ndias", conexion);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@fechainicio", Fecha);

                        SqlDataReader dar = cmd.ExecuteReader();

                        if (dar.Read())
                        {
                            dias = dar[0].ToString();
                        }

                        conexion.Close();
                        Ndias = Convert.ToInt32(dias);
                
                
                               
                //Ndias   = CalculateDays(Fechavieja, Fechaactual);
                Nsemana = (Ndias / 7);
                Rsemana =(int)Math.Ceiling(Math.Round(Nsemana));

                txtalmacenaje.Text = "0";
                txtiva.Text = "0";
                txtinteres.Text = "0";

                almacenaje = (almacenaje * Rsemana);
                txtalmacenaje.Text = Convert.ToString(almacenaje);

                iva = (iva* Rsemana);
                txtiva.Text = Convert.ToString(iva);

                interes = (interes* Rsemana);
                txtinteres.Text = Convert.ToString(interes);

                txtprestamo.Text = Convert.ToString(prestamo);

                txtcliente.Text = cliente;

                txttotal.Text = Convert.ToString(almacenaje + iva + interes);
               
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ingrese un Numero de boleta valido", "Error:", MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void Guardarefrendo_total()
        {
            try
            {
                BD basedatos = new BD();
                SqlConnection conexion;
                //Creando conexion
                conexion = basedatos.conexionsql();
                //Abriendo conexion
                conexion.Open();
                SqlCommand cmd = new SqlCommand("Insert Into Refrendo_Total(Boleta_Id, Cliente_Nombre, Prestamo, Interes, Almacenaje, Iva, Total, Fecha) Values(@Prm1,@Prm2,@Prm3,@Prm4,@Prm5,@Prm6,@Prm7,@Prm8)");
                cmd.Connection = conexion;
                cmd.Parameters.Add(new SqlParameter("@Prm1", txtboleta_id.Text));
                cmd.Parameters.Add(new SqlParameter("@Prm2", txtcliente.Text));
                cmd.Parameters.Add(new SqlParameter("@Prm3", txtprestamo.Text));
                cmd.Parameters.Add(new SqlParameter("@Prm4", txtalmacenaje.Text));
                cmd.Parameters.Add(new SqlParameter("@Prm5", txtinteres.Text));
                cmd.Parameters.Add(new SqlParameter("@Prm6", txtiva.Text));
                cmd.Parameters.Add(new SqlParameter("@Prm7", txttotal.Text));
                cmd.Parameters.Add(new SqlParameter("@Prm8", DateTime.Now.ToString("yyyy/MM/dd")));
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error no existen datos");

            }
        }

        
        private void Refrendo_Ilimitado_Load(object sender, EventArgs e)
        {
            lblusuario.Text = "Cajero: " + Program.Usuario;
            this.numero_refrendo();
        }

        private int CalculateDays(DateTime oldDate, DateTime newDate)
        {
            // Diferencia de fechas
            
            TimeSpan ts = newDate- oldDate;

            // Diferencia de días
           return ts.Days;
          
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {            
            try
            {
                if (txtboleta_id.Text != "" && txtcliente.Text != "" && txtinteres.Text != "" && txtiva.Text != "" && txtprestamo.Text != "" && txttotal.Text != "")
                {
                    this.Guardarefrendo_total();
                    BD basedatos = new BD();
                    SqlConnection conexion;
                    //Creando conexion
                    conexion = basedatos.conexionsql();
                    //Abriendo conexion
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("select Importe, Interes, Almacenaje, Iva, PorRefrendo from Pagos  A inner join Boleta_Encabezado B on A.idBoleta=B.Boleta_id where B.Estado<>'Desempeñado' And A.idBoleta=" + txtboleta_id.Text + "Order by Linea", conexion);
                    SqlDataReader dr = comando.ExecuteReader();
                    DataTable dt = new DataTable();
                    using (dr)
                    {
                        dt.Load(dr);
                    }
                    int i = 1;
                    int contador = Convert.ToInt32(lblrefrendo.Text);
                    foreach (DataRow row in dt.Rows)
                    {
                        SqlCommand cmd = new SqlCommand("Insert Into Refrendo(Boleta_Id, Cliente_Nombre, Prestamo, Interes, Almacenaje, Iva, Total, Fecha,Usuario_Id,Refrendo) Values(@Prm1,@Prm2,@Prm3,@Prm4,@Prm5,@Prm6,@Prm7,@Prm8,@Prm9,@Prm10)");
                        cmd.Connection = conexion;
                        cmd.Parameters.Add(new SqlParameter("@Prm1", txtboleta_id.Text));
                        cmd.Parameters.Add(new SqlParameter("@Prm2", txtcliente.Text));
                        cmd.Parameters.Add(new SqlParameter("@Prm3", row[0].ToString()));
                        cmd.Parameters.Add(new SqlParameter("@Prm4", row[1].ToString()));
                        cmd.Parameters.Add(new SqlParameter("@Prm5", row[2].ToString()));
                        cmd.Parameters.Add(new SqlParameter("@Prm6", row[3].ToString()));
                        cmd.Parameters.Add(new SqlParameter("@Prm7", row[4].ToString()));
                        cmd.Parameters.Add(new SqlParameter("@Prm8", "S " + i.ToString() + "-hasta el->" + DateTime.Now.AddDays(i * 7).ToString("dd/MM/yyyy")));
                        cmd.Parameters.Add(new SqlParameter("@Prm9", Program.UsuarioId));
                        cmd.Parameters.Add(new SqlParameter("@Prm10", contador));
                        cmd.ExecuteNonQuery();
                        i++;
                    }


                    string dtme = Convert.ToString(DateTime.Now.ToShortDateString());
                    DateTime fecha = Convert.ToDateTime(dtme);

                    DateTime fecha_vencimiento = Convert.ToDateTime(dtme);
                    fecha_vencimiento = fecha_vencimiento.AddDays(28);

                    DateTime fecha_comercializacion = fecha_vencimiento;
                    fecha_comercializacion = fecha_vencimiento.AddDays(3);

                    string actualizar = "update Boleta_Encabezado set Estado='Vigente',Boleta_Fecha = '" + fecha.ToString("yyyy-MM-dd hh:mm") + "',Boleta_Fecha_Vencimiento= '" + fecha_vencimiento.ToString("yyyy-MM-dd hh:mm") + "',Boleta_Fecha_Comercializacion= '" + fecha_comercializacion.ToString("yyyy-MM-dd hh:mm") + "' where Boleta_id = " + txtboleta_id.Text;

                    if (bdatos.executecommand(actualizar))
                    {
                        MessageBox.Show("Refrendo generado correctamente");

                    }
                    else
                    {
                        MessageBox.Show("Error al refrendar");
                    }
                    conexion.Close();

                    //rptPagoRefrendoIlimitado reporte = new rptPagoRefrendoIlimitado();
                    //reporte.cliente = txtcliente.Text;
                    //reporte.Prestamo = txtprestamo.Text;
                    //reporte.almacenaje = txtalmacenaje.Text;
                    //reporte.Interes = txtinteres.Text;
                    //reporte.Iva = txtiva.Text;
                    //reporte.Total = txttotal.Text;
                    //reporte.Boleta = txtboleta_id.Text;
                    //reporte.Semanas = Rsemana.ToString();
                    //reporte.ShowDialog(this);
                    //reporte.Dispose();
                                         

                    rptRefrendo rpt = new rptRefrendo();                    
                    rpt.IdBoleta = Convert.ToInt32(txtboleta_id.Text);
                    rpt.refrendo = lblrefrendo.Text;
                    rpt.Total_extra = txttotal.Text;
                    rpt.ShowDialog(this);
                    rpt.Dispose();

                    Gurda_PDF datos = new Gurda_PDF();
                    datos.Boleta = txtboleta_id.Text;
                    datos.Cliente = txtcliente.Text;
                    datos.Nombre = lblnombre.Text;
                    datos.Movimiento = lblrefrendo.Text;
                    datos.ShowDialog(this);
                    datos.Dispose();

                    this.limpiar();


                }
                else
                {
                    MessageBox.Show("Ingrese el número de boleta");
                }
            }

            catch (Exception)
            {

                MessageBox.Show("Error al generar el proceso", "Error:", MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
            }
        }

        
    }
}
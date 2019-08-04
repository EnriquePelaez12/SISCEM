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
    
    public partial class Refrendo : Form
    {
        BD basedatos = new BD();
        BaseDeDatos bdatos = new BaseDeDatos();

        public string valuador_refrendo = "";

        private static Refrendo m_FormDefInstanceRefrendo;

        public static Refrendo DefInstance
        {
            get
            {
                if (m_FormDefInstanceRefrendo == null || m_FormDefInstanceRefrendo.IsDisposed)
                    m_FormDefInstanceRefrendo = new Refrendo();
                return m_FormDefInstanceRefrendo;
            }
            set
            {
                m_FormDefInstanceRefrendo = value;
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

        public Refrendo()
        {
            InitializeComponent();
            cbxsemana.SelectedItem = "0";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtboleta_id.Text != "" && cbxsemana.SelectedItem.ToString() != "0")
                {
                    if (cbxsemana.SelectedItem.ToString() == "1")
                    {
                        BD basedatos = new BD();
                        SqlConnection conexion;
                        //Creando conexion
                        conexion = basedatos.conexionsql();
                        //Abriendo conexion
                        conexion.Open();
                        SqlCommand comando = new SqlCommand("select Cliente_nombre, MAX(Importe) Prestamo, MAX(Interes) Intereses, MAX(Almacenaje) Almacenaje, MAX(Iva) Iva, MAX(PorRefrendo) Refrendo from Pagos A Inner Join Boleta_Detalle B on A.IdBoleta=B.Boleta_Id inner join Boleta_Encabezado C on C.boleta_id=B.Boleta_id where idBoleta=" + txtboleta_id.Text + " And linea=1 And ((Convert(varchar,C.Boleta_Fecha_Vencimiento,112)=convert(varchar,getdate(),112))or C.Estado='Vigente') " + " Group by Cliente_Nombre", conexion);
                        SqlDataReader dr = comando.ExecuteReader();

                        if (dr.Read())
                        {
                            txtcliente.Text = dr[0].ToString();
                            txtprestamo.Text = dr[1].ToString();
                            txtalmacenaje.Text = dr[3].ToString();
                            txtiva.Text = dr[4].ToString();
                            txtinteres.Text = dr[2].ToString();
                            txttotal.Text = dr[5].ToString();
                        }
                    }

                    if (cbxsemana.SelectedItem.ToString() == "2")
                    {
                        BD basedatos = new BD();
                        SqlConnection conexion;
                        //Creando conexion
                        conexion = basedatos.conexionsql();
                        //Abriendo conexion
                        conexion.Open();
                        SqlCommand comando = new SqlCommand("select Cliente_nombre, MAX(Importe) Prestamo, MAX(Interes) Intereses, MAX(Almacenaje) Almacenaje, MAX(Iva) Iva, MAX(PorRefrendo) Refrendo from Pagos A Inner Join Boleta_Detalle B on A.IdBoleta=B.Boleta_Id inner join Boleta_Encabezado C on C.boleta_id=B.Boleta_id where idBoleta=" + txtboleta_id.Text + " And linea=2 And ((Convert(varchar,C.Boleta_Fecha_Vencimiento,112)=convert(varchar,getdate(),112))or C.Estado='Vigente') " + " Group by Cliente_Nombre", conexion);
                        SqlDataReader dr = comando.ExecuteReader();

                        if (dr.Read())
                        {
                            txtcliente.Text = dr[0].ToString();
                            txtprestamo.Text = dr[1].ToString();
                            txtalmacenaje.Text = dr[3].ToString();
                            txtiva.Text = dr[4].ToString();
                            txtinteres.Text = dr[2].ToString();
                            txttotal.Text = dr[5].ToString();
                        }
                    }
                    if (cbxsemana.SelectedItem.ToString() == "3")
                    {
                        BD basedatos = new BD();
                        SqlConnection conexion;
                        //Creando conexion
                        conexion = basedatos.conexionsql();
                        //Abriendo conexion
                        conexion.Open();
                        SqlCommand comando = new SqlCommand("select Cliente_nombre, MAX(Importe) Prestamo, MAX(Interes) Intereses, MAX(Almacenaje) Almacenaje, MAX(Iva) Iva, MAX(PorRefrendo) Refrendo from Pagos A Inner Join Boleta_Detalle B on A.IdBoleta=B.Boleta_Id inner join Boleta_Encabezado C on C.boleta_id=B.Boleta_id where idBoleta=" + txtboleta_id.Text + " And linea=3 And ((Convert(varchar,C.Boleta_Fecha_Vencimiento,112)=convert(varchar,getdate(),112))or C.Estado='Vigente') " + " Group by Cliente_Nombre", conexion);
                        SqlDataReader dr = comando.ExecuteReader();

                        if (dr.Read())
                        {
                            txtcliente.Text = dr[0].ToString();
                            txtprestamo.Text = dr[1].ToString();
                            txtalmacenaje.Text = dr[3].ToString();
                            txtiva.Text = dr[4].ToString();
                            txtinteres.Text = dr[2].ToString();
                            txttotal.Text = dr[5].ToString();
                        }
                    }
                    if (cbxsemana.SelectedItem.ToString() == "4")
                    {
                        BD basedatos = new BD();
                        SqlConnection conexion;
                        //Creando conexion
                        conexion = basedatos.conexionsql();
                        //Abriendo conexion
                        conexion.Open();
                        SqlCommand comando = new SqlCommand("select Cliente_nombre, MAX(Importe) Prestamo, MAX(Interes) Intereses, MAX(Almacenaje) Almacenaje, MAX(Iva) Iva, MAX(PorRefrendo) Refrendo from Pagos A Inner Join Boleta_Detalle B on A.IdBoleta=B.Boleta_Id inner join Boleta_Encabezado C on C.boleta_id=B.Boleta_id where idBoleta=" + txtboleta_id.Text + " And linea=4 And ((Convert(varchar,C.Boleta_Fecha_Vencimiento,112)=convert(varchar,getdate(),112))or C.Estado='Vigente') " + " Group by Cliente_Nombre", conexion);
                        SqlDataReader dr = comando.ExecuteReader();

                        if (dr.Read())
                        {
                            txtcliente.Text = dr[0].ToString();
                            txtprestamo.Text = dr[1].ToString();
                            txtalmacenaje.Text = dr[3].ToString();
                            txtiva.Text = dr[4].ToString();
                            txtinteres.Text = dr[2].ToString();
                            txttotal.Text = dr[5].ToString();
                        }
                    }
                }
            }

            catch (Exception)
            {

                MessageBox.Show("Ingrese un Numero de boleta valido", "Error:", MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
            }
        }

        private void Refrendo_Load(object sender, EventArgs e)
        {
            lblusuario.Text = "Cajero: " + Program.Usuario;
            this.numero_refrendo();
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
                    SqlCommand comando = new SqlCommand("select Importe, Interes, Almacenaje, Iva, PorRefrendo from Pagos  A inner join Boleta_Encabezado B on A.idBoleta=B.Boleta_id where B.Estado='Vigente' And A.idBoleta=" + txtboleta_id.Text +"Order by Linea", conexion);
                    SqlDataReader dr = comando.ExecuteReader();
                    DataTable dt = new DataTable();
                    using (dr)
                    {
                        dt.Load(dr);
                    }
                    int i = 1;
                    int contador =Convert.ToInt32( lblrefrendo.Text);
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
                        cmd.Parameters.Add(new SqlParameter("@Prm10",contador));
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
                    rptRefrendo rpt = new rptRefrendo();
                    rpt.IdBoleta = Convert.ToInt32(txtboleta_id.Text);
                    rpt.refrendo = lblrefrendo.Text;
                    rpt.Linea = cbxsemana.SelectedItem.ToString();
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

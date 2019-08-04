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
    public partial class Refrendo_Extemporaneo : Form
    {

        BD basedatos = new BD();
        BaseDeDatos bdatos = new BaseDeDatos();

        private static Refrendo_Extemporaneo m_FormDefInstanceRefrendo_Extemporaneo;

        public static Refrendo_Extemporaneo DefInstance
        {
            get
            {
                if (m_FormDefInstanceRefrendo_Extemporaneo == null || m_FormDefInstanceRefrendo_Extemporaneo.IsDisposed)
                    m_FormDefInstanceRefrendo_Extemporaneo = new Refrendo_Extemporaneo();
                return m_FormDefInstanceRefrendo_Extemporaneo;
            }
            set
            {
                m_FormDefInstanceRefrendo_Extemporaneo = value;
            }
        }

        private void limpiar()
        {
            txtboleta_id.Text = "0"; txtcliente.Text = "";
            txttotal.Text = ""; txtalmacenaje.Text = "";
            txtinteres.Text = ""; txtiva.Text = "";
            txtprestamo.Text = "";
            cbxsemana.SelectedValue = 0;
            txtboleta_id.ReadOnly = false;
        }

        public Refrendo_Extemporaneo()
        {
            InitializeComponent();
            cbxsemana.SelectedItem = "4";
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
                        SqlCommand comando = new SqlCommand("select Cliente_nombre, MAX(Importe) Prestamo, MAX(Interes) Intereses, MAX(Almacenaje) Almacenaje, MAX(Iva) Iva, MAX(PorRefrendo) Refrendo from Pagos A Inner Join Boleta_Detalle B on A.IdBoleta=B.Boleta_Id inner join Boleta_Encabezado C on C.boleta_id=B.Boleta_id where idBoleta=" + txtboleta_id.Text + " And linea=1 And ((Convert(varchar,C.Boleta_Fecha_Vencimiento,112)=convert(varchar,getdate(),112)) and C.Estado='Vigente') " + " Group by Cliente_Nombre", conexion);
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
                        SqlCommand comando = new SqlCommand("select Cliente_nombre, MIN(Importe) Prestamo, MIN(Interes) Intereses, MIN(Almacenaje) Almacenaje, MIN(Iva) Iva, MIN(PorRefrendo) Refrendo from Pagos A Inner Join Boleta_Detalle B on A.IdBoleta=B.Boleta_Id inner join Boleta_Encabezado C on C.boleta_id=B.Boleta_id where idBoleta=" + txtboleta_id.Text + " And linea=1 And ((Convert(varchar,C.Boleta_Fecha_Vencimiento,112)=convert(varchar,getdate(),112)) and C.Estado='Vigente') " + " Group by Cliente_Nombre", conexion);
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
                        else { MessageBox.Show("La Boleta no cumplan con lo seleccionado para realizar el refrendo extemporaneo"); }
                        
                    }
                }
            }

            catch (Exception)
            {

                MessageBox.Show("Ingrese un Numero de boleta valido", "Error:", MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
            }
        }

        private void Refrendo_Extemporaneo_Load(object sender, EventArgs e)
        {
            lblusuario.Text = "Cajero: " + Program.Usuario;
            cbxsemana.Enabled = false;
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

        private void btngenerar_Click(object sender, EventArgs e)
        {
            try
            {
                    if (txtboleta_id.Text != "" && txtcliente.Text != "" && txtinteres.Text != "" && txtiva.Text != "" && txtprestamo.Text != "" && txttotal.Text != "")
                    {
                        BD basedatos = new BD();
                        SqlConnection conexion;
                        //Creando conexion
                        conexion = basedatos.conexionsql();
                        //Abriendo conexion
                        conexion.Open();
                        SqlCommand comando = new SqlCommand("select Importe, Interes, Almacenaje, Iva, PorRefrendo from Pagos  A inner join Boleta_Encabezado B on A.idBoleta=B.Boleta_id where B.Estado='Vigente' And Linea=4 And A.idBoleta=" + txtboleta_id.Text, conexion);
                        SqlDataReader dr = comando.ExecuteReader();
                        DataTable dt = new DataTable();
                        using (dr)
                        {
                            dt.Load(dr);
                        }
                        int i = 4;
                        int contador = Convert.ToInt32(lblrefrendo.Text);
                        foreach (DataRow row in dt.Rows)
                        {
                            SqlCommand cmd = new SqlCommand("Insert Into Refrendo(Boleta_Id, Cliente_Nombre, Prestamo, Interes, Almacenaje, Iva, Total, Fecha,Usuario_Id,refrendo) Values(@Prm1,@Prm2,@Prm3,@Prm4,@Prm5,@Prm6,@Prm7,@Prm8,@Prm9,@Prm10)");
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
                        fecha_vencimiento = fecha_vencimiento.AddDays(7);

                        DateTime fecha_comercializacion = fecha_vencimiento;
                        fecha_comercializacion = fecha_comercializacion.AddDays(2);

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
                        rptRefrendoExtemporaneo rpt = new rptRefrendoExtemporaneo();
                        rpt.IdBoleta = Convert.ToInt32(txtboleta_id.Text);
                        rpt.refrendo = lblrefrendo.Text;
                        rpt.Linea = cbxsemana.SelectedItem.ToString();
                        rpt.ShowDialog(this);
                        rpt.Dispose();
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


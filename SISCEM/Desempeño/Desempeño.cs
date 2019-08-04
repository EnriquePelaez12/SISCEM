using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace SISCEM
{
    public partial class Desempeño : Form
    {
        BD basedatos = new BD();
        BaseDeDatos bdatos = new BaseDeDatos();

        public string valuador_empenio = "";

        private static Desempeño m_FormDefInstanceDesempeño;

        public static Desempeño DefInstance
        {
            get
            {
                if (m_FormDefInstanceDesempeño == null || m_FormDefInstanceDesempeño.IsDisposed)
                    m_FormDefInstanceDesempeño = new Desempeño();
                return m_FormDefInstanceDesempeño;
            }
            set
            {
                m_FormDefInstanceDesempeño = value;
            }
        }

        private void GuardarFicheroBDD(string sRuta, string sFichero)
        {
        //Creamos un nuevo objeto de tipo FileStream para leer el fichero
        //Word en modo binario
        System.IO.FileStream  fs = new FileStream(sRuta + sFichero,
        System.IO.FileMode.Open);
        //Creamos un array de bytes para almacenar los datos leídos por fs.
        Byte[] data = new byte[fs.Length];
        //Y guardamos los datos en el array data
        fs.Read(data, 0, Convert.ToInt32(fs.Length));
        //Abrimos una conexion. En este caso los datos de la cadena de
        //conexion a la base de datos se recuperan de una sección del
        //fichero web.config mediante ConfigurationSettings
        BD basedatos = new BD();
        SqlConnection conexion;
        //Creando conexion
        conexion = basedatos.conexionsql();
        //Abriendo conexion
        conexion.Open();
            //Creamos un comando de tipo StoredProcedure para invocar a
        //UploadDocs
        SqlCommand cmd = new SqlCommand("UploadDoc", conexion);
        cmd.CommandType = CommandType.StoredProcedure;
        //Añadimos los parametros esperados y los valores de los mismos
        cmd.Parameters.Add("@doc", data); //los datos del fichero Word
        cmd.Parameters.Add("@nombre", sFichero); //y su nombre
        cmd.Parameters.Add("@Mov", txtboleta_id.Text); //y su nombre
        cmd.Parameters.Add("nombre_cliente", txtcliente.Text); //y su nombre
        //Ejecutamos el procedimiento almacenado, que inserta un nuevo
        //registro en DocsBinarios con los datos que queremos introducir
        cmd.ExecuteNonQuery();
        //Cerramos la conexión y el fichero
        conexion.Close();
        fs.Close();
        }

        public Desempeño()
        {
            InitializeComponent();
            cbxsemana.SelectedItem = "0";
        }
        private void btnBuscarArchivo_Click(object sender, EventArgs e)
        {

        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtboleta_id.Text != "" && txttotal.Text != "")
                {

                    BD basedatos = new BD();
                    SqlConnection conexion;
                    //Creando conexion
                    conexion = basedatos.conexionsql();
                    //Abriendo conexion
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("Insert Into Desempenio(IdBoleta, Monto, Fecha,Usuario_Id) Values(@IdBoleta, @Monto, @Fecha, @Usuario)", conexion);
                    comando.Parameters.Add(new SqlParameter("@IdBoleta", txtboleta_id.Text));
                    comando.Parameters.Add(new SqlParameter("@Monto", txttotal.Text));
                    comando.Parameters.Add(new SqlParameter("@Fecha", DateTime.Now));
                    comando.Parameters.Add(new SqlParameter("@Usuario", Program.UsuarioId));
                    int res = comando.ExecuteNonQuery();
                    Desempeniorpt rptDesempenio = new Desempeniorpt();
                    rptDesempenio.IdBoleta = Convert.ToInt32(txtboleta_id.Text);
                    rptDesempenio.linea = cbxsemana.SelectedItem.ToString();
                    rptDesempenio.ShowDialog(this);
                    rptDesempenio.Dispose();
                    conexion.Close();

                   

                    string actualizar = "update Boleta_Encabezado set Estado = 'Desempeñado'  where Boleta_id = " + txtboleta_id.Text;

                    if (bdatos.executecommand(actualizar))
                    {
                        Gurda_PDF datos = new Gurda_PDF();
                        datos.Boleta = txtboleta_id.Text;
                        datos.Cliente = txtcliente.Text;
                        datos.Nombre = lblnombre.Text;
                        datos.Movimiento = lbldesempenio.Text;
                        datos.ShowDialog(this);
                        datos.Dispose();
                        MessageBox.Show("Boleta dada de baja correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al Desempeñar");
                    }
                    this.limpiar();
                }
                else { MessageBox.Show("Ingrese un numero de boleta valido"); }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al generar el Desempeño");
            }
            

        }

        private void numero_desempenio()
        {
            try
            {
                string contador;
                SqlConnection Conexion = basedatos.conexionsql();
                Conexion.Open();
                string sql = "Select isnull(Max(IdDesempenio),0) as IdDesempenio  from Desempenio";

                SqlCommand command = new SqlCommand(sql, Conexion);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    contador = Convert.ToString(reader["IdDesempenio"]);
                    lbldesempenio.Text = Convert.ToString(Convert.ToInt32(contador) + 1);
                }
                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                       SqlCommand comando = new SqlCommand("select Cliente_nombre, MAX(Importe) Prestamo, MAX(Interes) Intereses, MAX(Almacenaje) Almacenaje, MAX(Iva) Iva, MAX(PorDesempenio) Desempenio from Pagos A Inner Join Boleta_Detalle B on A.IdBoleta=B.Boleta_Id inner join Boleta_Encabezado C on C.boleta_id=B.Boleta_id where idBoleta=" + txtboleta_id.Text + " And Linea=1 And C.Estado='Vigente' " + " Group by Cliente_Nombre", conexion);
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
                       else { MessageBox.Show("La boleta ya a sido Desempeñada"); txtboleta_id.ReadOnly = false; }
                       lblusuario.Text = "Cajero: " + Program.Usuario;
                   }
                   if (cbxsemana.SelectedItem.ToString() == "2")
                   {
                       BD basedatos = new BD();
                       SqlConnection conexion;
                       //Creando conexion
                       conexion = basedatos.conexionsql();
                       //Abriendo conexion
                       conexion.Open();
                       SqlCommand comando = new SqlCommand("select Cliente_nombre, MAX(Importe) Prestamo, MAX(Interes) Intereses, MAX(Almacenaje) Almacenaje, MAX(Iva) Iva, MAX(PorDesempenio) Desempenio from Pagos A Inner Join Boleta_Detalle B on A.IdBoleta=B.Boleta_Id inner join Boleta_Encabezado C on C.boleta_id=B.Boleta_id where idBoleta=" + txtboleta_id.Text + " And Linea=2 And C.Estado='Vigente' " + " Group by Cliente_Nombre", conexion);
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
                       else { MessageBox.Show("La boleta ya a sido Desempeñada"); txtboleta_id.ReadOnly = false; }
                       lblusuario.Text = "Cajero: " + Program.Usuario;
                   }
                   if (cbxsemana.SelectedItem.ToString() == "3")
                   {
                       BD basedatos = new BD();
                       SqlConnection conexion;
                       //Creando conexion
                       conexion = basedatos.conexionsql();
                       //Abriendo conexion
                       conexion.Open();
                       SqlCommand comando = new SqlCommand("select Cliente_nombre, MAX(Importe) Prestamo, MAX(Interes) Intereses, MAX(Almacenaje) Almacenaje, MAX(Iva) Iva, MAX(PorDesempenio) Desempenio from Pagos A Inner Join Boleta_Detalle B on A.IdBoleta=B.Boleta_Id inner join Boleta_Encabezado C on C.boleta_id=B.Boleta_id where idBoleta=" + txtboleta_id.Text + " And Linea=3 And C.Estado='Vigente' " + " Group by Cliente_Nombre", conexion);
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
                       else { MessageBox.Show("La boleta ya a sido Desempeñada"); txtboleta_id.ReadOnly = false; }
                       lblusuario.Text = "Cajero: " + Program.Usuario;
                   }

                   if (cbxsemana.SelectedItem.ToString() == "4")
                   {
                       BD basedatos = new BD();
                       SqlConnection conexion;
                       //Creando conexion
                       conexion = basedatos.conexionsql();
                       //Abriendo conexion
                       conexion.Open();
                       SqlCommand comando = new SqlCommand("select Cliente_nombre, MAX(Importe) Prestamo, MAX(Interes) Intereses, MAX(Almacenaje) Almacenaje, MAX(Iva) Iva, MAX(PorDesempenio) Desempenio from Pagos A Inner Join Boleta_Detalle B on A.IdBoleta=B.Boleta_Id inner join Boleta_Encabezado C on C.boleta_id=B.Boleta_id where idBoleta=" + txtboleta_id.Text + " And Linea=4 And C.Estado='Vigente' " + " Group by Cliente_Nombre", conexion);
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
                       else { MessageBox.Show("La boleta ya a sido Desempeñada"); txtboleta_id.ReadOnly = false; }
                       lblusuario.Text = "Cajero: " + Program.Usuario;
                   }
                
                }
                else
                {
                    MessageBox.Show("Ingrese el número de boleta");
                }

                lblusuario.Text = "Cajero: " + Program.Usuario;
                txtboleta_id.ReadOnly = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Verifica la informacion introducida");
                this.limpiar();
            }
        }

        private void txtboleta_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.btnbuscar.Select();
            }
        }

        private void Desempeño_Load(object sender, EventArgs e)
        {
            lblusuario.Text = "Cajero: " + Program.Usuario;
            numero_desempenio();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

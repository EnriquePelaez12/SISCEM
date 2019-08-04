using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.SqlTypes;

namespace SISCEM
{
    public partial class Carga_PDF : Form
    {
        public Carga_PDF()
        {
            InitializeComponent();
        }

        private static Carga_PDF m_FormDefInstanceCarga_PDF;

        public static Carga_PDF DefInstance
        {
            get
            {
                if (m_FormDefInstanceCarga_PDF == null || m_FormDefInstanceCarga_PDF.IsDisposed)
                    m_FormDefInstanceCarga_PDF = new Carga_PDF();
                return m_FormDefInstanceCarga_PDF;
            }
            set
            {
                m_FormDefInstanceCarga_PDF = value;
            }
        }


        public string boleta;
        public string cliente;
        public string mov;
        public string nombre;

        private void btnBuscarArchivo_Click(object sender, EventArgs e)
        {
         
            OpenFileDialog open=new OpenFileDialog();
            open.Filter="Archivos PDF(*.pdf)|*.pdf";
            open.Title="Archivos PDF";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = open.FileName;
            }
            open.Dispose();
             
        }
        private void GuardarFicheroBDD(string sRuta, string sFichero)
        {
            //Creamos un nuevo objeto de tipo FileStream para leer el fichero
            //Word en modo binario
            System.IO.FileStream fs = new FileStream(sRuta,
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
            //cmd.Parameters.Add("@doc", data); //los datos del fichero Word
            cmd.Parameters.Add(new SqlParameter("@doc", SqlDbType.VarBinary, data.Length, ParameterDirection.Input, false, 0, 0, "Data", DataRowVersion.Current, (SqlBinary)data));
            cmd.Parameters.Add("@nombre", nombre); //y su nombre
            cmd.Parameters.Add("@Mov", mov); //y su nombre
            cmd.Parameters.Add("@Boleta", boleta); //y su nombre
            cmd.Parameters.Add("nombre_cliente", cliente); //y su nombre
            //Ejecutamos el procedimiento almacenado, que inserta un nuevo
            //registro en DocsBinarios con los datos que queremos introducir
            cmd.ExecuteNonQuery();
            //Cerramos la conexión y el fichero
            conexion.Close();
            fs.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                            
            GuardarFicheroBDD(txtRuta.Text,"");
            this.Close();
            MessageBox.Show("Registro almacenado correctamente");
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo guardar el documento");
            }
        }
        
    }
}

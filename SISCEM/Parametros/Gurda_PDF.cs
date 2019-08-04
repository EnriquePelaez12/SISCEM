using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.IO;


namespace SISCEM
{
    public partial class Gurda_PDF : Form
    {
        public string Boleta;
        public string Cliente;
        public string Movimiento;
        public string Nombre;

        SqlConnection conex = new SqlConnection(@"Server=JHUERTA\SQL2016; initial Catalog=PRESTO; Integrated Security=True");//"Integrated security=true;server=(local);database=PRESTO");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dtb;
        string ar = "";

        private static Gurda_PDF m_FormDefInstanceGurda_PDF;

        public static Gurda_PDF DefInstance
        {
            get
            {
                if (m_FormDefInstanceGurda_PDF == null || m_FormDefInstanceGurda_PDF.IsDisposed)
                    m_FormDefInstanceGurda_PDF = new Gurda_PDF();
                return m_FormDefInstanceGurda_PDF;
            }
            set
            {
                m_FormDefInstanceGurda_PDF = value;
            }
        }


        public Gurda_PDF()
        {
            InitializeComponent();
        }

        private void Gurda_PDF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_PDF.documentos' table. You can move, or remove it, as needed.
            this.documentosTableAdapter.Fill(this.dS_PDF.documentos);            
            // TODO: esta línea de código carga datos en la tabla 'ejemploDataSet.documentos' Puede moverla o quitarla según sea necesario.
            //this.documentosTableAdapter.Fill(this.ejemploDataSet.documentos);
            this.txtRuta.Enabled = false;
         
        }

        private void btnexaminar_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            ar = this.openFileDialog1.FileName;
            this.txtRuta.Text = ar; 
        }
        private void Limpiar()
        {
            txtRuta.Clear();
            txtTitulo.Clear();
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRuta.Text != "" && txtTitulo.Text != "")
                {
                    FileStream fs = new FileStream(ar, FileMode.Open);
                    //Creamos un array de bytes para almacenar los datos leídos por fs.
                    Byte[] data = new byte[fs.Length];
                    //Y guardamos los datos en el array data
                    fs.Read(data, 0, Convert.ToInt32(fs.Length));
                    if (conex.State == 0) { conex.Open(); }
                    cmd = new SqlCommand("UploadDoc", conex);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Doc", SqlDbType.VarBinary).Value = data;
                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = Nombre;
                    cmd.Parameters.Add("@Boleta", SqlDbType.VarChar, 100).Value = Boleta;
                    cmd.Parameters.Add("@Movimiento", SqlDbType.VarChar, 100).Value = Movimiento;
                    cmd.Parameters.Add("@Cliente", SqlDbType.VarChar, 200).Value = Cliente;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Guardado Correctamente");
                    this.documentosTableAdapter.Fill(this.dS_PDF.documentos);
                    conex.Close();
                    fs.Close();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Adjuntar y escribir Título");
                }

            }
            catch (Exception)
            {
                throw;
            }            
        }

        private string GenerarNombreFichero()
        {
            int ultimoTick = 0;
            while (ultimoTick == Environment.TickCount)
            {
                System.Threading.Thread.Sleep(1);
            }
            ultimoTick = Environment.TickCount;
            return DateTime.Now.ToString("yyyyMMddhhmmss") + "." +
            ultimoTick.ToString();
        }

        private void btnleer_Click(object sender, EventArgs e)
        {
            try
            {
                int i = this.dataGridView1.CurrentRow.Index;
                int cod = int.Parse(this.dataGridView1.Rows[i].Cells[0].Value.ToString());
                cmd = new SqlCommand("select doc from documentos where DocId=" + cod + "", conex);
                da = new SqlDataAdapter(cmd);
                dtb = new DataTable();
                da.Fill(dtb);
                DataRow f = dtb.Rows[0];
                byte[] bits = ((byte[])(f.ItemArray[0]));
                string sFile = "tmp" + GenerarNombreFichero() + ".pdf";
                FileStream fs = new FileStream(sFile, FileMode.Create);
                //Y escribimos en disco el array de bytes que conforman
                //el fichero Word
                fs.Write(bits, 0, Convert.ToInt32(bits.Length));
                fs.Close();
                System.Diagnostics.Process obj = new System.Diagnostics.Process();
                obj.StartInfo.FileName = sFile;
                obj.Start();
            }
            catch (Exception)
            {

                throw;
            }            
        }
    }
}

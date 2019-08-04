using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;


namespace SISCEM
{
    public partial class Alta_Clientes : Form
    {
        private bool ExistenDispositivos = false;
        private FilterInfoCollection DispositivosDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;
        private static Alta_Clientes m_FormDefInstanceAlta_Clientes;
        ClsEstado Est = new ClsEstado();
        ClsMunicipio Mun = new ClsMunicipio();
        ClsColonia Col = new ClsColonia();
        ClsOcupacion Ocp = new ClsOcupacion();
        ClsEstadoCivil EstadoCivil = new ClsEstadoCivil();
        ClsSexo Sexo = new ClsSexo();
        BD basedatos = new BD();
        BaseDeDatos bdatos = new BaseDeDatos();
        public static Alta_Clientes DefInstance
        {
            get
            {
                if (m_FormDefInstanceAlta_Clientes == null || m_FormDefInstanceAlta_Clientes.IsDisposed)
                    m_FormDefInstanceAlta_Clientes = new Alta_Clientes();
                return m_FormDefInstanceAlta_Clientes;
            }
            set
            {
                m_FormDefInstanceAlta_Clientes = value;
            }
        }

      
        
        public Alta_Clientes()
        {
            InitializeComponent();
            BuscarDispositivos();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

          public void limpiar()
         {
            
            txtNombre.Text = "";
            txtnombrecomercial.Text = "";
            txtpaterno.Text = "";
            txtmaterno.Text = "";
            txtcotitular.Text="";
            txtcp.Text="";
            txtcedula.Text = "";
            txtdireccion.Text = "";
            txtemail.Text = "";
            txtcelular.Text = "";
            txttelefono.Text = "";
            txtfax.Text="";
            txtidcliente.Text = "";
            txtclienteid.Text = "";
            cmbocupacion.SelectedIndex = 0; ;
            cmbestado.SelectedIndex = 0;
            cmbestadocivil.SelectedIndex = 0;
            cmbsexo.SelectedIndex = 0;
            cmbcolonia.Items.Insert(0, "Seleccionar");
            cmbcolonia.SelectedIndex = 0;
            cmbmunicipio.Items.Insert(0, "Seleccionar");
            cmbmunicipio.SelectedIndex = 0;
            
        }

        private void lblguardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNombre.Text == "" || txtpaterno.Text == "" || txtmaterno.Text == "" || txtnombrecomercial.Text == "" || txtcedula.Text == "" || txtcotitular.Text == "" || txtcp.Text == "" || txtdireccion.Text == "" || txtemail.Text == "" || txtcelular.Text == "" || txtfax.Text == "" | txttelefono.Text == "")
                        MessageBox.Show("Le falta escribir algunos datos.", "Error:", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                     else
                        {
                            MemoryStream ms = new MemoryStream();
                            Image i = Image.FromFile("D:\\" + txtclienteid.Text + txtNombre.Text + ".jpg");
                            i.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                            byte[] imagen = ms.GetBuffer();
    
                            string dtme = Convert.ToString(DateTime.Now.ToShortDateString());
                            DateTime fecha = Convert.ToDateTime(dtme);
                            string agregar = "Insert into Cliente ( Cliente_Nombre,     Cliente_Apellido_Paterno,       Cliente_Apellido_Materno,         Cliente_Nombre_Comercial," +
                                                                   "Cliente_Cedula,     Cotitular,                      Cliente_cp,"  +
                                                                   "Cliente_Direccion,  Cliente_Email,                  Cliente_Celular,"  +
                                                                   "Cliente_Fax,        Cliente_Telefono,               Sexo_Id,"  +
                                                                   "Estado_Civil_Id,    Estado_Id,                      Municipio_Id," +
                                                                   "Colonia_Id,         Ocupacion_Id,                   Imagen,             Cliente_Fec_Actualizacion) "+
                                                      " Values  ( '" + txtNombre.Text +
                                                                "','" + txtpaterno.Text +
                                                                "','" + txtmaterno.Text +
                                                                "','" + txtnombrecomercial.Text + 
                                                                "','" + txtcedula.Text + 
                                                                "','" + txtcotitular.Text + 
                                                                "','" + txtcp.Text + 
                                                                "','" + txtdireccion.Text + 
                                                                "','" + txtemail.Text + 
                                                                "','" + txtcelular.Text + 
                                                                "','" + txtfax.Text + 
                                                                "','" + txttelefono.Text + 
                                                                "','" + Convert.ToInt16(cmbsexo.SelectedValue) +
                                                                "','" + Convert.ToInt16(cmbestadocivil.SelectedValue)+
                                                                "','" + Convert.ToInt16(cmbestado.SelectedValue)+
                                                                "','" + Convert.ToInt16(cmbmunicipio.SelectedValue) + 
                                                                "','" + Convert.ToInt16(cmbcolonia.SelectedValue)+
                                                                "','" + Convert.ToInt16(cmbocupacion.SelectedValue)+
                                                                "','" + imagen +
                                                                "','" + fecha.ToString("yyyy-MM-dd hh:mm") + "')";



                            if (bdatos.executecommand(agregar))
                            {
                                MessageBox.Show("Registro agregado correctamente");
                                dgvcliente.DataSource = bdatos.SelectDataTable(
                                                                 "Select B.Cliente_Id					As Id,                  " +
                                                                 "       B.Cliente_Nombre				As Nombre,              " +
                                                                 "       B.Cliente_Apellido_Materno		As Apellido_Materno,    " +
                                                                 "       B.Cliente_Apellido_Paterno		As Apellido_Paterno,    " +
                                                                 "       B.Cliente_Nombre_Comercial     As Nombre_Comercial,    " +
                                                                 "       B.Cliente_Direccion			As Direccion,           " +
                                                                 "       B.Cliente_Email				As Email,               " +
                                                                 "       B.Cliente_Celular				As Celular,             " +
                                                                 "       B.Cliente_Telefono				As Telefono,            " +
                                                                 "       B.Cotitular					As Cotitular,           " +
                                                                 "       B.Cliente_Cedula				As Cedula,              " +
                                                                 "       B.Cliente_Cp					As CP,                  " +
                                                                 "       B.Cliente_Fax					As Fax,                 " +
                                                                 "       C.Estado_Nombre				As Estado,              " +
                                                                 "       D.Municipio_Nombre				As Municipio,           " +
                                                                 "       E.Colonia_Nombre				AS Coloni,              " +
                                                                 "       A.Descripcion					As Ocupacion,           " +
                                                                 "       G.Nombre						As Sexo,                " +
                                                                 "       H.Descripcion					As	Estado_Civil        " +
                                                                 "       From	Ocupacion A ,                                   " +
                                                                 "               Cliente B,                                     " +
                                                                 "               Estado C,                                      " +
                                                                 "               Municipio D,                                   " +
                                                                 "               Colonia		E,                              " +
                                                                 "               Ocupacion  F,                                  " +
                                                                 "               Sexo		G,                                  " +
                                                                 "               Estado_Civil H		                            " +
                                                                 "       Where 	B.Ocupacion_Id	= A.Ocupacion_Id                " +
                                                                 "       And	 B.Ocupacion_Id		= F.Ocupacion_Id	        " +
                                                                 "       And  B.Estado_Civil_Id	= H.Estado_Civil_Id             " +
                                                                 "       And  B.Estado_Id		= C.Estado_Id                   " +
                                                                 "       And  B.Municipio_Id		= D.Municipio_Id            " +
                                                                 "       And  B.Estado_Id		= D.Estado_Id                   " +
                                                                 "       And  B.Colonia_Id		= E.Colonia_Id                  " +
                                                                 "       And  B.Estado_Id		= E.Estado_Id                   " +
                                                                 "       And  B.Municipio_Id		= E.Municipio_Id 		    " +
                                                                 "       And  B.Sexo_Id			= G.Sexo_Id                     " +
                                                                 "       And  D.Municipio_Id		= E.Municipio_Id            " +
                                                                 "       And  D.Estado_Id		= E.Estado_Id                   " +
                                                                 "       And  C.Estado_Id		= D.Estado_Id                   " +
                                                                 "       And  D.Municipio_Id		= E.Municipio_Id            " +
                                                                 "       And  C.Estado_Id		= E.Estado_Id                   ");
                                this.limpiar();
                            }
                            else
                            {
                                MessageBox.Show("Error al agregar");
                            }

                        }

             }//try
                catch (SqlException excep)
                   {
                        MessageBox.Show(excep.Message);
                   }//catch
           }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtidcliente.Text == "")
                {
                    MessageBox.Show("Igrese un valor");
                }
                else
                {
                    dgvcliente.DataSource = bdatos.SelectDataTable("Select B.Cliente_Id					As Id,                  " +
		                                                         "       B.Cliente_Nombre				As Nombre,              " +
		                                                         "       B.Cliente_Apellido_Materno		As Apellido_Materno,    " +
		                                                         "       B.Cliente_Apellido_Paterno		As Apellido_Paterno,    " +
                                                                 "       B.Cliente_Nombre_Comercial     As Nombre_Comercial,    " +
		                                                         "       B.Cliente_Direccion			As Direccion,           " +
		                                                         "       B.Cliente_Email				As Email,               " +
		                                                         "       B.Cliente_Celular				As Celular,             " +
		                                                         "       B.Cliente_Telefono				As Telefono,            " +
		                                                         "       B.Cotitular					As Cotitular,           " +
                                                                 "       B.Cliente_Cedula				As Cedula,              " +
		                                                         "       B.Cliente_Cp					As CP,                  " +
                                                                 "       B.Cliente_Fax					As Fax,                 " +
		                                                         "       C.Estado_Nombre				As Estado,              " +
		                                                         "       D.Municipio_Nombre				As Municipio,           " +
		                                                         "       E.Colonia_Nombre				AS Coloni,              " +
		                                                         "       A.Descripcion					As Ocupacion,           " +
		                                                         "       G.Nombre						As Sexo,                " +
		                                                         "       H.Descripcion					As	Estado_Civil        " +
		                                                         "       From	Ocupacion A ,                                   " +
				                                                 "               Cliente B,                                     " +
				                                                 "               Estado C,                                      " +
				                                                 "               Municipio D,                                   " +
				                                                 "               Colonia		E,                              " +
				                                                 "               Ocupacion  F,                                  " +
				                                                 "               Sexo		G,                                  " +
				                                                 "               Estado_Civil H		                            " +
		                                                         "       Where 	B.Ocupacion_Id	= A.Ocupacion_Id                " +
		                                                         "       And	 B.Ocupacion_Id		= F.Ocupacion_Id	        " +
		                                                         "       And  B.Estado_Civil_Id	= H.Estado_Civil_Id             " +
		                                                         "       And  B.Estado_Id		= C.Estado_Id                   " +
		                                                         "       And  B.Municipio_Id		= D.Municipio_Id            " +
		                                                         "       And  B.Estado_Id		= D.Estado_Id                   " +
		                                                         "       And  B.Colonia_Id		= E.Colonia_Id                  " +
		                                                         "       And  B.Estado_Id		= E.Estado_Id                   " +
		                                                         "       And  B.Municipio_Id		= E.Municipio_Id 		    " +
		                                                         "       And  B.Sexo_Id			= G.Sexo_Id                     " +
		                                                         "       And  D.Municipio_Id		= E.Municipio_Id            " +
		                                                         "       And  D.Estado_Id		= E.Estado_Id                   " +
		                                                         "       And  C.Estado_Id		= D.Estado_Id                   " +
		                                                         "       And  D.Municipio_Id		= E.Municipio_Id            " +
		                                                         "       And  C.Estado_Id		= E.Estado_Id                   " + 
                                                                 "       And  B.Cliente_Id      =   "+txtidcliente.Text);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Alta_Clientes_Load(object sender, EventArgs e)
        {
               
            dgvcliente.DataSource = bdatos.SelectDataTable("Select B.Cliente_Id					As Id,                  " +
                                                                 "       B.Cliente_Nombre				As Nombre,              " +
                                                                 "       B.Cliente_Apellido_Materno		As Apellido_Materno,    " +
                                                                 "       B.Cliente_Apellido_Paterno		As Apellido_Paterno,    " +
                                                                 "       B.Cliente_Nombre_Comercial     As Nombre_Comercial,    " +
                                                                 "       B.Cliente_Direccion			As Direccion,           " +
                                                                 "       B.Cliente_Email				As Email,               " +
                                                                 "       B.Cliente_Celular				As Celular,             " +
                                                                 "       B.Cliente_Telefono				As Telefono,            " +
                                                                 "       B.Cotitular					As Cotitular,           " +
                                                                 "       B.Cliente_Cedula				As Cedula,              " +
                                                                 "       B.Cliente_Cp					As CP,                  " +
                                                                 "       B.Cliente_Fax					As Fax,                 " +
                                                                 "       C.Estado_Nombre				As Estado,              " +
                                                                 "       D.Municipio_Nombre				As Municipio,           " +
                                                                 "       E.Colonia_Nombre				AS Coloni,              " +
                                                                 "       A.Descripcion					As Ocupacion,           " +
                                                                 "       G.Nombre						As Sexo,                " +
                                                                 "       H.Descripcion					As	Estado_Civil        " +
                                                                 "       From	Ocupacion A ,                                   " +
                                                                 "               Cliente B,                                     " +
                                                                 "               Estado C,                                      " +
                                                                 "               Municipio D,                                   " +
                                                                 "               Colonia		E,                              " +
                                                                 "               Ocupacion  F,                                  " +
                                                                 "               Sexo		G,                                  " +
                                                                 "               Estado_Civil H		                            " +
                                                                 "       Where 	B.Ocupacion_Id	= A.Ocupacion_Id                " +
                                                                 "       And	 B.Ocupacion_Id		= F.Ocupacion_Id	        " +
                                                                 "       And  B.Estado_Civil_Id	= H.Estado_Civil_Id             " +
                                                                 "       And  B.Estado_Id		= C.Estado_Id                   " +
                                                                 "       And  B.Municipio_Id		= D.Municipio_Id            " +
                                                                 "       And  B.Estado_Id		= D.Estado_Id                   " +
                                                                 "       And  B.Colonia_Id		= E.Colonia_Id                  " +
                                                                 "       And  B.Estado_Id		= E.Estado_Id                   " +
                                                                 "       And  B.Municipio_Id		= E.Municipio_Id 		    " +
                                                                 "       And  B.Sexo_Id			= G.Sexo_Id                     " +
                                                                 "       And  D.Municipio_Id		= E.Municipio_Id            " +
                                                                 "       And  D.Estado_Id		= E.Estado_Id                   " +
                                                                 "       And  C.Estado_Id		= D.Estado_Id                   " +
                                                                 "       And  D.Municipio_Id		= E.Municipio_Id            " +
                                                                 "       And  C.Estado_Id		= E.Estado_Id                   ");

            this.numero_cliente();
            this.CargarEstado();
            this.CargarOcupacion();
            this.CargarEstadoCivil();
            this.CargarSexo();
            
            

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                string dtme = Convert.ToString(DateTime.Now.ToShortDateString());
                DateTime fecha = Convert.ToDateTime(dtme);
                if (txtclienteid.Text == "")
                {
                    MessageBox.Show("ingrese un numero de sucursal.", "Error:", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                else
                {
                    string actualizar = "update Cliente set Cliente_Nombre = '" + txtNombre.Text
                                             + "',Cliente_Nombre_Comercial = '" + txtnombrecomercial.Text
                                             + "',Cliente_Apellido_Paterno = '" + txtpaterno.Text
                                             + "',Cliente_Apellido_Materno = '" + txtmaterno.Text
                                             + "',Cliente_Cedula = '" + txtcedula.Text
                                             + "' ,Cotitular= '" + txtcotitular.Text
                                             + "',Cliente_cp= '" + txtcp.Text
                                             + "',Cliente_Direccion = '" + txtdireccion.Text
                                             + "',Cliente_Email = '" + txtemail.Text
                                             + "',Cliente_Celular = '" + txtcelular.Text
                                             + "',Cliente_Fax = '" + txtfax.Text
                                             + "',Cliente_Telefono = '" + txttelefono.Text
                                             + "',Sexo_Id='" + Convert.ToInt16(cmbsexo.SelectedValue) 
                                             + "',Estado_Civil_Id='" + Convert.ToInt16(cmbestadocivil.SelectedValue) 
                                             + "',Estado_Id='" + Convert.ToInt16(cmbestado.SelectedValue)
                                             + "',Municipio_Id='" + Convert.ToInt16(cmbmunicipio.SelectedValue)
                                             + "',Colonia_Id='" + Convert.ToInt16(cmbcolonia.SelectedValue)
                                             + "',Ocupacion_Id='" + Convert.ToInt16(cmbocupacion.SelectedValue)
                                             + "',Cliente_Fec_Actualizacion = '" + fecha.ToString("yyyy-MM-dd hh:mm")
                                             + "' where Cliente_id = " + txtclienteid.Text;

                 

                    if (bdatos.executecommand(actualizar))
                    {
                        MessageBox.Show("Registro actualizado correctamente");
                        dgvcliente.DataSource = bdatos.SelectDataTable(
                                                                 "Select B.Cliente_Id					As Id,                  " +
		                                                         "       B.Cliente_Nombre				As Nombre,              " +
		                                                         "       B.Cliente_Apellido_Materno		As Apellido_Materno,    " +
		                                                         "       B.Cliente_Apellido_Paterno		As Apellido_Paterno,    " +
                                                                 "       B.Cliente_Nombre_Comercial     As Nombre_Comercial,    " +
		                                                         "       B.Cliente_Direccion			As Direccion,           " +
		                                                         "       B.Cliente_Email				As Email,               " +
		                                                         "       B.Cliente_Celular				As Celular,             " +
		                                                         "       B.Cliente_Telefono				As Telefono,            " +
		                                                         "       B.Cotitular					As Cotitular,           " +
                                                                 "       B.Cliente_Cedula				As Cedula,              " +
		                                                         "       B.Cliente_Cp					As CP,                  " +
                                                                 "       B.Cliente_Fax					As Fax,                 " +
		                                                         "       C.Estado_Nombre				As Estado,              " +
		                                                         "       D.Municipio_Nombre				As Municipio,           " +
		                                                         "       E.Colonia_Nombre				AS Coloni,              " +
		                                                         "       A.Descripcion					As Ocupacion,           " +
		                                                         "       G.Nombre						As Sexo,                " +
		                                                         "       H.Descripcion					As	Estado_Civil        " +
		                                                         "       From	Ocupacion A ,                                   " +
				                                                 "               Cliente B,                                     " +
				                                                 "               Estado C,                                      " +
				                                                 "               Municipio D,                                   " +
				                                                 "               Colonia		E,                              " +
				                                                 "               Ocupacion  F,                                  " +
				                                                 "               Sexo		G,                                  " +
				                                                 "               Estado_Civil H		                            " +
		                                                         "       Where 	B.Ocupacion_Id	= A.Ocupacion_Id                " +
		                                                         "       And	 B.Ocupacion_Id		= F.Ocupacion_Id	        " +
		                                                         "       And  B.Estado_Civil_Id	= H.Estado_Civil_Id             " +
		                                                         "       And  B.Estado_Id		= C.Estado_Id                   " +
		                                                         "       And  B.Municipio_Id		= D.Municipio_Id            " +
		                                                         "       And  B.Estado_Id		= D.Estado_Id                   " +
		                                                         "       And  B.Colonia_Id		= E.Colonia_Id                  " +
		                                                         "       And  B.Estado_Id		= E.Estado_Id                   " +
		                                                         "       And  B.Municipio_Id		= E.Municipio_Id 		    " +
		                                                         "       And  B.Sexo_Id			= G.Sexo_Id                     " +
		                                                         "       And  D.Municipio_Id		= E.Municipio_Id            " +
		                                                         "       And  D.Estado_Id		= E.Estado_Id                   " +
		                                                         "       And  C.Estado_Id		= D.Estado_Id                   " +
		                                                         "       And  D.Municipio_Id		= E.Municipio_Id            " +
		                                                         "       And  C.Estado_Id		= E.Estado_Id                   ");
                        this.limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la informacion");
            }

        }

        private void obtiene_Imagen(int id)
        {
        try
            {
                
                SqlConnection Conexion = basedatos.conexionsql();
                Conexion.Open();
                string sql = "Select Imagen from Cliente Where Cliente_Id =   " + id;

                SqlCommand command = new SqlCommand(sql, Conexion);
                SqlDataReader lector = command.ExecuteReader();

                if (lector.Read())
                {
                    byte[] arreglo = (byte[])lector["Imagen"];
                    MemoryStream m = new MemoryStream(arreglo);                                                                                                                                          
                    Image imagen = Image.FromStream(m);
                    pbFotoUser.Image = imagen;
                    lector.Close();
                    Conexion.Close();
                }
              }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        
        }
        private void dgvcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgvcliente.Rows[e.RowIndex];

                txtclienteid.Text = dgv.Cells[0].Value.ToString();
                txtNombre.Text = dgv.Cells[1].Value.ToString();
                txtpaterno.Text = dgv.Cells[2].Value.ToString();
                txtmaterno.Text = dgv.Cells[3].Value.ToString();
                txtnombrecomercial.Text = dgv.Cells[4].Value.ToString();
                txtdireccion.Text = dgv.Cells[5].Value.ToString();
                txtemail.Text = dgv.Cells[6].Value.ToString();
                txtcelular.Text = dgv.Cells[7].Value.ToString();
                txttelefono.Text = dgv.Cells[8].Value.ToString();
                txtcotitular.Text = dgv.Cells[9].Value.ToString();
                txtcedula.Text = dgv.Cells[10].Value.ToString();                
                txtcp.Text = dgv.Cells[11].Value.ToString();
                txtfax.Text = dgv.Cells[12].Value.ToString();
                cmbestado.Text = dgv.Cells[13].Value.ToString();
                cmbmunicipio.Text = dgv.Cells[14].Value.ToString();
                cmbcolonia.Text = dgv.Cells[15].Value.ToString();
                cmbocupacion.Text = dgv.Cells[16].Value.ToString();
                cmbsexo.Text = dgv.Cells[17].Value.ToString();
                cmbestadocivil.Text = dgv.Cells[18].Value.ToString();
                obtiene_Imagen(Convert.ToInt32(txtclienteid.Text));
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un valor");
            }
        }

        //Codigo para grabar fotos
        //Variables



        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (btnIniciar.Text == "Iniciar")
            {
                if (ExistenDispositivos)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[cboDispositivos.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
                    FuenteDeVideo.Start();
                    btnIniciar.Text = "Detener";
                    cboDispositivos.Enabled = false;
                    //gbMenu.Text = DispositivosDeVideo[cboDispositivos.SelectedIndex].Name.ToString();
                }
                else
                    MessageBox.Show("Error: No se encuentra dispositivo.");
            }
            else
            {
                try
                {                
                //if (FuenteDeVideo.IsRunning)
                //{
                    TerminarFuenteDeVideo();
                    btnIniciar.Text = "Iniciar";
                    cboDispositivos.Enabled = true;
                //}
                }
                catch (Exception)
                {
                                     
                }
            }


        }

        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++)
                cboDispositivos.Items.Add(Dispositivos[i].Name.ToString()); //cboDispositivos es nuestro combobox
            cboDispositivos.Text = cboDispositivos.Items[0].ToString();
        }

        public void BuscarDispositivos()
        {
            DispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivosDeVideo.Count == 0)
                ExistenDispositivos = false;
            else
            {
                ExistenDispositivos = true;
                CargarDispositivos(DispositivosDeVideo);
            }
        }

        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }
        }

        private void video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pbFotoUser.Image = Imagen; //pbFotoUser es nuestro pictureBox
        }

        private void btnsavefoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "")
                { MessageBox.Show("No existe un nombre de cliente"); }
                else
                {
                    pbFotoUser.Image.Save("D:\\"+txtclienteid.Text + txtNombre.Text + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    MessageBox.Show("Imagen guardada Correctamente");
                    TerminarFuenteDeVideo();
                }

            }

            catch (Exception)
            {

                MessageBox.Show("Error al agregar la imagen");
            }
            
        }

         private void numero_cliente()
        {
            try
            {
                string contador;
                SqlConnection Conexion = basedatos.conexionsql();
                Conexion.Open();
                string sql = "Select isnull(Max(cliente_Id),0) as numero_cliente  from Cliente";

                SqlCommand command = new SqlCommand(sql, Conexion);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    contador = Convert.ToString(reader["numero_cliente"]);
                    txtclienteid.Text = Convert.ToString(Convert.ToInt32(contador) + 1);
                }
                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
         }

         private void btnsalir_Click(object sender, EventArgs e)
         {
             this.Close();
         }
         private void CargarEstado()
         {
             cmbestado.DataSource = Est.ListarEstado();
             cmbestado.DisplayMember = "Estado_Nombre";
             cmbestado.ValueMember = "Estado_Id";
         }

         private void CargarColonia()
         {
             int municipio_Id = Convert.ToInt16(cmbmunicipio.SelectedValue);
             int Estado_id = Convert.ToInt16(cmbestado.SelectedValue);
             if (cmbmunicipio.Items.Count != 0)
              {
                  cmbcolonia.DataSource = Col.BuscarColonia_x_Municipio(municipio_Id, Estado_id);
                  cmbcolonia.DisplayMember = "Colonia_Nombre";
                  cmbcolonia.ValueMember = "Colonia_Id";
              }
              else
              {
                  cmbcolonia.DataSource = null; 
              }
         }

         private void CargarMunicipio()
         {
             int Estad_Id =Convert.ToInt16(cmbestado.SelectedValue);
             if (cmbestado.Items.Count != 0)
             {
                 cmbmunicipio.DataSource = Mun.BuscarMunicipio_x_Estado(Estad_Id);
                 cmbmunicipio.DisplayMember = "Municipio_Nombre";
                 cmbmunicipio.ValueMember = "Municipio_Id";
             }
             else
             { 
                 cmbmunicipio.DataSource = null; 
             }
         }

         private void CargarOcupacion()
         {

             cmbocupacion.DataSource = Ocp.ListarOcupacion();
             cmbocupacion.DisplayMember = "Descripcion";
             cmbocupacion.ValueMember = "Ocupacion_Id";
         }

         private void CargarEstadoCivil()
         {
             cmbestadocivil.DataSource = EstadoCivil.ListarEstadoCivil();
             cmbestadocivil.DisplayMember = "Descripcion";
             cmbestadocivil.ValueMember = "Estado_Civil_Id";
         }
         private void CargarSexo()
         {
             cmbsexo.DataSource = Sexo.ListarSexo();
             cmbsexo.DisplayMember = "Nombre";
             cmbsexo.ValueMember = "Sexo_Id";
         }

       
         private void cmbestado_SelectionChangeCommitted(object sender, EventArgs e)
         {
             this.CargarMunicipio();

         }

         private void cmbmunicipio_SelectionChangeCommitted(object sender, EventArgs e)
         {
             this.CargarColonia();
         }

        
    }
}

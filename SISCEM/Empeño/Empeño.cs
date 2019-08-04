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
    public partial class Empeño : Form
    {

        public string idboleta { get; set; }
        public string valuador_empenio = "";
        //Instaciamos la clase 
       // private readonly List<EEmpenio> _empenio = new List<EEmpenio>();
       

        public Empeño()
        {
            InitializeComponent();
        }
        BaseDeDatos bdatos = new BaseDeDatos();
             
        private static Empeño m_FormDefInstanceempeño;

        public static Empeño DefInstance
        {
            get
            {
                if (m_FormDefInstanceempeño == null || m_FormDefInstanceempeño.IsDisposed)
                    m_FormDefInstanceempeño = new Empeño();
                return m_FormDefInstanceempeño;
            }
            set
            {
                m_FormDefInstanceempeño = value;
            }
        }

        BD basedatos = new BD();

        private void CargaCombos()
        {//MostrarDatos
            try
            {//try
                SqlConnection Conexion = basedatos.conexionsql();
                string CTipo = "Select Categoria_Id,Categoria_Nombre from Categoria Order by Categoria_Id;";
                string CKilataje = "Select Kilataje_id,Kilataje_valor from  Kilataje order by kilataje_valor;";
                string CEstado = "Select idpresentacion,presentacion from presentaciones order by idpresentacion;";
                string Cplazo = "Select Plazo_id,plazo_nombre from plazo";
                
                DataSet ds_tipo = new DataSet();
                SqlDataAdapter Tipo = new SqlDataAdapter(CTipo, Conexion);
                Tipo.Fill(ds_tipo,"Categoria");
                cbxtipo.DataSource=ds_tipo.Tables[0].DefaultView;
                cbxtipo.ValueMember="Categoria_Id";
                cbxtipo.DisplayMember="Categoria_Nombre";


                DataSet ds_kilataje = new DataSet();
                SqlDataAdapter kilataje = new SqlDataAdapter(CKilataje, Conexion);
                kilataje.Fill(ds_kilataje, "Kilataje");
                cmbkilataje.DataSource = ds_kilataje.Tables[0].DefaultView;
                cmbkilataje.ValueMember = "Kilataje_id";
                cmbkilataje.DisplayMember = "Kilataje_valor";

                DataSet ds_Estado = new DataSet();
                SqlDataAdapter Estado = new SqlDataAdapter(CEstado, Conexion);
                Estado.Fill(ds_Estado, "presentaciones");
                cmbpresentacion.DataSource = ds_Estado.Tables[0].DefaultView;
                cmbpresentacion.ValueMember = "idpresentacion";
                cmbpresentacion.DisplayMember = "presentacion";

                DataSet ds_Plazo = new DataSet();
                SqlDataAdapter plazo = new SqlDataAdapter(Cplazo, Conexion);
                plazo.Fill(ds_Plazo, "plazo");
                cmbplazo.DataSource = ds_Plazo.Tables[0].DefaultView;
                cmbplazo.ValueMember = "Plazo_id";
                cmbplazo.DisplayMember = "plazo_nombre";

                

                int kil = Convert.ToInt32(cbxtipo.SelectedValue);

                if (kil > 0)
                {
                    string Cmarca = "Select subcategoria_id,Subcategoria_Nombre From Sub_categoria where Categoria_id= " + kil;

                    DataSet ds_marca = new DataSet();
                    SqlDataAdapter marca = new SqlDataAdapter(Cmarca, Conexion);
                    marca.Fill(ds_marca, "sub_categoria");
                    cmbmarca.DataSource = ds_marca.Tables[0].DefaultView;
                    cmbmarca.ValueMember = "subcategoria_id";
                    cmbmarca.DisplayMember = "Subcategoria_nombre";

                }
                else
                {
                 
                }
                lblprestamo.Enabled = false;
                txtprestamo.Enabled = false;

            }//try
            catch (SqlException excep)
            {//catch
                MessageBox.Show(excep.Message);
            }//catch
        }//MostrarDatos
        
        private void limapiar()
        {
            txtcotitular.Text="";
            txtdireccion.Text = "";
            txtemail.Text = "";
            txtNombre.Text = "";
            txtpeso.Text = "0";
            txtpiedra.Text= "0";
            txtdescripcion.Text = "";
            lblkilataje.Enabled = true;
            cmbkilataje.Enabled = true;
            lblpiedra.Enabled = true;
            txtpiedra.Enabled = true;
            
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            this.limapiar();
        }

        private void Empeño_Load(object sender, EventArgs e)
        {
            try
            {            
                txtpiedra.Text = "0";
                txtpeso.Text = "0";
                txtprestamo.Text = "0";
                this.numero_boleta();
                this.CargaCombos();
                lbluser.Text = "Valuador: " + Program.Usuario; //valuador_empenio;
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique a su Administrador", "Error:", MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
            }     
           
            //_working = "Add";
        }
        private void recargaboleta()
        {
            txtpiedra.Text = "0";
            txtpeso.Text = "0";
            txtprestamo.Text = "0";
            this.numero_boleta();
            this.CargaCombos();
            //lbluser.Text = valuador_empenio;
            lbluser.Text = "Valuador: " + Program.Usuario; //valuador_empenio;
        }

        private void numero_boleta()
        {
            try
            {
                string contador;
                SqlConnection Conexion = basedatos.conexionsql();
                Conexion.Open();
                string sql = "Select isnull(Max(Boleta_Id),0) as numero_boleta  from Boleta_encabezado";

                SqlCommand command = new SqlCommand(sql, Conexion);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    contador= Convert.ToString(reader["numero_boleta"]);
                    lblcontador.Text = Convert.ToString(Convert.ToInt32(contador) + 1); 
                }
                Conexion.Close();
                 
              
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvdetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == this.dgvdetalle.Columns["Eliminar"].Index)
            //{
            //   // DataGridViewCheckBoxCell chkcell =this.dgvdetalle.Rows[e.RowIndex].Cells["Eliminar"];
            //  //  chkcell.Value=chkcell.Value;
            //}
         
        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            try
            {
          
                Busqueda_Cliente busqueda = new Busqueda_Cliente();
                if (busqueda.ShowDialog() == DialogResult.OK)
                    //txtcliennte_id.Text = busqueda.ValorRetorno;    //MessageBox.Show(busqueda.ValorRetorno);
                txtcliennte_id.Text = busqueda.id;
                txtcotitular.Text = busqueda.Cotitular;
                txtemail.Text = busqueda.email;
                txtNombre.Text = busqueda.Nombre;
                txtdireccion.Text = busqueda.Direccion;
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique a su Administrador", "Error:", MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
            }     

        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        
        {
            try
            {

            
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {

                    DataSet ds = bdatos.SelectDataSet("Select cliente_nombre,cotitular,Cliente_Direccion,Cliente_Email from Cliente where Cliente_id= " + txtcliennte_id.Text + "", "Cliente");
                    txtNombre.Text = ds.Tables[0].Rows[0]["Cliente_nombre"].ToString();
                    txtcotitular.Text = ds.Tables[0].Rows[0]["cotitular"].ToString();
                    txtdireccion.Text = ds.Tables[0].Rows[0]["Cliente_Direccion"].ToString();
                    txtemail.Text = ds.Tables[0].Rows[0]["Cliente_Email"].ToString();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese valores correctos");
            }
           
        }
           
        private void cbxtipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            {
                int kil = Convert.ToInt32(cbxtipo.SelectedValue);
                
                SqlConnection Conexion = basedatos.conexionsql();
                string Cmarca = "Select subcategoria_id,Subcategoria_Nombre From Sub_categoria where Categoria_id= " + cbxtipo.SelectedValue + "";
                SqlDataAdapter da = new SqlDataAdapter(Cmarca, Conexion);                               
                DataTable dt1 = new DataTable();
                da.Fill(dt1);                
                cmbmarca.ValueMember = "subcategoria_id";
                cmbmarca.DisplayMember = "Subcategoria_nombre";
                cmbmarca.DataSource = dt1;

                if (kil > 1)
                {
                    lblkilataje.Enabled = false;
                    cmbkilataje.Text = "0";
                    cmbkilataje.Enabled = false;
                    lblpiedra.Enabled = false;
                    txtpiedra.Enabled = false;
                    txtpiedra.Text ="0";
                    txtpeso.Enabled = false;
                    txtpeso.Text = "0";
                    lblpeso.Enabled = false;
                    lblprestamo.Enabled = true;
                    txtprestamo.Enabled = true;
                    
                }
                else
                {
                    lblkilataje.Enabled = true;
                    cmbkilataje.Enabled = true;
                    lblpiedra.Enabled = true;
                    txtpiedra.Enabled = true;                    
                    txtpeso.Enabled = true;
                    lblpeso.Enabled = true;
                    lblprestamo.Enabled = false;
                    txtprestamo.Enabled = false;
                    txtprestamo.Text = "0";
                    
                    
                }

            }
        }
               
        private void btnagregar_Click(object sender, EventArgs e)
        {
            //Addlinea();
            int valorcombotipo=Convert.ToInt32(cbxtipo.SelectedValue);
            if (valorcombotipo == 1)
            {
                agregar_registro_oro();
                txtpeso.Text ="0";
                txtpiedra.Text = "0";
            
            }
            else
            {
                agregar_registro_Electronicos();
 
            }
        }
                      
        private void Sum()
        {
            txttotal_prestamo.Text = Convert.ToString(dgvdetalle.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDecimal(x.Cells["columnPrestamo"].Value)));
        }

        private void SumOpcion2()
        {
            decimal total_prestamo = 0;
            decimal total_avaluo = 0;
            if (dgvdetalle.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdetalle.Rows)
                {
                    total_prestamo += Convert.ToDecimal(row.Cells[10].Value);
                    total_avaluo += Convert.ToDecimal(row.Cells[11].Value);
                }
            }

            txttotal_prestamo.Text = Convert.ToString(total_prestamo);
            txttotal_avaluo.Text = Convert.ToString(total_avaluo);
        }

         /// <summary>
        /// Método utilizado para eliminar una fial del control DataGridView cuando no se encuentra enlazado
        /// a ninguna fuente de datos externa
        /// </summary>
        /// <param name="row">Representa la fila actual del control DataGridView(la fila seleccionada)</param>
        private void UsingAddDelete(DataGridViewRow row)
        {
            if (row != null)
                dgvdetalle.Rows.Remove(row);

            this.SumOpcion2();
        }

      
        private string _cellValue = String.Empty;
       
      
        //Agrega lineas del detalle
        private void agregar_registro_oro()
        {
            try
            {

                int valorcombooro = Convert.ToInt32(cbxtipo.SelectedValue);
                decimal peso = Convert.ToDecimal(txtpeso.Text);
                if (valorcombooro == 1 && peso < 1)
                    MessageBox.Show("El peso no puede ser menor a 1.", "Error:", MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                else
                {

                    try
                    {

                        if (txtcliennte_id.Text == "" || txtdescripcion.Text == "" || txtpeso.Text == "" || txtpiedra.Text == "")
                            MessageBox.Show("Faltan datos por llenar.", "Error:", MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        else
                        {
                            string dtme = Convert.ToString(DateTime.Now.ToShortDateString());
                            DateTime fecha = Convert.ToDateTime(dtme);

                            DateTime fecha_vencimiento = Convert.ToDateTime(dtme);
                            fecha_vencimiento = fecha_vencimiento.AddDays(28);

                            int Tipo_documento = 1;// "Empeño";
                            decimal Prestamo = 0;
                            decimal Avaluo = 0;

                            string vale = bdatos.selectstring("Select A.precio_compra " +
                                                       " from kilataje A, " +
                                                        "      Avaluo B " +
                                                " where A.Categoria_id=B.Categoria_id " +
                                                " And A.Categoria_id= " + cbxtipo.SelectedValue.ToString() + " " +
                                                " And A.kilataje_valor= " + cmbkilataje.Text);
                            
                            //Avaluo = (Convert.ToDecimal(txtpeso.Text) * Convert.ToDecimal(vale));
                            Prestamo = (Convert.ToDecimal(txtpeso.Text) * Convert.ToDecimal(vale));


                           // string porcentaje = bdatos.selectstring("Select Porcentaje_prestamo from presentaciones where idpresentacion=" + Convert.ToInt32(cmbpresentacion.SelectedValue.ToString()));
                            string porcentaje = bdatos.selectstring("Select Porcentaje_prestamo from presentaciones where idpresentacion=5");
                            //Prestamo = (Convert.ToDecimal(porcentaje) / 100) * Avaluo;
                            Avaluo = (Convert.ToDecimal(porcentaje) / 100) * Prestamo;
                            Avaluo = Prestamo + Avaluo;


                            string agregar_detalle = "insert into Boleta_detalle " +
                                                    " (	Boleta_Id,Cliente_Id,Cliente_Nombre,Tipo_documento,Categoria_Id,Categoria_Nombre, " +
                                                        " Kilateje,Subcategoria_Nombre,Estado,Descripcion,Peso,Peso_Piedra,Boleta_Fecha, " +
                                                    " Boleta_Fecha_Vencimiento,Plazo,Prestamo,Avaluo ) " +
                                                    " Values  " +
                                              " (" + lblcontador.Text + ","
                                                + txtcliennte_id.Text + ",'"
                                                + txtNombre.Text + "',"
                                                + Tipo_documento + ","
                                                + cbxtipo.SelectedValue.ToString() + ",'"
                                                + cbxtipo.Text + "',"   //   cbxtipo                                  
                                                + cmbkilataje.Text + ",'" //cmbkilataje
                                                + cmbmarca.Text + "','"//cmbmarca
                                                + cmbpresentacion.Text + "','"//Estado
                                                + txtdescripcion.Text + "',"
                                                + txtpeso.Text + ","
                                                + txtpiedra.Text + ",'"
                                                + fecha.ToString("yyyy-MM-dd hh:mm") + "','"
                                                + fecha_vencimiento.ToString("yyyy-MM-dd hh:mm") + "',"
                                                + cmbplazo.SelectedValue.ToString() + ","
                                                + Prestamo + ","
                                                + Avaluo + ")";


                            if (bdatos.executecommand(agregar_detalle))
                            {

                                dgvdetalle.DataSource = bdatos.SelectDataTable("select Detalle_id,Boleta_Id,Categoria_id,Categoria_Nombre, " +
                                                                                " Kilateje,Estado,Descripcion,Peso,Peso_Piedra, " +
                                                                                " Plazo,Prestamo,Avaluo " +
                                                                                 " From Boleta_detalle " +
                                                                                 " Where  boleta_id= " + lblcontador.Text);
                                this.SumOpcion2();
                                txtdescripcion.Text = "";
                                txtpeso.Text = "";
                                txtpiedra.Text = "";
                                txtprestamo.Text = "";


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
            }
            catch (Exception)
            {
                

                MessageBox.Show("Verifique que todos los campos esten llenos");
            }
        }

        private void agregar_registro_Electronicos()
        {
          
                try
                {

                    if (txtcliennte_id.Text == "" || txtdescripcion.Text == "" || txtprestamo.Text == "")
                        MessageBox.Show("Faltan datos por llenar.", "Error:", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    else
                    {
                        string dtme = Convert.ToString(DateTime.Now.ToShortDateString());
                        DateTime fecha = Convert.ToDateTime(dtme);

                        DateTime fecha_vencimiento = Convert.ToDateTime(dtme);
                        fecha_vencimiento = fecha_vencimiento.AddDays(28);

                        int Tipo_documento = 1;// "Empeño";
                        decimal Prestamo = 0;
                        decimal Avaluo = 0;

                        
                        string porcentaje = bdatos.selectstring("Select Porcentaje_prestamo from presentaciones where idpresentacion=5");
                        
                        
                        Prestamo = Convert.ToDecimal(txtprestamo.Text);

                        Avaluo = (Prestamo * Convert.ToDecimal(porcentaje))/100;
                        Avaluo = (Avaluo + Prestamo);
                           

                        string agregar_detalle = "insert into Boleta_detalle " +
                                                " (	Boleta_Id,Cliente_Id,Cliente_Nombre,Tipo_documento,Categoria_Id,Categoria_Nombre, " +
                                                    " Kilateje,Subcategoria_Nombre,Estado,Descripcion,Peso,Peso_Piedra,Boleta_Fecha, " +
                                                " Boleta_Fecha_Vencimiento,Plazo,Prestamo,Avaluo ) " +
                                                " Values  " +
                                          " (" + lblcontador.Text + ","
                                            + txtcliennte_id.Text + ",'"
                                            + txtNombre.Text + "',"
                                            + Tipo_documento + ","
                                            + cbxtipo.SelectedValue.ToString() + ",'"
                                            + cbxtipo.Text + "',"   //   cbxtipo                                  
                                            + cmbkilataje.Text + ",'" //cmbkilataje
                                            + cmbmarca.Text + "','"//cmbmarca
                                            + cmbpresentacion.Text + "','"//Estado
                                            + txtdescripcion.Text + "',"
                                            + txtpeso.Text + ","
                                            + txtpiedra.Text + ",'"
                                            + fecha.ToString("yyyy-MM-dd hh:mm") + "','"
                                            + fecha_vencimiento.ToString("yyyy-MM-dd hh:mm") + "',"
                                            + cmbplazo.SelectedValue.ToString() + ","
                                            + Prestamo + ","
                                            + Avaluo + ")";


                        if (bdatos.executecommand(agregar_detalle))
                        {

                            dgvdetalle.DataSource = bdatos.SelectDataTable("select Detalle_id,Boleta_Id,Categoria_id,Categoria_Nombre, " +
                                                                            " Kilateje,Estado,Descripcion,Peso,Peso_Piedra, " +
                                                                            " Plazo,Prestamo,Avaluo " +
                                                                             " From Boleta_detalle " +
                                                                             " Where  boleta_id= " + lblcontador.Text);
                            this.SumOpcion2();
                            txtdescripcion.Text = "";
                            txtpeso.Text = "";
                            txtpiedra.Text = "";
                            txtprestamo.Text = "";


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

        private void guardaencabezado()
        {
            
                try
                {
                    string dtme = Convert.ToString(DateTime.Now.ToShortDateString());
                    DateTime fecha = Convert.ToDateTime(dtme);

                    DateTime fecha_vencimiento = Convert.ToDateTime(dtme);
                    fecha_vencimiento = fecha_vencimiento.AddDays(28);

                    DateTime Fecha_Comercializacion = fecha_vencimiento.AddDays(3);
                    

                    lbluser.Text =Program.Usuario;
                    int Tipo_documento = 1;// "Empeño";

                    string agregar_encabezado = "Insert into Boleta_encabezado (Cliente_Id,Nombre_valuador,Boleta_Fecha,Boleta_Fecha_Vencimiento,Tipo_documento,Categoria_Id,Prestamo,Avaluo,Estado,Usuario_Id,Boleta_Fecha_Comercializacion) " +
                                      " Values  ("  + txtcliennte_id.Text + ",'" 
                                                    + lbluser.Text  + "','" 
                                                    + fecha.ToString("yyyy-MM-dd hh:mm") + "','" 
                                                    + fecha_vencimiento.ToString("yyyy-MM-dd hh:mm") + "'," 
                                                    + Tipo_documento + "," 
                                                    + cbxtipo.SelectedValue.ToString() + "," 
                                                    + txttotal_prestamo.Text + "," 
                                                    + txttotal_avaluo.Text + ",'Vigente',"
                                                    + Program.UsuarioId + ",'"
                                                    + Fecha_Comercializacion.ToString("yyyy-MM-dd hh:mm") + "' )";
                    if (bdatos.executecommand(agregar_encabezado))
                    {
                        MessageBox.Show("Registro agregado correctamente");


                        
                        dgvdetalle.DataSource = null;
                        dgvdetalle.Refresh();

                    }
                    else
                    {
                        MessageBox.Show("Error al agregar");
                    }



                }//try
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }//catch
            
        }
        
        //Genera boleta
        private void btnguadar_Click(object sender, EventArgs e)
        {
           
                try
                {
                    string dtme = Convert.ToString(DateTime.Now.ToShortDateString());
                    DateTime fecha = Convert.ToDateTime(dtme);

                    DateTime fecha_vencimiento = Convert.ToDateTime(dtme);
                    fecha_vencimiento = fecha_vencimiento.AddDays(28);

                    DateTime Fecha_Comercializacion = fecha_vencimiento.AddDays(3);

                    int Tipo_documento = 1;// "Empeño";

                    string agregar_encabezado = "Insert into Boleta_encabezado (Cliente_Id,Nombre_valuador,Boleta_Fecha,Boleta_Fecha_Vencimiento,Tipo_documento,Categoria_Id,Prestamo,Avaluo,Boleta_Fecha_Comercializacion) " +
                                      " Values  ("  + txtcliennte_id.Text + ",'" 
                                                    + lbluser.Text + "','" 
                                                    + fecha.ToString("yyyy-MM-dd hh:mm") + "','" 
                                                    + fecha_vencimiento.ToString("yyyy-MM-dd hh:mm") + "'," 
                                                    + Tipo_documento + "," 
                                                    + cbxtipo.SelectedValue.ToString() + "," 
                                                    + txttotal_prestamo.Text + "," 
                                                    + txttotal_avaluo.Text + ",'"
                                                    + Fecha_Comercializacion.ToString("yyyy-MM-dd hh:mm") + "' )";
                    if (bdatos.executecommand(agregar_encabezado))
                    {
                        MessageBox.Show("Registro agregado correctamente");


                        limapiar();
                        dgvdetalle.DataSource = null;
                        dgvdetalle.Refresh();

                    }
                    else
                    {
                        MessageBox.Show("Error al agregar");
                    }



                }//try
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }//catch
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string Borra_Detalle = "Delete A from boleta_detalle A where not exists(	select boleta_id from Boleta_Encabezado  B 	Where A.boleta_id=B.boleta_id)";
                                    
            if (bdatos.executecommand(Borra_Detalle))
            {
               
                limapiar();
                dgvdetalle.DataSource = null;
                dgvdetalle.Refresh();

            }            
            this.Close();
        }
       
        private void dgvdetalle_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                DataGridViewRow id_detalle = dgvdetalle.Rows[e.RowIndex];
                lblaeliminar.Text = id_detalle.Cells[0].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("No existe registros que cargar ");
            }
          
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string eliminaregistro = ("Delete From boleta_detalle where Detalle_id= " + lblaeliminar.Text);
            bdatos.executecommand(eliminaregistro);


            dgvdetalle.DataSource = bdatos.SelectDataTable("select Detalle_id,Boleta_Id,Categoria_id,Categoria_Nombre, " +
                                                                       " Kilateje,Estado,Descripcion,Peso,Peso_Piedra, " +
                                                                       " Plazo,Prestamo,Avaluo " +
                                                                        " From Boleta_detalle " +
                                                                        " Where  boleta_id= " + lblcontador.Text);
            lblaeliminar.Text = "";
            this.SumOpcion2();
            //txttotal_avaluo.Text = "";
            //txttotal_prestamo.Text = "";
            
                        
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                string registros = dgvdetalle.RowCount.ToString();
                int valor = Convert.ToInt32(registros);
                if (valor > 0)
                {
                    this.guardaencabezado();
                    idboleta = lblcontador.Text;
                    Empeniorpt empe = new Empeniorpt();
                    empe.boleta_id = Convert.ToInt32(idboleta);
                    empe.cliente_id = Convert.ToInt32(txtcliennte_id.Text);
                    empe.ShowDialog(this);
                    empe.Dispose();
                    empe = null;

                    Gurda_PDF datos = new Gurda_PDF();
                    datos.Boleta = lblcontador.Text;
                    datos.Cliente = txtNombre.Text;
                    datos.Nombre = lblnombre.Text;
                    datos.Movimiento = "Empenio";
                    datos.ShowDialog(this);
                    datos.Dispose();

                    limapiar();
                    

                    this.recargaboleta();
                    txttotal_avaluo.Text = "";
                    txttotal_prestamo.Text = "";
                    txtcliennte_id.Text = "";
                }
                else
                {
                    MessageBox.Show("No hay registros que procesar");
                }

                
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique que todos los campos esten llenados correctamente");
            }

        }

        private void Empeño_FormClosed(object sender, FormClosedEventArgs e)
        {
            string Borra_Detalle = "Delete A from boleta_detalle A where not exists(	select boleta_id from Boleta_Encabezado  B 	Where A.boleta_id=B.boleta_id)";

            if (bdatos.executecommand(Borra_Detalle))
            {

                limapiar();
                dgvdetalle.DataSource = null;
                dgvdetalle.Refresh();

            }
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

    }
}

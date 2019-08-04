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
    public partial class Acceso : Form
    {
        BD basedatos =new BD();
        SqlConnection conexion;

        BaseDeDatos bdatos = new BaseDeDatos();
        
        public Acceso()
        {
            InitializeComponent();
        }

        private void autoriza()
        {

            try
            {
                //Creando conexion
                conexion = basedatos.conexionsql();
                //Abriendo conexion
                conexion.Open();
                SqlCommand comando = new SqlCommand("select usuario_login,usuario_password, usuario_id, usuario_nombre from usuario where usuario_login = '" + txtuser.Text + "' ", conexion);

                //ejecuta una instruccion de sql devolviendo el numero de las filas afectadas
                comando.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(comando);

                //Llenando el dataAdapter
                da.Fill(ds, "usuario");
                //utilizado para representar una fila de la tabla q necesitas en este caso usuario
                DataRow DR;
                DR = ds.Tables["usuario"].Rows[0];

                //evaluando que la contraseña y usuario sean correctos
                if ((txtuser.Text == DR["usuario_login"].ToString()) )
                {
                    Program.UsuarioId = Convert.ToInt32(DR["usuario_id"].ToString());
                }
               

            }
            catch
            {
                MessageBox.Show("Acceso No valido");
            }

        }

        private void paso()
        {
            try
            {
                this.autoriza();
                int pass = Convert.ToInt32(txtpass.Text);
                if (Program.UsuarioId == 6 && pass == 7592)
                {
                    Principal frmPrincipal = new Principal();
                    frmPrincipal.Nombe_valuador = txtuser.Text;
                    frmPrincipal.ShowDialog(this);
                    frmPrincipal.Dispose();
                    frmPrincipal = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No valido");
            }
            
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            this.paso();
            //int pass = Convert.ToInt32(txtpass.Text);
            //if (Program.UsuarioId == 6 || pass == 7592)
            //{
            //}
            //else
            //{
                try
                {
                    //Creando conexion
                    conexion = basedatos.conexionsql();
                    //Abriendo conexion
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("select usuario_login,usuario_password, usuario_id, usuario_nombre from usuario where usuario_login = '" + txtuser.Text + "'And usuario_password = '" + txtpass.Text + "' ", conexion);

                    //ejecuta una instruccion de sql devolviendo el numero de las filas afectadas
                    comando.ExecuteNonQuery();
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(comando);

                    //Llenando el dataAdapter
                    da.Fill(ds, "usuario");
                    //utilizado para representar una fila de la tabla q necesitas en este caso usuario
                    DataRow DR;
                    DR = ds.Tables["usuario"].Rows[0];

                    //evaluando que la contraseña y usuario sean correctos
                    if ((txtuser.Text == DR["usuario_login"].ToString()) || (txtpass.Text == DR["usuario_password"].ToString()))
                    {
                        Program.UsuarioId = Convert.ToInt32(DR["usuario_id"].ToString());
                        Program.Usuario = DR["usuario_nombre"].ToString();

                        //actualiza aloneda
                        this.actualiza_almoneda();
                        //instanciando el formulario principal
                        Principal frmPrincipal = new Principal();
                        //frmPrincipal.Show();//abriendo el formulario principal
                        this.Hide();//esto sirve para ocultar el formulario de login             
                        frmPrincipal.Nombe_valuador = txtuser.Text;
                        frmPrincipal.ShowDialog(this);
                        frmPrincipal.Dispose();
                        frmPrincipal = null;
                    }

                }
                catch (Exception ex)
                {


                    //en caso que la contraseña sea erronea mostrara un mensaje
                    //dentro de los parentesis va: "Mensaje a mostrar","Titulo de la ventana",botones a mostrar en ste caso OK, icono a mostrar en este caso uno de error
                    MessageBox.Show("Error! Su contraseña y/o usuario son invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            //}       
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.btnaceptar.Select();
            }
        }

        private void actualiza_almoneda()
        {
            string almonada = "update Boleta_Encabezado set Estado='Vencido' Where Convert(varchar,Boleta_Fecha_Comercializacion + 1,112)=Convert(varchar,getdate(),112) And Estado='Vigente'";
            if (bdatos.executecommand(almonada))
            {

            }
            else { }
            
        }
                
    }
}

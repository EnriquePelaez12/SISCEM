using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SISCEM
{
    public partial class Principal : Form
    {
        public string Nombe_valuador = "";
        public Principal()
        {
            InitializeComponent();

            if (Program.UsuarioId==6)
            {
                
                altasToolStripMenuItem.Visible = false;
                empeñoToolStripMenuItem.Visible = false;
                actualizaTablasToolStripMenuItem.Visible = false;
                agregarCajasToolStripMenuItem.Visible = false;
                refrendosDetalladosToolStripMenuItem.Visible = true;
                desempeñoToolStripMenuItem.Visible = false;
                desempeñoToolStripMenuItem1.Visible = false;                
                desgloseBoletaToolStripMenuItem.Visible = false;
                consultaCodigosToolStripMenuItem.Visible = false;
                parametrosToolStripMenuItem.Visible=false;
                empresaToolStripMenuItem.Visible = false;
                sucursalToolStripMenuItem.Visible = false;
                //empleadosToolStripMenuItem.Visible = false;
                categoriasToolStripMenuItem.Visible = false;
                usuariosToolStripMenuItem.Visible = false;
                                
            }
        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
              Alta_Clientes.DefInstance.MdiParent = this;
              Alta_Clientes.DefInstance.Show();
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                Alta_Empleado.DefInstance.MdiParent = this;
                Alta_Empleado.DefInstance.Show();
           
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

             Categorias.DefInstance.MdiParent = this;
             Categorias.DefInstance.Show();
           
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
              Empresa.DefInstance.MdiParent = this;
              Empresa.DefInstance.Show();
                    
        }

      
        private void arqueoCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arqueo_Caja.DefInstance.MdiParent = this;
            Arqueo_Caja.DefInstance.Show();
            
        }
              

        private void desempeñoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Desempeño frmdesempenio = new Desempeño();
            frmdesempenio.valuador_empenio = lblusuario.Text;
            frmdesempenio.ShowDialog(this);

            
        }

        private void sucursalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           Sucursal.DefInstance.MdiParent = this;
           Sucursal.DefInstance.Show();
           
        }

        private void actualizaTablasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualiza_Kilates.DefInstance.MdiParent = this;
            Actualiza_Kilates.DefInstance.Show();
           
        }

        private void agregarCajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                Agregar_Cajas.DefInstance.MdiParent = this;
                Agregar_Cajas.DefInstance.Show();
            
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblusuario.Text = Nombe_valuador;

        }
        
        private void desgloseBoletaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           DesgloseBoleta.DefInstance.MdiParent = this;
           DesgloseBoleta.DefInstance.Show();
           
        }

        private void ventaDePrendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Venta_Prendas.DefInstance.MdiParent = this;
           Venta_Prendas.DefInstance.Show();
           
        }

        private void empeñoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
                Empeño.DefInstance.MdiParent = this;
                Empeño frmempeño = new Empeño();
                frmempeño.valuador_empenio = lblusuario.Text;
                frmempeño.ShowDialog(this);
            
        }

       
        private void Mov_CajeroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Program.UsuarioId == 6)
            {
                altasToolStripMenuItem.Visible = false;

            }
            else
            {
                Movimientos.DefInstance.MdiParent = this;
                Movimientos.DefInstance.Show();
            }

        }

        private void Mov_ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportesClientes.DefInstance.MdiParent = this;
            ReportesClientes.DefInstance.Show();

        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingresos.DefInstance.MdiParent = this;
            Ingresos.DefInstance.Show();
        }

        private void egresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Egresos.DefInstance.MdiParent = this;
            Egresos.DefInstance.Show();
        }

        private void movIngresosEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mov_Ingresos_Egresos.DefInstance.MdiParent = this;
            Mov_Ingresos_Egresos.DefInstance.Show();
        }

        private void parametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parametros.DefInstance.MdiParent = this;
            Parametros.DefInstance.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios.DefInstance.MdiParent = this;
            Usuarios.DefInstance.Show();
        }

        private void exteporaneoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Refrendo_Extemporaneo.DefInstance.MdiParent = this;
          Refrendo_Extemporaneo.DefInstance.Show();
          
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Refrendo.DefInstance.MdiParent = this;
           Refrendo.DefInstance.Show();
           
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        //Primero se debe incluir el namespace System.Diagnostics 
        //Hacemos uso de la clase Process 
        //Inicia un proceso 
        Process pr = new Process(); 
        string Directorio = @"C:"; 
        //Configuramos las opociones iniciales del proceso 
        pr.StartInfo.WindowStyle = ProcessWindowStyle.Maximized; 
        // Inicamos el proceso 
        //pr.Start(); 
        //Pero esto es típico y bueno cabe notar que tambien es posible con el mismo código llamar a archivos que tengan asociados programas como bien puede hacer abrir un archivo de excel o Txt desde una aplicacion Windows, agregando esto, asi: 
        // Especifique el directorio 
        pr.StartInfo.WorkingDirectory = Directorio; 
        // Aqui se introduce el nombre del archivo 
        pr.StartInfo.FileName = "Manual Usuario Pressto.docx"; 
        // Asegurese de tener creado este archivo 
        pr.Start(); 

        pr.StartInfo.FileName = "Manual Usuario Pressto.docx"; 
        // Asegurese de tener creado este archivo 
        pr.Start(); 
        }

        private void consultaCodigosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_Codigo_Venta.DefInstance.MdiParent = this;
            Consulta_Codigo_Venta.DefInstance.Show();            
         
        }

        private void corteZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.UsuarioId == 6)
            {
                Cortez.DefInstance.MdiParent = this;
                Cortez.DefInstance.Show();
            }
            else
            { corteZToolStripMenuItem.Visible = false; }
            
        }

        private void desempenioDetalladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.UsuarioId == 6)
            {
                

                Desempenio_Detallado.DefInstance.MdiParent = this;
                Desempenio_Detallado.DefInstance.Show();
            }
            else
            {
                desempenioDetalladoToolStripMenuItem.Visible = false;
                
            }
             
        }

        private void empeñoDetalladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.UsuarioId == 6)
            {

                Empenio_detallado.DefInstance.MdiParent = this;
                Empenio_detallado.DefInstance.Show();
            }
            else
            {
                empeñoDetalladoToolStripMenuItem.Visible = false;
            }
            
        }

        private void ventasDetalladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.UsuarioId == 6)
            {

                Ventas_detallado.DefInstance.MdiParent = this;
                Ventas_detallado.DefInstance.Show();
            }
            else { ventasDetalladoToolStripMenuItem.Visible = false; }
            
        }

        private void refrendosDetalladosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Refrendo_Detallado.DefInstance.MdiParent = this;
            Refrendo_Detallado.DefInstance.Show();
            //if (Program.UsuarioId == 6)
            //{

            //    Refrendo_Detallado.DefInstance.MdiParent = this;
            //    Refrendo_Detallado.DefInstance.Show();
            //}
            //else
            //{ refrendosDetalladosToolStripMenuItem.Visible = false; }
            
        }

        private void ingresosDetalladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.UsuarioId == 6)
            {


                Ingresos_Detallados.DefInstance.MdiParent = this;
                Ingresos_Detallados.DefInstance.Show();
            }
            else
            { ingresosDetalladosToolStripMenuItem.Visible = false; }
            
        }

        private void egresosDetalladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.UsuarioId == 6)
            {


                Egresos_Detallado.DefInstance.MdiParent = this;
                Egresos_Detallado.DefInstance.Show();
            }
            else
            { egresosDetalladosToolStripMenuItem.Visible = false; }
            
        }

        private void actualizaBoletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualiza_Boleta.DefInstance.MdiParent = this;
            Actualiza_Boleta.DefInstance.Show();
        }

        private void refrendoIlimitadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refrendo_Ilimitado.DefInstance.MdiParent = this;
            Refrendo_Ilimitado.DefInstance.Show();

        }

        private void empeñoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           ConsultaEmpenio.DefInstance.MdiParent = this;
           ConsultaEmpenio.DefInstance.Show();
        }

        private void refrendoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaRefrendo.DefInstance.MdiParent = this;
            ConsultaRefrendo.DefInstance.Show();
            
        }

        private void desempeñoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaDesempenio.DefInstance.MdiParent = this;
            ConsultaDesempenio.DefInstance.Show();
        }

        private void ventaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta_Codigo_Venta.DefInstance.MdiParent = this;
            Consulta_Codigo_Venta.DefInstance.Show();
         
        }

        private void consultaPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_Venta.DefInstance.MdiParent = this;
            Consulta_Venta.DefInstance.Show();
        }

        private void cancelarEmpeñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cancela_boleta.DefInstance.MdiParent = this;
            Cancela_boleta.DefInstance.Show();
        }

      

        //private void reimprimeContratoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Reimprime_Contrato.DefInstance.MdiParent = this;
        //    Reimprime_Contrato.DefInstance.Show();
        //}

                                 
    }
}

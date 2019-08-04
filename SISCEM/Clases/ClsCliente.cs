using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClsAccesoDatos;
using System.Data;
using System.Data.SqlClient;

namespace SISCEM
{
    
    public class ClsCliente
    {
        ClsConeccion cnn = new ClsConeccion();

        Int32 cliente_id;

        public Int32 Cliente_id
        {
            get { return cliente_id; }
            set { cliente_id = value; }
        }

        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellido_Paterno;

        public string Apellido_Paterno
        {
            get { return apellido_Paterno; }
            set { apellido_Paterno = value; }
        }
        private string apellido_Materno;

        public string Apellido_Materno
        {
            get { return apellido_Materno; }
            set { apellido_Materno = value; }
        }


        Int16 ocupacion_id;

        public Int16 Ocupacion_id
        {
            get { return ocupacion_id; }
            set { ocupacion_id = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private DateTime fecha_Actualizacion;

        public DateTime Fecha_Actualizacion
        {
            get { return fecha_Actualizacion; }
            set { fecha_Actualizacion = value; }
        }
        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private Int16 sexo_Id;

        public Int16 Sexo_Id
        {
            get { return sexo_Id; }
            set { sexo_Id = value; }
        }
        private Int16 civil_Id;

        public Int16 Civil_Id
        {
            get { return civil_Id; }
            set { civil_Id = value; }
        }
        private Int16 colonia_Id;

        public Int16 Colonia_Id
        {
            get { return colonia_Id; }
            set { colonia_Id = value; }
        }
        private Int16 estado_Id;

        public Int16 Estado_Id
        {
            get { return estado_Id; }
            set { estado_Id = value; }
        }
        private Int16 municipio_Id;

        public Int16 Municipio_Id
        {
            get { return municipio_Id; }
            set { municipio_Id = value; }
        }

        string cotitular;

        public string Cotitular
        {
            get { return cotitular; }
            set { cotitular = value; }
        }

        string celular;

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        string cp;

        public string Cp
        {
            get { return cp; }
            set { cp = value; }
        }
        

        public String MantenimientoClientes()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@Cliente_Id", Cliente_id));
                lst.Add(new ClsParametros("@Nombre", Nombre));
                lst.Add(new ClsParametros("@Apellido_Paterno", Apellido_Paterno));
                lst.Add(new ClsParametros("@Apellido_Materno", Apellido_Materno));
                lst.Add(new ClsParametros("@Ocupacion_Id", Ocupacion_id));
                lst.Add(new ClsParametros("@Direccion", Direccion));
                lst.Add(new ClsParametros("@Telefono", Telefono));
                lst.Add(new ClsParametros("@Sexo_Id", Sexo_Id));
                lst.Add(new ClsParametros("@EstadoCivil", Civil_Id));
                lst.Add(new ClsParametros("@Colonia_Id", Colonia_Id));
                lst.Add(new ClsParametros("@Estado_Id", Estado_Id));
                lst.Add(new ClsParametros("@Municipio_Id", Municipio_Id));
                lst.Add(new ClsParametros("@Cliente_Celular", Celular));
                lst.Add(new ClsParametros("@Cliente_Email", Email));
                lst.Add(new ClsParametros("@Cliente_CP", Cp));
                lst.Add(new ClsParametros("@Cotitular", Cotitular));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                cnn.EjecutarSP("MantenimientoClientes", ref lst);
                return Mensaje = lst[1].Valor.ToString();

          

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListadoEmpleados()
        {
            return cnn.Listado("ListadoClientes", null);
        }

        public String GenerarIdEmpleado()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            int objIdCliente;
            try
            {
                lst.Add(new ClsParametros("@IdCliente", "", SqlDbType.Int, ParameterDirection.Output, 4));
                cnn.EjecutarSP("GenerarIdCliente", ref lst);
                objIdCliente = Convert.ToInt32(lst[0].Valor.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Convert.ToString(objIdCliente);
        }

        public DataTable BuscarEmpleado(String objDatos)
        {
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            lst.Add(new ClsParametros("@Datos", objDatos));
            return dt = cnn.Listado("Buscar_Cliente", lst);
        }
        public DataTable ObtenDatos()
        {
            return cnn.Regresa_Datos("Listado_Cliente_X_Busqueda");
        }


    }
}

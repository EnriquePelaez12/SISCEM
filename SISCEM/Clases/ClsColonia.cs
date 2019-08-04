using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ClsAccesoDatos;

namespace SISCEM
{
    public class ClsColonia
    {


        ClsConeccion cnn = new ClsConeccion();

        private int Estado_Id;

        public int Estado_Id1
        {
            get { return Estado_Id; }
            set { Estado_Id = value; }
        }
        private int Municipio_Id;

        public int Municipio_Id1
        {
            get { return Municipio_Id; }
            set { Municipio_Id = value; }
        }
        private int Colonia_Id;

        public int Colonia_Id1
        {
            get { return Colonia_Id; }
            set { Colonia_Id = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private DateTime fec_Actualizacion;

        public DateTime Fec_Actualizacion
        {
            get { return fec_Actualizacion; }
            set { fec_Actualizacion = value; }
        }

        //public int Estado_Id1 { get => Estado_Id; set => Estado_Id = value; }
        //public int Municipio_Id1 { get => Municipio_Id; set => Municipio_Id = value; }
        //public int Colonia_Id1 { get => Colonia_Id; set => Colonia_Id = value; }
        //public string Nombre { get => nombre; set => nombre = value; }
        //public DateTime Fec_Actualizacion { get => fec_Actualizacion; set => fec_Actualizacion = value; }

        public DataTable ListarColonia()
        {
            return cnn.Listado("ListarColonia", null);
        }

        public String RegistrarColonia()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@Nombre", Nombre));
                lst.Add(new ClsParametros("@Estado_Id", Estado_Id1));
                lst.Add(new ClsParametros("@Municipio_Id1", Municipio_Id1));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                cnn.EjecutarSP("RegistrarColonia", ref lst);
                Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public DataTable BuscarColonia(String Nombre)
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            DataTable dt = new DataTable();
            try
            {
                lst.Add(new ClsParametros("@Nombre", Nombre));
                //lst.Add(new ClsParametros("@Estado_Id", Estado_Id));
                return dt = cnn.Listado("BuscarColonia", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable BuscarColonia_x_Municipio(int Municipio_Id, int Estado_Id)
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            DataTable dt = new DataTable();
            try
            {
               lst.Add(new ClsParametros("@Municipio_Id", Municipio_Id));
               lst.Add(new ClsParametros("@Estado_Id", Estado_Id));
                return dt = cnn.Listado("BuscarColonia_Municipio", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public String ActualizarColonia()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@Estado_Id", Estado_Id1));
                lst.Add(new ClsParametros("@Municipio_Id", Municipio_Id1));
                lst.Add(new ClsParametros("@Colonia_Id", Colonia_Id1));
                lst.Add(new ClsParametros("@Nombre", Nombre));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                cnn.EjecutarSP("ActualizarColonia", ref lst);
                Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace SISCEM
{
   public class ClsMunicipio
    {

        private ClsConeccion cnn = new ClsConeccion();

        private Int32 Estado_Id;

        public Int32 Estado_Id1
        {
            get { return Estado_Id; }
            set { Estado_Id = value; }
        }
        private Int32 Municipio_Id;

        public Int32 Municipio_Id1
        {
            get { return Municipio_Id; }
            set { Municipio_Id = value; }
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
        //public string Nombre { get => nombre; set => nombre = value; }
        //public DateTime Fec_Actualizacion { get => fec_Actualizacion; set => fec_Actualizacion = value; }

        public DataTable ListarMunicipio()
        {
            return cnn.Listado("ListarMunicipio", null);
        }

        public String RegistrarMunicipio()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@Nombre", Nombre));
                lst.Add(new ClsParametros("@Estado_Id", Estado_Id1));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                cnn.EjecutarSP("RegistrarMunicipio", ref lst);
                Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public DataTable BuscarMunicipio(String Nombre)
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            DataTable dt = new DataTable();
            try
            {
                lst.Add(new ClsParametros("@Nombre", Nombre));
                //lst.Add(new ClsParametros("@Estado_Id", Estado_Id));
                return dt = cnn.Listado("BuscarMunicipio", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable BuscarMunicipio_x_Estado(Int32 Estado_Id)
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            DataTable dt = new DataTable();
            try
            {
                lst.Add(new ClsParametros("@Estado_Id", Estado_Id));
                return dt = cnn.Listado("BuscarMunicipio_x_Estado", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public String ActualizarMunicipio()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@Estado_Id", Estado_Id1));
                lst.Add(new ClsParametros("@Municipio_Id", Municipio_Id1));
                lst.Add(new ClsParametros("@Nombre", Nombre));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                cnn.EjecutarSP("ActualizarMunicipio", ref lst);
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

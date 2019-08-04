using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace SISCEM
{
    
    public class ClsEstadoCivil
    {
        ClsConeccion cnn = new ClsConeccion();

        Int32 Estdo_Civil_Id;

        public Int32 Estdo_Civil_Id1
        {
            get { return Estdo_Civil_Id; }
            set { Estdo_Civil_Id = value; }
        }
        String Descripcion;

        public String Descripcion1
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }

        //public int Estdo_Civil_Id1 { get => Estdo_Civil_Id; set => Estdo_Civil_Id = value; }
        //public string Descripcion1 { get => Descripcion; set => Descripcion = value; }

        public DataTable ListarEstadoCivil()
        {
            return cnn.Listado("ListarEstadoCivil", null);
        }

        public String RegistrarEstadoCivil()
        {
            String Mensaje = "";
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Descripcion", Descripcion1));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                cnn.EjecutarSP("RegistrarEstadoCivil", ref lst);
                Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String ActualizarEstadoCivil()
        {
            String Mensaje = "";
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Estdo_Civil_Id", Estdo_Civil_Id1));
                lst.Add(new ClsParametros("@Descripcion", Descripcion1));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                cnn.EjecutarSP("ActualizarEstadoCivil", ref lst);
                Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public DataTable BuscarEstadoCivil(String Descripcion)
        {
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Descripcion", Descripcion));
                return dt = cnn.Listado("BuscarEstadoCivil", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SISCEM
{
    public class ClsEstado
    {
        private ClsConeccion cnn = new ClsConeccion();

        private int Estado_Id;

        public int Estado_Id1
        {
            get { return Estado_Id; }
            set { Estado_Id = value; }
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
        //public string Nombre { get => nombre; set => nombre = value; }
        //public DateTime Fec_Actualizacion { get => fec_Actualizacion; set => fec_Actualizacion = value; }

        public DataTable ListarEstado()
        {
            return cnn.Listado("ListarEstado", null);
        }

        public String RegistrarEstado()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@Nombre", Nombre));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                cnn.EjecutarSP("RegistrarEstado", ref lst);
                Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public DataTable BuscarCategoria(String Nombre)
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            DataTable dt = new DataTable();
            try
            {
                lst.Add(new ClsParametros("@Nombre", Nombre));
                return dt = cnn.Listado("BuscarEstado", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public String ActualizarEstado()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@Estado_Id", Estado_Id1));
                lst.Add(new ClsParametros("@Nombre", Nombre));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                cnn.EjecutarSP("ActualizarEstado", ref lst);
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

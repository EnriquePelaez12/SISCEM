using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace SISCEM
{
    public class ClsCategoria
    {
        private ClsConeccion cnn = new ClsConeccion();


        private Int32 categoria_Id;

        public Int32 Categoria_Id
        {
            get { return categoria_Id; }
            set { categoria_Id = value; }
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

        //public int Categoria_Id { get => categoria_Id; set => categoria_Id = value; }
        //public string Nombre { get => nombre; set => nombre = value; }
        //public DateTime Fec_Actualizacion { get => fec_Actualizacion; set => fec_Actualizacion = value; }

        public DataTable ListarCategoria()
        {
            return cnn.Listado("ListarCategoria", null);
        }

        public String RegistrarCategoria()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@Nombre", Nombre));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                cnn.EjecutarSP("RegistrarCategoria", ref lst);
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
                return dt = cnn.Listado("BuscarCategoria", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public String ActualizarCategoria()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new ClsParametros("@Categoria_Id", Categoria_Id));
                lst.Add(new ClsParametros("@Nombre", Nombre));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                cnn.EjecutarSP("ActualizarCategoria", ref lst);
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

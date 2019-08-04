using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace SISCEM
{

    public class ClsSexo
    {
        ClsConeccion cnn = new ClsConeccion();

        Int32 Sexo_Id;

        public Int32 Sexo_Id1
        {
            get { return Sexo_Id; }
            set { Sexo_Id = value; }
        }
        String Nombre;

        public String Nombre1
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        //public int Sexo_Id1 { get => Sexo_Id; set => Sexo_Id = value; }
        //public string Nombre1 { get => Nombre; set => Nombre = value; }

        public DataTable ListarSexo()
        {
            return cnn.Listado("ListarSexo", null);
        }

        public String RegistrarCargo()
        {
            String Mensaje = "";
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Nombre", Nombre1));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                cnn.EjecutarSP("RegistrarCargo", ref lst);
                Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String ActualizarSexo()
        {
            String Mensaje = "";
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Sexo_Id", Sexo_Id1));
                lst.Add(new ClsParametros("@Nombre", Nombre1));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                cnn.EjecutarSP("ActualizarSexo", ref lst);
                Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public DataTable BuscarSexo(String Nombre)
        {
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Nombre", Nombre));
                return dt = cnn.Listado("BuscarSexo", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

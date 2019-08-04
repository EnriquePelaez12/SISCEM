using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace SISCEM
{
    public class clsCargo
    {
        ClsConeccion cnn = new ClsConeccion();

        Int32 Cargo_Id;

        public Int32 Cargo_Id1
        {
            get { return Cargo_Id; }
            set { Cargo_Id = value; }
        }
        String Descripcion;

        public String Descripcion1
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }

        //public int Cargo_Id1 { get => Cargo_Id; set => Cargo_Id = value; }
        //public string Descripcion1 { get => Descripcion; set => Descripcion = value; }

        public DataTable ListarCargo()
        {
            return cnn.Listado("ListarCargo", null);
        }

        public String RegistrarCargo()
        {
            String Mensaje = "";
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Descripcion", Descripcion1));
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

        public String ActualizarCargo()
        {
            String Mensaje = "";
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Cargo_Id", Cargo_Id1));
                lst.Add(new ClsParametros("@Descripcion", Descripcion1));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                cnn.EjecutarSP("ActualizarCargo", ref lst);
                Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public DataTable BusquedaCargo(String Descripcion)
        {
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Descripcion", Descripcion));
                return dt = cnn.Listado("BuscarCargo", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

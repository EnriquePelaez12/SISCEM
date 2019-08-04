using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClsAccesoDatos;
using System.Data;

namespace SISCEM
{
   public class ClsOcupacion
    {
        ClsConeccion cnn = new ClsConeccion();

        Int32 ocupacion_Id;

        public Int32 Ocupacion_Id
        {
            get { return ocupacion_Id; }
            set { ocupacion_Id = value; }
        }
        String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


        public DataTable ListarOcupacion()
        {
            return cnn.Listado("ListarOcupacion", null);
        }

        
    }
}

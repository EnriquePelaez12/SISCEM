using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
    public class Configuracion
    {
        static string cadenaConexion = @"Server=JHUERTA\SQL2016); initial Catalog=PRESTO; Integrated Security=True";//@"Data Source=???;Initial Catalog=dbPDF;User ID=sa;Password=???";
        public static string CadenaConexion
        {
            get { return cadenaConexion; }
        }
    }
}

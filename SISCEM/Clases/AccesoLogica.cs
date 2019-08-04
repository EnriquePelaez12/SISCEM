using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;
using System.IO;

namespace Negocio
{
    public class AccesoLogica
    {
        public static Boolean insertarPDF(string pdfnombre, string pdfruta)
        {
            FileStream fs = new FileStream(pdfruta, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            Byte[] bytes = br.ReadBytes((Int32)fs.Length);
            br.Close();
            fs.Close();
            return AccesoDatos.insertPDF(pdfnombre, bytes);
        }

        public static DataTable descargarPDF(int id)
        {
            return AccesoDatos.selectPDF(id);
        }
    }
}

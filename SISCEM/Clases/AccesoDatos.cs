using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class AccesoDatos
    {
        public static Boolean insertPDF(string nombrePDF, Byte[] PDFbytes)
        {
            SqlCommand _comando = MetodosDatos.crearComando();
            _comando.CommandText = "INSERT INTO tablaPDF (Nombre, Tipo, Datos)"
            +"VALUES (@NombrePDF,@TipoPDF,@DatosPDF)";
            _comando.Parameters.Add("@NombrePDF", SqlDbType.VarChar).Value = nombrePDF;
            _comando.Parameters.Add("@TipoPDF", SqlDbType.VarChar).Value = "application/pdf";
            _comando.Parameters.Add("@DatosPDF", SqlDbType.Binary).Value = PDFbytes;
            return MetodosDatos.ejecutarInsert(_comando);
        }

        public static DataTable selectPDF(int id)
        {
            SqlCommand _comando = MetodosDatos.crearComando();
            _comando.CommandText = "SELECT Nombre, Tipo, Datos FROM tablaPDF WHERE id =" + id;
            return MetodosDatos.ejecutarSelect(_comando);
        }
    }
}

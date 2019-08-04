using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class MetodosDatos
    {
        public static SqlCommand crearComando()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;
            return _comando;
        }

        public static Boolean ejecutarInsert(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally 
            {
                comando.Connection.Close();
                comando.Connection.Dispose();
            }
        }

        public static DataTable ejecutarSelect(SqlCommand comando)
        {
            DataTable _tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(_tabla);
                return _tabla;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                comando.Connection.Close();
                comando.Connection.Dispose();
            }
        }
    }
}

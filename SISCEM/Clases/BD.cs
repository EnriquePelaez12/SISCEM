using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SISCEM
{
    class BD
    {
        //Método que crea una conexión a una BD 
        public SqlConnection conexionsql()
        {//ConexiónSQL
            //Se declara una variable que contendrá una conexión a una BD
            SqlConnection conexion = new SqlConnection();
            //conexion.ConnectionString = "Server=DESKTOP-LGHFFO2; User=logical; database=PRESTO; Password=talamanca";
            conexion.ConnectionString = @"Server=JHUERTA\SQL2016; initial Catalog=PRESTO; Integrated Security=True";            
            return conexion;
        }//Conexiónsql
    
    }
}

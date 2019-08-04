using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SISCEM
{
    public class ClsParametros
    {
        //Parametros
        public string Nombre { get; set; }
        public Object Valor { get; set; }
        public SqlDbType TipoDato { get; set; }
        public Int32 Tamaño { get; set; }
        public ParameterDirection Direccion { get; set; }
        //Constructores
        //Entrada
        public ClsParametros(string ObjNombre, Object ObjValor)
        {
            Nombre = ObjNombre;
            Valor = ObjValor;
            Direccion = ParameterDirection.Input;
        }
        //Salida
        public ClsParametros(string ObjNombre, SqlDbType ObjTipoDato, Int32 ObjTamaño)
        {
            Nombre = ObjNombre;
            TipoDato = ObjTipoDato;
            Tamaño = ObjTamaño;
            Direccion = ParameterDirection.Output;
        }
        public ClsParametros(String objNombre, Object objValor, SqlDbType objTipoDato, ParameterDirection objDireccion, int objTamaño)
        {
            Nombre = objNombre;
            Valor = objValor;
            TipoDato = objTipoDato;
            Direccion = objDireccion;
            Tamaño = objTamaño;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SISCEM
{
    public class ClsConeccion
    {

        SqlConnection cnn = new SqlConnection(@"Server=JHUERTA\SQL2016;Database=Presto;Trusted_Connection=True;");


        void Abrir_Coneccion()
        {
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
        }

        void Cerrar_Coneccion()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
        public DataTable Listado(String NombreSP, List<ClsParametros> lst)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            try
            {
                Abrir_Coneccion();
                da = new SqlDataAdapter(NombreSP, cnn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        da.SelectCommand.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                    }
                }
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Cerrar_Coneccion();
            return dt;
        }

        public void EjecutarSP(String NombreSP, ref List<ClsParametros> lst)
        {
            SqlCommand cmd;
            try
            {
                Abrir_Coneccion();
                cmd = new SqlCommand(NombreSP, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].Direccion == ParameterDirection.Input)
                            cmd.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        if (lst[i].Direccion == ParameterDirection.Output)
                            cmd.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output;
                    }
                    cmd.ExecuteNonQuery();
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (cmd.Parameters[i].Direction == ParameterDirection.Output)
                            lst[i].Valor = cmd.Parameters[i].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Cerrar_Coneccion();
        }


        public void Ejecuta_SP_Ins_Del_Upd(string NombreSP, List<ClsParametros> lst)
        {
            SqlCommand comando;
            try
            {
                Abrir_Coneccion();
                comando = new SqlCommand(NombreSP, cnn);
                comando.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].Direccion == ParameterDirection.Input)
                        {
                            comando.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        }
                        if (lst[i].Direccion == ParameterDirection.Output)
                        {
                            comando.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output;
                        }
                    }
                    comando.ExecuteNonQuery();
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (comando.Parameters[i].Direction == ParameterDirection.Output)
                        {
                            lst[i].Valor = comando.Parameters[i].Value.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Cerrar_Coneccion();
        }


        public DataTable Regresa_Datos(string NombreSP, List<ClsParametros> lst)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;

            try
            {
                da = new SqlDataAdapter(NombreSP, cnn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        da.SelectCommand.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                    }
                }
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }


        public DataTable Regresa_Datos(string NombreSP)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;

            try
            {
                da = new SqlDataAdapter(NombreSP, cnn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //if (lst != null)
                //{
                //    for (int i = 0; i < lst.Count; i++)
                //    {
                //        da.SelectCommand.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                //    }
                //}
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }




    }
}

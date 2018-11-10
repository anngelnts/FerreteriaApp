using System;
using System.Data;
using System.Data.SqlClient;

namespace FerreteriaApp.Comun
{
    public class Conexion
    {
        public static SqlConnection Connection;
        public static SqlConnection Open()
        {
            try
            {
                Connection = new SqlConnection("Data Source=LAPTOP-9BJPC4E5;initial Catalog=FerreteriaApp;integrated Security=true");
                //Conexion = new SqlConnection("Data Source=AEPIS11;initial Catalog=BD_VENTAS;integrated Security=true");
                if (Connection.State == ConnectionState.Broken || Connection.State == ConnectionState.Closed)
                {
                    Connection.Open();
                    return Connection;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la Conexion", e);
            }
            return Connection;
        }
        public static void Close()
        {
            try
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la Conexion", e);
            }
        }
        public static DataSet ExecuteProcedureD(string procedure, SQLParameter[] parameters = null)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            try
            {
                cmd.Connection = Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedure;
                if (parameters != null)
                {
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        cmd.Parameters.Add(parameters[i].Name, parameters[i].Type).Value = parameters[i].Value;
                    }
                }
                data.Fill(ds, "DataTable");
                Close();
                return ds;
            }
            catch
            {
                return ds;
            }
        }
        public static bool ExecuteProcedureB(string procedure, SQLParameter[] parameters = null)
        {
            bool Response = false;
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            try
            {
                cmd.Connection = Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedure;
                if (parameters != null)
                {
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        cmd.Parameters.Add(parameters[i].Name, parameters[i].Type).Value = parameters[i].Value;
                    }
                }
                Response = cmd.ExecuteNonQuery() > 0 ? true : false;
                Close();
                return Response;
            }
            catch
            {
                return false;
            }
        }
    }
}

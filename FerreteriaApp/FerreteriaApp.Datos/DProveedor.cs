using FerreteriaApp.Comun;
using FerreteriaApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaApp.Datos
{
    public class DProveedor
    {
        protected bool Response = false;
        public bool Agregar(Proveedor obj)
        {
            SQLParameter[] parameters = new SQLParameter[6];
            parameters[0] = new SQLParameter("@Ruc", obj.Ruc, SqlDbType.VarChar);
            parameters[1] = new SQLParameter("@RazonSocial", obj.RazonSocial, SqlDbType.VarChar);
            parameters[2] = new SQLParameter("@Ciudad", obj.Ciudad, SqlDbType.VarChar);
            parameters[3] = new SQLParameter("@Direccion", obj.Direccion, SqlDbType.VarChar);
            parameters[4] = new SQLParameter("@Email", obj.Email, SqlDbType.VarChar);
            parameters[5] = new SQLParameter("@Telefono", obj.Telefono, SqlDbType.VarChar);
            Response = Conexion.ExecuteProcedureB("USP_I_AgregarProveedor", parameters);
            return Response;
        }
        public bool Modificar(Proveedor obj)
        {
            SQLParameter[] parameters = new SQLParameter[6];
            parameters[0] = new SQLParameter("@Ruc", obj.Ruc, SqlDbType.VarChar);
            parameters[1] = new SQLParameter("@RazonSocial", obj.RazonSocial, SqlDbType.VarChar);
            parameters[2] = new SQLParameter("@Ciudad", obj.Ciudad, SqlDbType.VarChar);
            parameters[3] = new SQLParameter("@Direccion", obj.Direccion, SqlDbType.VarChar);
            parameters[4] = new SQLParameter("@Email", obj.Email, SqlDbType.VarChar);
            parameters[5] = new SQLParameter("@Telefono", obj.Telefono, SqlDbType.VarChar);
            Response = Conexion.ExecuteProcedureB("USP_U_ModificarProveedor", parameters);
            return Response;
        }
        public List<Proveedor> Listar()
        {
            List<Proveedor> List = new List<Proveedor>();
            try
            {
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_ListarProveedor").Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    Proveedor be = new Proveedor
                    {
                        ID = Convert.ToInt32(row[0]),
                        Ruc = row[1].ToString(),
                        RazonSocial = row[2].ToString(),
                        Ciudad = row[3].ToString(),
                        Direccion = row[4].ToString(),
                        Email = row[5].ToString(),
                        Telefono = row[6].ToString()
                    };
                    List.Add(be);
                }
            }
            catch
            {
                Console.WriteLine("No se encontro Procedimiento Almacenado");
            }
            return List;
        }
        public Proveedor Seleccionar(string Ruc)
        {
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@Ruc", Ruc, SqlDbType.VarChar);
                DataRow row = Conexion.ExecuteProcedureD("USP_S_SeleccionarProveedor", parameters).Tables[0].Rows[0];
                Proveedor be = new Proveedor
                {
                    ID = Convert.ToInt32(row[0]),
                    Ruc = row[1].ToString(),
                    RazonSocial = row[2].ToString(),
                    Ciudad = row[3].ToString(),
                    Direccion = row[4].ToString(),
                    Email = row[5].ToString(),
                    Telefono = row[6].ToString()
                };
                return be;
            }
            catch
            {
                Proveedor be = new Proveedor();
                return be;
            }
        }

        public List<Proveedor> Buscar(string KeyWoard)
        {
            List<Proveedor> List = new List<Proveedor>();
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@KeyWoard", KeyWoard, SqlDbType.VarChar);
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_BuscarProveedor", parameters).Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    Proveedor be = new Proveedor
                    {
                        ID = Convert.ToInt32(row[0]),
                        Ruc = row[1].ToString(),
                        RazonSocial = row[2].ToString(),
                        Ciudad = row[3].ToString(),
                        Direccion = row[4].ToString(),
                        Email = row[5].ToString(),
                        Telefono = row[6].ToString()
                    };
                    List.Add(be);
                }
            }
            catch
            {
                Console.WriteLine("No se encontro Procedimiento Almacenado");
            }
            return List;
        }
    }
}

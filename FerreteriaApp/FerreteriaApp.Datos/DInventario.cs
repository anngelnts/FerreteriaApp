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
    public class DInventario
    {
        protected bool Response = false;
        public bool Agregar(Inventario obj)
        {
            SQLParameter[] parameters = new SQLParameter[4];
            parameters[0] = new SQLParameter("@Producto", obj.Producto, SqlDbType.VarChar);
            parameters[1] = new SQLParameter("@ValorUnitario", obj.ValorUnitario, SqlDbType.Decimal);
            parameters[2] = new SQLParameter("@Existencias", obj.Existencias, SqlDbType.Int);
            parameters[3] = new SQLParameter("@ValorInventario", obj.ValorInventario, SqlDbType.Decimal);
            Response = Conexion.ExecuteProcedureB("USP_I_AgregarInventario", parameters);
            return Response;
        }
        public bool Modificar(Inventario obj)
        {
            SQLParameter[] parameters = new SQLParameter[4];
            parameters[0] = new SQLParameter("@Producto", obj.Producto, SqlDbType.VarChar);
            parameters[1] = new SQLParameter("@ValorUnitario", obj.ValorUnitario, SqlDbType.Decimal);
            parameters[2] = new SQLParameter("@Existencias", obj.Existencias, SqlDbType.Int);
            parameters[3] = new SQLParameter("@ValorInventario", obj.ValorInventario, SqlDbType.Decimal);
            Response = Conexion.ExecuteProcedureB("USP_U_ModificarInventario", parameters);
            return Response;
        }
        public List<Inventario> Listar()
        {
            List<Inventario> List = new List<Inventario>();
            try
            {
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_ListarInventario").Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    Inventario be = new Inventario
                    {
                        ID = Convert.ToInt32(row[0]),
                        Producto = row["Producto"].ToString(),
                        ValorUnitario = Convert.ToDouble(row[2]),
                        Existencias = Convert.ToInt32(row[3]),
                        ValorInventario = Convert.ToDouble(row[4])
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
        public Inventario Seleccionar(string Codigo)
        {
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@Producto", Codigo, SqlDbType.VarChar);
                DataRow row = Conexion.ExecuteProcedureD("USP_S_SeleccionarInventario", parameters).Tables[0].Rows[0];
                Inventario be = new Inventario
                {
                    ID = Convert.ToInt32(row[0]),
                    Producto = row["Producto"].ToString(),
                    ValorUnitario = Convert.ToDouble(row[2]),
                    Existencias = Convert.ToInt32(row[3]),
                    ValorInventario = Convert.ToDouble(row[4])
                };
                return be;
            }
            catch
            {
                Inventario be = new Inventario();
                return be;
            }
        }

        public List<Inventario> Buscar(string KeyWoard)
        {
            List<Inventario> List = new List<Inventario>();
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@KeyWoard", KeyWoard, SqlDbType.VarChar);
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_BuscarInventario", parameters).Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    Inventario be = new Inventario
                    {
                        ID = Convert.ToInt32(row[0]),
                        Producto = row["Producto"].ToString(),
                        ValorUnitario = Convert.ToDouble(row[2]),
                        Existencias = Convert.ToInt32(row[3]),
                        ValorInventario = Convert.ToDouble(row[4])
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

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
    public class DProducto
    {
        protected bool Response = false;
        public bool Agregar(Producto obj)
        {
            SQLParameter[] parameters = new SQLParameter[9];
            parameters[0] = new SQLParameter("@Categoria", obj.Categoria, SqlDbType.Int);
            parameters[1] = new SQLParameter("@SubCategoria", obj.SubCategoria, SqlDbType.Int);
            parameters[2] = new SQLParameter("@Codigo", obj.Codigo, SqlDbType.VarChar);
            parameters[3] = new SQLParameter("@Nombre", obj.Nombre, SqlDbType.VarChar);
            parameters[4] = new SQLParameter("@Imagen", obj.Imagen, SqlDbType.VarChar);
            parameters[5] = new SQLParameter("@TipoExistencia", obj.TipoExistencia, SqlDbType.VarChar);
            parameters[6] = new SQLParameter("@UnidadMedida", obj.UnidadMedida, SqlDbType.VarChar);
            parameters[7] = new SQLParameter("@Marca", obj.Marca, SqlDbType.Int);
            parameters[8] = new SQLParameter("@Estado", obj.Estado, SqlDbType.Int);
            Response = Conexion.ExecuteProcedureB("USP_I_AgregarProducto", parameters);
            if(Response == true)
            {
                Inventario beIventario = new Inventario
                {
                    Producto = obj.Codigo,
                    ValorUnitario = 0,
                    Existencias = 0,
                    ValorInventario = 0
                };
                DInventario boInventario = new DInventario();
                boInventario.Agregar(beIventario);
            }
            return Response;
        }
        public bool Modificar(Producto obj)
        {
            SQLParameter[] parameters = new SQLParameter[8];
            parameters[0] = new SQLParameter("@Categoria", obj.Categoria, SqlDbType.Int);
            parameters[1] = new SQLParameter("@SubCategoria", obj.SubCategoria, SqlDbType.Int);
            parameters[2] = new SQLParameter("@Codigo", obj.Codigo, SqlDbType.VarChar);
            parameters[3] = new SQLParameter("@Nombre", obj.Nombre, SqlDbType.VarChar);
            parameters[4] = new SQLParameter("@Imagen", obj.Imagen, SqlDbType.VarChar);
            parameters[5] = new SQLParameter("@TipoExistencia", obj.TipoExistencia, SqlDbType.VarChar);
            parameters[6] = new SQLParameter("@UnidadMedida", obj.UnidadMedida, SqlDbType.VarChar);
            parameters[7] = new SQLParameter("@Marca", obj.Marca, SqlDbType.Int);
            Response = Conexion.ExecuteProcedureB("USP_U_ModificarProducto", parameters);
            return Response;
        }
        public List<Producto> Listar()
        {
            List<Producto> List = new List<Producto>();
            try
            {
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_ListarProducto").Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    Producto be = new Producto
                    {
                        ID = Convert.ToInt32(row[0]),
                        Categoria = Convert.ToInt32(row[1]),
                        SubCategoria = Convert.ToInt32(row[2]),
                        Codigo = row[3].ToString(),
                        Nombre = row[4].ToString(),
                        Imagen = row[5].ToString(),
                        TipoExistencia = row[6].ToString(),
                        UnidadMedida = row[7].ToString(),
                        Marca = Convert.ToInt32(row[8]),
                        Estado = Convert.ToInt32(row[9].ToString())
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
        public Producto Seleccionar(string Codigo)
        {
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@Codigo", Codigo, SqlDbType.VarChar);
                DataRow row = Conexion.ExecuteProcedureD("USP_S_SeleccionarProducto", parameters).Tables[0].Rows[0];
                Producto be = new Producto
                {
                    ID = Convert.ToInt32(row[0]),
                    Categoria = Convert.ToInt32(row[1]),
                    SubCategoria = Convert.ToInt32(row[2]),
                    Codigo = row[3].ToString(),
                    Nombre = row[4].ToString(),
                    Imagen = row[5].ToString(),
                    TipoExistencia = row[6].ToString(),
                    UnidadMedida = row[7].ToString(),
                    Marca = Convert.ToInt32(row[7]),
                    Estado = Convert.ToInt32(row[8].ToString())
                };
                return be;
            }
            catch
            {
                Producto be = new Producto();
                return be;
            }
        }

        public bool VerificarCodigo(string Codigo)
        {
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@Codigo", Codigo, SqlDbType.VarChar);
                DataRow data = Conexion.ExecuteProcedureD("USP_S_VerificarCodigoProducto", parameters).Tables[0].Rows[0];
                int cantidad = Convert.ToInt32(data[0]);
                if (cantidad == 0)
                {
                    Response = true;
                }
                else
                {
                    Response = false;
                }
            }
            catch
            {
                Response = false;
            }
            return Response;
        }

        public List<Producto> Buscar(string KeyWoard)
        {
            List<Producto> List = new List<Producto>();
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@KeyWoard", KeyWoard, SqlDbType.VarChar);
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_BuscarProducto", parameters).Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    Producto be = new Producto
                    {
                        ID = Convert.ToInt32(row[0]),
                        Categoria = Convert.ToInt32(row[1]),
                        SubCategoria = Convert.ToInt32(row[2]),
                        Codigo = row[3].ToString(),
                        Nombre = row[4].ToString(),
                        Imagen = row[5].ToString(),
                        TipoExistencia = row[6].ToString(),
                        UnidadMedida = row[7].ToString(),
                        Marca = Convert.ToInt32(row[7]),
                        Estado = Convert.ToInt32(row[8].ToString())
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

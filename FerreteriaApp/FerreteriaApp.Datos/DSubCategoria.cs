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
    public class DSubCategoria
    {
        protected bool Response = false;
        public bool Agregar(SubCategoria obj)
        {
            SQLParameter[] parameters = new SQLParameter[2];
            parameters[0] = new SQLParameter("@Categoria", obj.Categoria, SqlDbType.Int);
            parameters[1] = new SQLParameter("@Nombre", obj.Nombre, SqlDbType.VarChar);
            Response = Conexion.ExecuteProcedureB("USP_I_AgregarSubCategoria", parameters);
            return Response;
        }
        public bool Modificar(SubCategoria obj)
        {
            SQLParameter[] parameters = new SQLParameter[3];
            parameters[0] = new SQLParameter("@ID", obj.ID, SqlDbType.Int);
            parameters[1] = new SQLParameter("@Categoria", obj.Categoria, SqlDbType.Int);
            parameters[2] = new SQLParameter("@Nombre", obj.Nombre, SqlDbType.VarChar);
            Response = Conexion.ExecuteProcedureB("USP_U_ModificarSubCategoria", parameters);
            return Response;
        }
        public List<SubCategoria> Listar()
        {
            List<SubCategoria> List = new List<SubCategoria>();
            DataTable data = new DataTable();
            data = Conexion.ExecuteProcedureD("USP_S_ListarSubCategoria").Tables[0];
            foreach (DataRow row in data.Rows)
            {
                SubCategoria be = new SubCategoria
                {
                    ID = Convert.ToInt32(row[0]),
                    Categoria = Convert.ToInt32(row[1]),
                    Nombre = row[2].ToString()
                };
                List.Add(be);
            }
            return List;
        }
        public List<SubCategoria> ListarxCategoria(int categoria)
        {
            List<SubCategoria> List = new List<SubCategoria>();
            SQLParameter[] parameters = new SQLParameter[1];
            parameters[0] = new SQLParameter("@Categoria", categoria, SqlDbType.Int);
            DataTable data = new DataTable();
            data = Conexion.ExecuteProcedureD("USP_S_ListarSubCategoriaxCategoria", parameters).Tables[0];
            foreach (DataRow row in data.Rows)
            {
                SubCategoria be = new SubCategoria
                {
                    ID = Convert.ToInt32(row[0]),
                    Categoria = Convert.ToInt32(row[1]),
                    Nombre = row[2].ToString()
                };
                List.Add(be);
            }
            return List;
        }
        public Dictionary<int, string> CuadroCombinado()
        {
            Dictionary<int, string> Lista = new Dictionary<int, string>();
            if (Listar().Count > 0)
            {
                foreach (SubCategoria item in Listar())
                {
                    Lista.Add(item.ID, item.Nombre);
                }
                return Lista;
            }
            return Lista;
        }
        public Dictionary<int, string> CuadroCombinadoxCategoria(int categoria)
        {
            Dictionary<int, string> Lista = new Dictionary<int, string>();
            if (ListarxCategoria(categoria).Count > 0)
            {
                foreach (SubCategoria item in ListarxCategoria(categoria))
                {
                    Lista.Add(item.ID, item.Nombre);
                }
                return Lista;
            }
            return Lista;
        }
    }
}

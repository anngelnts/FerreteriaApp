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
    public class DTipoExistencia
    {
        public List<TipoExistencia> Listar()
        {
            List<TipoExistencia> List = new List<TipoExistencia>();
            DataTable data = new DataTable();
            data = Conexion.ExecuteProcedureD("USP_S_ListarTipoExistencia").Tables[0];
            foreach (DataRow row in data.Rows)
            {
                TipoExistencia be = new TipoExistencia
                {
                    Codigo = row[0].ToString(),
                    Descripcion = row[1].ToString()
                };
                List.Add(be);
            }
            return List;
        }
        public Dictionary<string, string> CuadroCombinado()
        {
            Dictionary<string, string> Lista = new Dictionary<string, string>();
            if (Listar().Count > 0)
            {
                foreach (TipoExistencia item in Listar())
                {
                    Lista.Add(item.Codigo, item.Descripcion);
                }
                return Lista;
            }
            return Lista;
        }
    }
}

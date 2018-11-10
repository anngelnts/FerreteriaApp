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
    public class DUnidadMedida
    {
        public List<UnidadMedida> Listar()
        {
            List<UnidadMedida> List = new List<UnidadMedida>();
            DataTable data = new DataTable();
            data = Conexion.ExecuteProcedureD("USP_S_ListarUnidadMedida").Tables[0];
            foreach (DataRow row in data.Rows)
            {
                UnidadMedida be = new UnidadMedida
                {
                    Codigo = row[0].ToString(),
                    Descripcion = row[1].ToString(),
                    Abreviatura = row[2].ToString(),
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
                foreach (UnidadMedida item in Listar())
                {
                    Lista.Add(item.Codigo, item.Descripcion);
                }
                return Lista;
            }
            return Lista;
        }
    }
}

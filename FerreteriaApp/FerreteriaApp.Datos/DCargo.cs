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
    public class DCargo
    {
        protected bool Response = false;
        public bool Agregar(Cargo obj)
        {
            SQLParameter[] parameters = new SQLParameter[1];
            parameters[0] = new SQLParameter("@Descripcion", obj.Descripcion, SqlDbType.VarChar);
            Response = Conexion.ExecuteProcedureB("USP_I_AgregarCargo", parameters);
            return Response;
        }
        public bool Modificar(Cargo obj)
        {
            SQLParameter[] parameters = new SQLParameter[2];
            parameters[0] = new SQLParameter("@ID", obj.ID, SqlDbType.Int);
            parameters[1] = new SQLParameter("@Descripcion", obj.Descripcion, SqlDbType.VarChar);
            Response = Conexion.ExecuteProcedureB("USP_U_ModificarCargo", parameters);
            return Response;
        }
        public List<Cargo> Listar()
        {
            List<Cargo> List = new List<Cargo>();
            try
            {
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureD("USP_S_ListarCargo").Tables[0];
                foreach (DataRow row in data.Rows)
                {
                    Cargo be = new Cargo
                    {
                        ID = Convert.ToInt32(row[0]),
                        Descripcion = row[1].ToString()
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
        public Cargo Seleccionar(int Identificador)
        {
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@ID", Identificador, SqlDbType.Int);
                DataRow row = Conexion.ExecuteProcedureD("USP_S_SeleccionarCargo", parameters).Tables[0].Rows[0];
                Cargo be = new Cargo
                {
                    ID = Convert.ToInt32(row[0]),
                    Descripcion = row[1].ToString()
                };
                return be;
            }
            catch
            {
                Cargo be = new Cargo();
                return be;
            }
        }
        public Dictionary<int, string> CuadroCombinado()
        {
            Dictionary<int, string> Lista = new Dictionary<int, string>();
            if (Listar().Count > 0)
            {
                foreach (Cargo item in Listar())
                {
                    Lista.Add(item.ID, item.Descripcion);
                }
                return Lista;
            }
            return Lista;
        }
    }
}

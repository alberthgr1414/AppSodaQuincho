using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDAL
    {
        public static DataTable UsarioLogin(string usuario,string contrasena)
        {
            //Declaración de objeto SqlCommand           
            SqlCommand oCommand = new SqlCommand();

            //Declaración de Objeto DataTable
            DataTable oDataTable = new DataTable();
            oCommand.CommandText = "SpUsuarioLogin";
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.Parameters.AddWithValue("@Nombre_Usuario", usuario);
            oCommand.Parameters.AddWithValue("@Contrasenna", contrasena);
            oCommand.Parameters[0].Direction = ParameterDirection.Input;

            try
            {
                return PersistenciaSqlServer.Persistencia.Persistencia.getInstance().EjecutarConsultaDataTable(oCommand);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                oDataTable.Dispose();
            }
        }
    }
}

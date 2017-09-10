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

        public static DataTable UsarioLogin(string usuario, string contrasena)
        {
            //Declaración de objeto SqlCommand
            SqlCommand oCommand = new SqlCommand();
            DataTable registro;
            oCommand.CommandText = "SpUsuarioLogin";
            oCommand.CommandType = CommandType.StoredProcedure;

            //Crear los Parámetros del procedimiento y sus valores
            oCommand.Parameters.AddWithValue("@Nombre_Usuario", usuario);
            oCommand.Parameters[0].Direction = ParameterDirection.Input;

            oCommand.Parameters.AddWithValue("@Contrasenna", contrasena);
            oCommand.Parameters[1].Direction = ParameterDirection.Input;

            try
            {
                registro = PersistenciaSqlServer.Persistencia.Persistencia.getInstance().EjecutarConsultaDataTable(oCommand);
                return registro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

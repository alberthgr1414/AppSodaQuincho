using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Entidades;

namespace DAL
{
    public class IngresoDAL
    {
        public static DataTable IngresoSistema(Ingreso ingres)
        {
            //Declaración de objeto SqlCommand           
            SqlCommand oCommand = new SqlCommand();
            //Declaración de Objeto DataTable
            DataTable oDataTable = new DataTable();
            oCommand.CommandText = "SpPlatoListar";
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.Parameters.AddWithValue("@Nombre_Usuario", ingres.usuario);
            oCommand.Parameters[0].Direction = ParameterDirection.Input;

            oCommand.Parameters.AddWithValue("@Contrasenna", ingres.pass);
            oCommand.Parameters[1].Direction = ParameterDirection.Input;
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Entidades;

namespace DAL
{
    class EncFacturaDAL
    {
        public static int NuevoEncFactura(EncFactura pEncFactura)
        {
            //Declaración de objeto SqlCommand

            SqlCommand oCommand = new SqlCommand();
            int registrosActualizados = 0;
            oCommand.CommandText = "SpNuevoEncFactura";
            oCommand.CommandType = CommandType.StoredProcedure;

            //Crear los Parámetros del procedimiento y sus valores
            oCommand.Parameters.AddWithValue("@ID_TipoPlato", pEncFactura.ID_Empleado);
            oCommand.Parameters[0].Direction = ParameterDirection.Input;

            oCommand.Parameters.AddWithValue("@Nombre_Plato", pEncFactura.Fecha);
            oCommand.Parameters[1].Direction = ParameterDirection.Input;

            try
            {
                registrosActualizados = PersistenciaSqlServer.Persistencia.Persistencia.getInstance().EjecutarSqlActualizacion(oCommand);
                return registrosActualizados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Entidades;

namespace DAL
{
    public class EncFacturaDAL
    {
        public static int NuevoEncFactura(EncFactura pEncFactura)
        {
            //Declaración de objeto SqlCommand

            SqlCommand oCommand = new SqlCommand();
            int registrosActualizados = 0;
            oCommand.CommandText = "SpNuevoEncFactura";
            oCommand.CommandType = CommandType.StoredProcedure;

            //Crear los Parámetros del procedimiento y sus valores
            oCommand.Parameters.AddWithValue("@ID_Turno", pEncFactura.ID_Turno);
            oCommand.Parameters[0].Direction = ParameterDirection.Input;

            oCommand.Parameters.AddWithValue("@ID_Caja", pEncFactura.ID_Caja);
            oCommand.Parameters[1].Direction = ParameterDirection.Input;

            oCommand.Parameters.AddWithValue("@Estado", pEncFactura.ID_EstadoEncFactura);
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

        public static string EncFactura(int estado)
        {
            //Declaración de objeto SqlCommand
            SqlCommand oCommand = new SqlCommand();
            string registro;
            oCommand.CommandText = "SpEncFactura";
            oCommand.CommandType = CommandType.StoredProcedure;

            oCommand.Parameters.AddWithValue("@ID_EstadoEncFactura", estado);
            oCommand.Parameters[0].Direction = ParameterDirection.Input;

            try
            {
                registro = PersistenciaSqlServer.Persistencia.Persistencia.getInstance().EjecutarSQLScalar(oCommand);
                return registro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void CambiarEstadoEncFactura(EncFactura pEncFactura)
        {
            //Declaración de objeto SqlCommand
            SqlCommand oCommand = new SqlCommand();
            string registro;
            oCommand.CommandText = "SpCambiarEstadoEncFactura";
            oCommand.CommandType = CommandType.StoredProcedure;

            //Crear los Parámetros del procedimiento y sus valores
            oCommand.Parameters.AddWithValue("@ID_EncFactura", pEncFactura.ID_EncFactura);
            oCommand.Parameters[0].Direction = ParameterDirection.Input;

            oCommand.Parameters.AddWithValue("@ID_EstadoEncFactura", pEncFactura.ID_EstadoEncFactura);
            oCommand.Parameters[1].Direction = ParameterDirection.Input;

            try
            {
                PersistenciaSqlServer.Persistencia.Persistencia.getInstance().EjecutarSqlActualizacion(oCommand);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ListarEncFactura(int ID_EstadoEncFactura)
        {
            //Declaración de objeto SqlCommand
            SqlCommand oCommand = new SqlCommand();
            DataTable registro;
            oCommand.CommandText = "SpEncFacturaListar";
            oCommand.CommandType = CommandType.StoredProcedure;

            //Crear los Parámetros del procedimiento y sus valores
            oCommand.Parameters.AddWithValue("@ID_EstadoEncFactura", ID_EstadoEncFactura);
            oCommand.Parameters[0].Direction = ParameterDirection.Input;

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

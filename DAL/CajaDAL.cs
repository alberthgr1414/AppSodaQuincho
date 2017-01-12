using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CajaDAL
    {
        public static DataTable UltimaCajaAbirta()
        {
            //Declaración de objeto SqlCommand           
            SqlCommand oCommand = new SqlCommand();
            //Declaración de Objeto DataTable
            DataTable oDataTable = new DataTable();
            oCommand.CommandText = "SpTurnoListar";
            oCommand.CommandType = CommandType.StoredProcedure;
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

        public static bool VereificarCajaAbierta()
        {
            DataTable dat = UltimaCajaAbirta();
            bool valor = false;
            if (dat.Rows.Count == 0)
            {
                valor = false;
            }
            else
            {
                valor = true;
            }
            return valor;
        }

        public static int GuardarCaja(Turno pTurno)
        {
            //Declaración de objeto SqlCommand
            SqlCommand oCommand = new SqlCommand();
            int registrosActualizados = 0;
            oCommand.CommandText = "SpTurnoInsertar";
            oCommand.CommandType = CommandType.StoredProcedure;

            //Crear los Parámetros del procedimiento y sus valores
            oCommand.Parameters.AddWithValue("@ID_Usuario", 1);
            oCommand.Parameters[0].Direction = ParameterDirection.Input;

            oCommand.Parameters.AddWithValue("@Monto", 1);
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


        public static void CerrarCaja()
        {
            //Declaración de objeto SqlCommand
            SqlCommand oCommand = new SqlCommand();
            int registrosActualizados = 0;
            oCommand.CommandText = "SpTurnoCerrar";
            oCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                registrosActualizados = PersistenciaSqlServer.Persistencia.Persistencia.getInstance().EjecutarSqlActualizacion(oCommand);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AbrirCaja(Caja caja)
        {
            //Declaración de objeto SqlCommand
            SqlCommand oCommand = new SqlCommand();
            int registrosActualizados = 0;
            oCommand.CommandText = "SpTurnoAbrir";
            oCommand.CommandType = CommandType.StoredProcedure;

            oCommand.Parameters.AddWithValue("@ID_Usuario", caja.ID_Usuario);
            oCommand.Parameters[0].Direction = ParameterDirection.Input;

            oCommand.Parameters.AddWithValue("@Fondo", caja.Fondo);
            oCommand.Parameters[1].Direction = ParameterDirection.Input;
            try
            {
                registrosActualizados = PersistenciaSqlServer.Persistencia.Persistencia.getInstance().EjecutarSqlActualizacion(oCommand);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class TurnoDAL
    {
        public static DataTable UltimoTurnoAbierto()
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

        public static bool VereificarTurnoAbierto()
        {
            DataTable dat = UltimoTurnoAbierto();
            bool valor=false;
            if (dat.Rows.Count == 0)
            {
                valor= false;
            }
            else
            {
                valor = true;
            }
            return valor;
        }


        public static void CerrarTurno()
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

        public static void AbrirTurno(Turno turno)
        {
            //Declaración de objeto SqlCommand
            SqlCommand oCommand = new SqlCommand();
            int registrosActualizados = 0;
            oCommand.CommandText = "SpTurnoAbrir";
            oCommand.CommandType = CommandType.StoredProcedure;

            oCommand.Parameters.AddWithValue("@ID_Usuario", turno.ID_Usuario);
            oCommand.Parameters[0].Direction = ParameterDirection.Input;

            oCommand.Parameters.AddWithValue("@Fondo", turno.Monto);
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

        public static string Turno()
        {
            //Declaración de objeto SqlCommand
            SqlCommand oCommand = new SqlCommand();
            string registro = "";
            oCommand.CommandText = "SpTurno";
            oCommand.CommandType = CommandType.StoredProcedure;
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


    }
}

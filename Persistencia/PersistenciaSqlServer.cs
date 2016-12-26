﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.PersistenciaSqlServer
{
    public class Persistencia
    {
        private static Persistencia instance = null;

        public SqlConnection oConexion { set; get; }

        public static Persistencia getInstance()
        {
            if (instance == null)
            {
                instance = new Persistencia();
            }
            return instance;
        }

        public void establecerConexion(String usuario, String clave)
        {
            StringBuilder hileraConexion = new StringBuilder();


            hileraConexion.AppendFormat("{0}", );


            hileraConexion.AppendFormat(";User Id={0};Password={1}", usuario, clave);

            oConexion = new SqlConnection(hileraConexion.ToString());

            try
            {
                oConexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error de conexión" + "\n" + e.Message +
                                     "\n" + hileraConexion.ToString());
            }
        }

        //Método que permite ejecutar sentencia Insert,Delete,Update
        //Retorna la cantidad de registros insertados
        public Int32 EjecutarSqlActualizacion(String oSql)
        {
            Int32 vRegistrosActualizados = 0;
            try
            {
                using (SqlTransaction transaccion = oConexion.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    SqlCommand oCommand = new SqlCommand(oSql);
                    oCommand.Connection = oConexion;
                    oCommand.Transaction = transaccion;
                    oCommand.CommandType = CommandType.Text;

                    vRegistrosActualizados = oCommand.ExecuteNonQuery();
                    transaccion.Commit();
                }

            }
            catch (Exception errorSQL)
            {
                throw new Exception("Error de SQL en la Actualización\n" +
                                       "Message: " + errorSQL.Message + "\n" +
                                       "Método: " + MethodBase.GetCurrentMethod().Name + "\n" +
                                       "oCommand toString(): " + oSql);

            }
            return vRegistrosActualizados;
        }


        //Método que permite ejecutar sentencia Insert,Delete,Update
        //Retorna la cantidad de registros insertados
        public Int32 EjecutarSqlActualizacionVarios(List<String> listaSql)
        {

            Int32 vRegistrosActualizados = 0;
            SqlCommand oCommand = new SqlCommand();

            //Inicia una transacción.
            try
            {

                using (SqlTransaction transaccion = oConexion.BeginTransaction(IsolationLevel.ReadCommitted))
                {

                    foreach (String oSql in listaSql)
                    {
                        oCommand = new SqlCommand(oSql);
                        oCommand.Connection = oConexion;
                        oCommand.Transaction = transaccion;
                        oCommand.CommandType = CommandType.Text;
                        vRegistrosActualizados += oCommand.ExecuteNonQuery();
                    }//fin foreach
                    transaccion.Commit();
                }//fin del using de la transacción
            }
            catch (Exception errorSQL)
            {
                throw new Exception("Error de SQL en actualización de varios comandos\n" +
                                     "Message: " + errorSQL.Message + "\n" +
                                     "Método: " + MethodBase.GetCurrentMethod().Name + "\n" +
                                     "oCommand toString(): " + oCommand.CommandText.ToString());

            }

            return vRegistrosActualizados;
        }





        //Método que permite ejecutar sentencia Insert,Delete,Update
        //Retorna la cantidad de registros insertados
        public Int32 EjecutarSqlActualizacion(SqlCommand oCommand)
        {
            Int32 vRegistrosActualizados = 0;

            oCommand.Connection = oConexion;
            try
            {
                using (SqlTransaction transaccion = oConexion.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    oCommand.Transaction = transaccion;
                    vRegistrosActualizados = oCommand.ExecuteNonQuery();
                    transaccion.Commit();
                }
            }
            catch (Exception errorSQL)
            {
                throw new Exception("Error de SQL en la actualización\n" +
                                     "Message: " + errorSQL.Message + "\n" +
                                     "Método: " + MethodBase.GetCurrentMethod().Name + "\n" +
                    //"Error source: " + errorSQL.Source +
                    //"Error toString(): " + errorSQL.ToString() + "\n" +
                    //"StackTrace:" + errorSQL.StackTrace + "\n" +
                                     "oCommand toString(): " + oCommand.CommandText.ToString());
            }
            return vRegistrosActualizados;
        }



        //Método que permite ejecutar instrucciones Select 
        //Retorna el resultado en un objeto DataTable
        public DataTable EjecutarConsultaDataTable(String oSql)
        {
            DataTable oDataTable = new DataTable();
            SqlCommand oCommand = new SqlCommand();
            try
            {
                oCommand.Connection = oConexion;
                oCommand.CommandText = oSql;
                oCommand.CommandType = CommandType.Text;

                using (SqlDataAdapter adaptador = new SqlDataAdapter(oCommand))
                {

                    adaptador.Fill(oDataTable);
                }
                return oDataTable;
            }
            catch (Exception errorSQL)
            {
                throw new Exception("Error de SQL en la consulta DataTable\n" +
                                        "Message: " + errorSQL.Message + "\n" +
                                        "Método: " + MethodBase.GetCurrentMethod().Name + "\n" +
                                        "Sentencia Sql: " + oSql);
            }
        }

        public DataTable EjecutarConsultaDataTable(SqlCommand oCommand)
        {

            DataTable oDataTable = new DataTable();
            oCommand.Connection = oConexion;
            try
            {
                using (SqlDataAdapter adaptador = new SqlDataAdapter(oCommand))
                {

                    adaptador.Fill(oDataTable);
                }
            }
            catch (Exception errorSQL)
            {
                throw new Exception("Error de SQL en la consulta DataTable\n" +
                                     "Message: " + errorSQL.Message + "\n" +
                                     "Método: " + MethodBase.GetCurrentMethod().Name + "\n" +
                                     "oCommand toString(): " + oCommand.CommandText.ToString());
            }
            return oDataTable;
        }


        //Método que permite ejecutar instrucciones Select 
        //Retorna el resultado en un objeto DataTable
        public DataSet EjecutarConsultaDataSet(String oSql)
        {
            DataSet dsTabla = new DataSet();
            try
            {
                SqlCommand oCommand = new SqlCommand();
                oCommand.Connection = oConexion;
                oCommand.CommandText = oSql;
                oCommand.CommandType = CommandType.Text;
                using (SqlDataAdapter adaptador = new SqlDataAdapter(oCommand))
                {
                    adaptador.Fill(dsTabla);
                }
            }

            catch (Exception errorSQL)
            {
                throw new Exception("Error de SQL en la consulta DataSet\n" +
                                        "Message: " + errorSQL.Message + "\n" +
                                        "Método: " + MethodBase.GetCurrentMethod().Name + "\n" +
                                        "Sentencia Sql: " + oSql);
            }
            return dsTabla;
        }


        //Método que permite ejecutar instrucciones Select 
        //Retorna el resultado en un objeto DataReader
        public SqlDataReader EjecutarConsultaDataReader(String oSql)
        {
            SqlDataReader oSqlDataReader = null;

            try
            {

                SqlCommand oCommand = new SqlCommand();
                oCommand.Connection = oConexion;
                oCommand.CommandText = oSql;
                oCommand.CommandType = CommandType.Text;

                oSqlDataReader = oCommand.ExecuteReader();
            }
            catch (Exception error)
            {

                throw new Exception("Error de SQL en la consulta DataTable\n" +
                                         "Message: " + error.Message + "\n" +
                                         "Método: " + MethodBase.GetCurrentMethod().Name + "\n" +
                                         "Sentencia Sql: " + oSql);

            }

            return oSqlDataReader;
        }



        // Método que permite ejecutar sentencias SQL Escalares --> SUM, AVG, MIN, MAX, etc.
        //Retorna el único resultado que genera la consulta en una String
        public String EjecutarSQLScalar(String oSql)
        {

            //Declaración de variable para resultado del SqlScalar            
            String vResultadoScalar = "";

            try
            {
                // Creación del nuevo objeto tipo Command
                SqlCommand oCommand = new SqlCommand(oSql);

                //Asignación del objeto conexión y tipo Command
                oCommand.Connection = oConexion;
                oCommand.CommandType = CommandType.Text;

                //Ejecutar el SQL Escalar y retornar el valor 
                vResultadoScalar = oCommand.ExecuteScalar().ToString();
                //Retornar el resultado del SqlScalar
                return vResultadoScalar;
            }
            catch (Exception errorSQL)
            {

                throw new Exception("Error de SQL en la consulta escalar\n" +
                                      "Message: " + errorSQL.Message + "\n" +
                                      "Método: " + MethodBase.GetCurrentMethod().Name + "\n" +
                                      "Sentencia Sql: " + oSql);

            }

        }

        // Método que permite ejecutar sentencias SQL Escalares --> SUM, AVG, MIN, MAX, etc.
        //Retorna el único resultado que genera la consulta en una String
        public String EjecutarSQLScalar(SqlCommand oCommand)
        {

            //Declaración de variable para resultado del SqlScalar            
            String vResultadoScalar = "";
            try
            {
                //Asignación del objeto conexión, String SQL y tipo Command
                oCommand.Connection = oConexion;

                //Ejecutar el SQL Escalar y retornar el valor 
                vResultadoScalar = oCommand.ExecuteScalar().ToString();
                //Retornar el resultado del SqlScalar
                return vResultadoScalar;
            }
            catch (Exception errorSQL)
            {
                throw new Exception("Error de SQL en la consulta DataTable\n" +
                                      "Message: " + errorSQL.Message + "\n" +
                                      "Método: " + MethodBase.GetCurrentMethod().Name + "\n" +
                                      "oCommand toString(): " + oCommand.CommandText.ToString());

            }
        }
    }
}
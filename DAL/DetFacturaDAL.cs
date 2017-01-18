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
    public class DetFacturaDAL
    {
        public static int NuevoDetFactura(DetFactura pDetFactura)
        {
            //Declaración de objeto SqlCommand

            SqlCommand oCommand = new SqlCommand();
            int registrosActualizados = 0;
            oCommand.CommandText = "SpNuevoDetFactura";
            oCommand.CommandType = CommandType.StoredProcedure;

            //Crear los Parámetros del procedimiento y sus valores
            oCommand.Parameters.AddWithValue("@ID_EncFactura", pDetFactura.ID_EncFactura);
            oCommand.Parameters[0].Direction = ParameterDirection.Input;

            oCommand.Parameters.AddWithValue("@ID_Plato", pDetFactura.ID_Plato);
            oCommand.Parameters[1].Direction = ParameterDirection.Input;

            oCommand.Parameters.AddWithValue("@Cantidad", pDetFactura.Cantidad);
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


        public static DataTable ListarDetalleFactura(DetFactura detfactura)
        {
            //Declaración de objeto SqlCommand
            SqlCommand oCommand = new SqlCommand();
            DataTable registro;
            oCommand.CommandText = "SpDetFacturaListar";
            oCommand.CommandType = CommandType.StoredProcedure;

            //Crear los Parámetros del procedimiento y sus valores
            oCommand.Parameters.AddWithValue("@ID_EncFactura", detfactura.ID_EncFactura);
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

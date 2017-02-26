using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class EncFacturaBLL
    {
        public static int NuevoEncFactura(int ID_Turno, int ID_Caja)
        {
            //Construir el cliente

            EncFactura oEncFactura = new EncFactura()
            {
                ID_Caja = ID_Caja,
                ID_Turno = ID_Turno,
                ID_EstadoEncFactura =1
            };
            try
            {
                return EncFacturaDAL.NuevoEncFactura(oEncFactura);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void CambiarEstadoEncFactura(int ID_EncFactura, int ID_EStadoEncFactura)
        {
            //Construir el cliente

            EncFactura oEncFactura = new EncFactura()
            {
                ID_EncFactura = ID_EncFactura,
                ID_EstadoEncFactura = ID_EStadoEncFactura
            };
            try
            {
                 EncFacturaDAL.CambiarEstadoEncFactura(oEncFactura);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string EncFactura(int estado)
        {
            try
            {
                return EncFacturaDAL.EncFactura(estado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ListarEncFactura(int ID_EstadoEncFactura)
        {
            try
            {
                return EncFacturaDAL.ListarEncFactura(ID_EstadoEncFactura);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

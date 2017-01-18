using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DetFacturaBLL
    {
        public static int NuevoDetFactura(int ID_EncFactura, int ID_Plato,int Cantidad)
        {
            //Construir el cliente

            DetFactura oDetFactura = new DetFactura()
            {
                ID_EncFactura = ID_EncFactura,
                ID_Plato = ID_Plato,
                Cantidad = Cantidad
            };
            try
            {
                return DetFacturaDAL.NuevoDetFactura(oDetFactura);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ListarDetFactura(int ID_EncFactura)
        {
            DetFactura oDetFactura = new DetFactura()
            {
                ID_EncFactura = ID_EncFactura
            };
            try
            {
                return DetFacturaDAL.ListarDetalleFactura(oDetFactura);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

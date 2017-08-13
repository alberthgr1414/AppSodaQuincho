using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BLL
{
    public class BilleteBLL
    {
        public static double CalculoCambio(double TotalFactura, double efectivo)
        {
            try
            {
                Billete billete = new Billete(TotalFactura, efectivo);
                return billete.CalculoCambio(billete);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

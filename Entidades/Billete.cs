using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Billete
    {
        public double TotalFactura = 0;
        public double Pago = 0;

        public Billete(double TotalFactura, double Pago)
        {
            this.Pago = Pago;
            this.TotalFactura = TotalFactura ;
        }

        public double CalculoCambio(Billete billete)
        {
            double Cambio = 0;
            Cambio = billete.Pago - billete.TotalFactura;
            return Cambio;
        }
    }
}

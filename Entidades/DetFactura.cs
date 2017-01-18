using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DetFactura
    {
        public int ID_DetFactura { set; get; }
        public int ID_EncFactura { set; get; }
        public int ID_Plato { set; get; }
        public int Cantidad { set; get; }
        public double Total { set; get; }
    }
}

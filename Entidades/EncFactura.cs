using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class EncFactura
    {
        public int ID_EncFactura { set; get; }
        public int ID_Turno { set; get; }
        public int ID_Caja { set; get; }
        public DateTime Fecha { set; get; }
        public double Total { set; get; }
        public int ID_EstadoEncFactura { set; get; }
    }
}

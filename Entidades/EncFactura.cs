using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class EncFactura
    {
        public int ID_EncFactura { set; get; }
        public int ID_Empleado { set; get; }
        public DateTime Fecha { set; get; }
    }
}

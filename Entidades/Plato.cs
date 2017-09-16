using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Plato
    {
        public int ID_Plato { set; get; }
        public int ID_TipoPlato { set; get; }
        public string Nombre_Plato { set; get; }
        public double Precio_Plato { set; get; }
        public Byte[] foto { set; get; }
        public int ID_Estado { set; get; }
    }
}

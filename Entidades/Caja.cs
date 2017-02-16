using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Caja
    {
        public int ID_Turno { set; get; }
        public string ID_Caja { set; get; }
        public int ID_Usuario { set; get; }
        public DateTime Apertura { set; get; }
        public DateTime Cierre { set; get; }
        public double Fondo { set; get; }
        public int Estado { set; get; }
    }
}

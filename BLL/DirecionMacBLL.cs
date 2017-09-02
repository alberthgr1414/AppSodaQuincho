using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BLL
{
    public class DirecionMacBLL
    {
        public static string ObtenerDirecionMac()
        {
            try
            {
                DirecionMac Mac = new DirecionMac();
                return Mac.GetMACAddress();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

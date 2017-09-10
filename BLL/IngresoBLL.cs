using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace BLL
{
    public class IngresoBLL
    {
        public static void Ingreso(string Usuario, string pass)
        {
            try
            {
                Ingreso oIngreso = new Ingreso()
                {
                    usuario = Usuario,
                    pass = pass
                };
                IngresoDAL.IngresoSistema(oIngreso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

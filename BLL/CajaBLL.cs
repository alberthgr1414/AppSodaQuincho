using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class CajaBLL
    {
        public static bool VereificarTurnoAbierto()
        {
            try
            {
                return CajaDAL.VereificarCajaAbierta();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void CerrarCaja()
        {
            try
            {
                CajaDAL.CerrarCaja();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AbrirTurno(int codigo, int monto)
        {
            try
            {
                Caja oCaja = new Caja()
                {
                    ID_Usuario= codigo,
                    Fondo = monto,
                };
                CajaDAL.AbrirCaja(oCaja);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

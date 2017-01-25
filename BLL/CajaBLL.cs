using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{


    public class CajaBLL
    {
        public static bool VereificarCajaAbierta()
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

        public static void AbrirCaja(int codigo, int monto)
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

        public static string Caja()
        {
            try
            {
                return CajaDAL.Caja();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

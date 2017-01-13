using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TurnoBLL
    {
        public static bool VereificarTurnoAbierto()
        {
            try
            {
                return TurnoDAL.VereificarTurnoAbierto();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void CerrarTurno()
        {
            try
            {
               TurnoDAL.CerrarTurno();
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
                Turno oTurno = new Turno()
                {
                    ID_Usuario = codigo,
                    Monto = monto,
                };
                TurnoDAL.AbrirTurno(oTurno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string Turno()
        {
            try
            {
                return TurnoDAL.Turno();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

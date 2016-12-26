﻿using DAL;
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
    }
}
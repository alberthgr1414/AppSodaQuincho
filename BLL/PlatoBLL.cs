using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using DAL;

namespace BLL
{
    public class PlatoBLL
    {

        public static int GuardarPlato(int ID_TipoPlato, string Nombre_Plato, double Precio_Plato,Byte[] foto)
        {
            //Construir el cliente

            Plato oPlato = new Plato()
            {
                ID_TipoPlato = ID_TipoPlato,
                Nombre_Plato = Nombre_Plato,
                Precio_Plato = Precio_Plato,
                foto = foto,
            };
            try
            {
                return PlatoDAL.GuardarPlato(oPlato);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static int ModificarPlato(int idPlato, int ID_TipoPlato, string Nombre_Plato, double Precio_Plato, Byte[] foto)
        {
            //Construir el cliente

            Plato oPlato = new Plato()
            {
                ID_Plato = idPlato,
                ID_TipoPlato = ID_TipoPlato,
                Nombre_Plato = Nombre_Plato,
                Precio_Plato = Precio_Plato,
                foto = foto,
            };
            try
            {
                return PlatoDAL.ModificarPlato(oPlato);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static DataTable ListarPlatos(int TipoPlato)
        {
            try
            {
                return PlatoDAL.ListarPlatos(TipoPlato);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ListarPlatoScalar(int ID_Plato)
        {
            try
            {
                return PlatoDAL.ListarPlatoScalar(ID_Plato);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

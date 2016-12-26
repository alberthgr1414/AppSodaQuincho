using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class UsuarioBLL
    {
        public static DataTable UsuarioLogin(string usuario,string contrasena)
        {
            try
            {
                return UsuarioDAL.UsarioLogin(usuario, contrasena);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

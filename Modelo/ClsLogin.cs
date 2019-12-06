using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ClsLogin
    {
        public usuario login(string numDoc, string clave)
        {
            OrmDataContext baseDeDatos = new OrmDataContext();
            var login = (from usa in baseDeDatos.usuario where usa.cedula_u == numDoc && usa.clave_u == clave select usa).FirstOrDefault();
            return login;

        }
        public eps loginEps(string nit, string clave)
        {
            OrmDataContext baseDeDatos = new OrmDataContext();
            var login = (from usa in baseDeDatos.eps where usa.nit_eps == nit && usa.clave_eps == clave select usa).FirstOrDefault();
            return login;

        }
        public usuario loginAdmin(string numDoc, string clave)
        {
            OrmDataContext baseDeDatos = new OrmDataContext();
            var login = (from usa in baseDeDatos.usuario where usa.cedula_u == numDoc && usa.clave_u == clave select usa).FirstOrDefault();
            return login;

        }
    }
}

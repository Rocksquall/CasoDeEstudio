using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ClsRol
    {
        public List<rol> ListaRol()
        {
            OrmDataContext baseDeDatos = new OrmDataContext();
            var listaRoles = (from ro in baseDeDatos.rol select ro).ToList();
            return listaRoles;
        }
    }
}

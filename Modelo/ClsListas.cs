using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Modelo
{
 public   class ClsListas
    {
        OrmDataContext baseDeDatos = new OrmDataContext();
        public void listaRol(ref DropDownList ddlListaRol)
        {
          
            ddlListaRol.DataSource = (from ro in baseDeDatos.rol select ro).ToList();
            ddlListaRol.DataValueField = "idRol";
            ddlListaRol.DataTextField = "rol1";
            ddlListaRol.DataBind();
            
        }

    }
}

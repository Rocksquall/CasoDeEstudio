using System.Linq;
using System.Web.UI.WebControls;

namespace Modelo
{
    public class ClsListas
    {
        OrmDataContext baseDeDatos = new OrmDataContext();
        public void listaRol(ref DropDownList ddlListaRol)
        {

            ddlListaRol.DataSource = (from ro in baseDeDatos.rol select ro).ToList();
            ddlListaRol.DataValueField = "idRol";
            ddlListaRol.DataTextField = "rol1";
            ddlListaRol.DataBind();

        }
        public void listaNivelAtencion(ref DropDownList ddlNivelAtencion)
        {

            ddlNivelAtencion.DataSource = (from at in baseDeDatos.nivel_atencion select at).ToList();
            ddlNivelAtencion.DataValueField = "idnivel_atencion";
            ddlNivelAtencion.DataTextField = "atencion";
            ddlNivelAtencion.DataBind();

        }
        public void listaEspecialidad(ref DropDownList ddlEspecialidad)
        {

            ddlEspecialidad.DataSource = (from at in baseDeDatos.especialidad select at).ToList();
            ddlEspecialidad.DataValueField = "idespecialidad";
            ddlEspecialidad.DataTextField = "especialidad_eps";
            ddlEspecialidad.DataBind();

        }
        public void listaEps(ref DropDownList ddlEps)
        {

            ddlEps.DataSource = (from at in baseDeDatos.eps select at).ToList();
            ddlEps.DataValueField = "ideps";
            ddlEps.DataTextField = "nombre_eps";
            ddlEps.DataBind();

        }
    }
}

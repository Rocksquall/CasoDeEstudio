using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Modelo
{
    public class ClsEps { 
    public string registrarEps(eps eps)
    {
        string mensaje;
        OrmDataContext baseDeDatos = new OrmDataContext();

        try
        {
            baseDeDatos.eps.InsertOnSubmit(eps);
            baseDeDatos.SubmitChanges();
            mensaje = "Se Registro";
        }
        catch (Exception ex)
        {
            mensaje = "Error al registrar " + ex.Message;

        }

        return mensaje;

    }
    public string actualizareps(eps ep)
    {
        string mensaje;

        OrmDataContext baseDeDatos = new OrmDataContext();

        try
        {
            var epsActualizar = (from eps in baseDeDatos.eps where eps.ideps == ep.ideps select eps).FirstOrDefault();

            if (epsActualizar != null)
            {
                epsActualizar.nit_eps = ep.nit_eps;
                epsActualizar.nombre_eps = ep.nombre_eps;
                epsActualizar.direccion_eps = ep.direccion_eps;
                epsActualizar.telefono_eps = ep.telefono_eps;
                baseDeDatos.SubmitChanges();
                mensaje = "Se Actualizo";
            }
            else
            {
                mensaje = "La eps no existe";
            }
        }

        catch (Exception ex)
        {
            mensaje = "Error al actualizar: " + ex.Message;

        }
        return mensaje;


    }
    public string eliminarEps(int ideps)

    {
        string mensaje;

        OrmDataContext baseDeDatos = new OrmDataContext();

        try
        {
            var epsEliminar = (from eps in baseDeDatos.eps where eps.ideps == ideps select eps).FirstOrDefault();
            if (epsEliminar != null)
            {
                baseDeDatos.eps.DeleteOnSubmit(epsEliminar);
                baseDeDatos.SubmitChanges();
                mensaje = "Se elimino";
            }
            else
            {
                mensaje = "Eps No existe";
            }


        }
        catch (Exception ex)
        {
            mensaje = "Error al Eliminar: " + ex.Message;

        }

        return mensaje;

    }
    public void listaEps(ref GridView GlvEps)
    {
        OrmDataContext baseDeDatos = new OrmDataContext();
            GlvEps.DataSource = (from eps in baseDeDatos.eps select eps).ToList();
            GlvEps.DataBind();
    }



}
}

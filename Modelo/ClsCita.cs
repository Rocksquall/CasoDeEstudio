using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Modelo
{
   public class ClsCita
    {
        public string registrarCita(cita citaa)
        {
            string mensaje;

            OrmDataContext baseDeDatos = new OrmDataContext();


            try
            {
                baseDeDatos.cita.InsertOnSubmit(citaa);
                baseDeDatos.SubmitChanges();
                mensaje = "Se Registro";
            }
            catch (Exception ex)
            {
                mensaje = "Error al registrar " + ex.Message;

            }

            return mensaje;

        }

        public string actualizarCita(cita citaa)
        {
            string mensaje;

            OrmDataContext baseDeDatos = new OrmDataContext();


            try
            {
                var citaActualizar = (from ci in baseDeDatos.cita where ci.idcita == ci.idcita select ci).FirstOrDefault();
                if (citaActualizar != null)
                {
                    citaActualizar.idcita = citaa.idcita;
                    citaActualizar.fecha_cita = citaa.fecha_cita;
                    citaActualizar.centro_medico_idcentro_medico = citaa.centro_medico_idcentro_medico;
                    baseDeDatos.SubmitChanges();
                    mensaje = "Se Actualizo";
                }
                else
                {
                    mensaje = "Valoracion No existe";
                }


            }
            catch (Exception ex)
            {
                mensaje = "Error al actualizar: " + ex.Message;

            }

            return mensaje;

        }
        public string eliminarCita(int idCita)
        {
            string mensaje;

            OrmDataContext baseDeDatos = new OrmDataContext();


            try
            {
                var citaEliminar = (from ci in baseDeDatos.cita where ci.idcita == idCita select ci).FirstOrDefault();
                if (citaEliminar != null)
                {
                    baseDeDatos.cita.DeleteOnSubmit(citaEliminar);
                    baseDeDatos.SubmitChanges();
                    mensaje = "Se elimino";
                }
                else
                {
                    mensaje = "Valoracion No existe";
                }


            }
            catch (Exception ex)
            {
                mensaje = "Error al Eliminar: " + ex.Message;

            }

            return mensaje;

        }

        public void listaCita(ref GridView gdvTablaCita)
        {
            OrmDataContext baseDeDatos = new OrmDataContext();
            gdvTablaCita.DataSource = (from ci in baseDeDatos.cita select ci).ToList();
            gdvTablaCita.DataBind();
        }

        public cita listaCitaId(int idCita)
        {
            OrmDataContext baseDeDatos = new OrmDataContext();
            var cita = (from ci in baseDeDatos.cita where ci.idcita == idCita select ci).FirstOrDefault();

            return cita;
        }
    }

}

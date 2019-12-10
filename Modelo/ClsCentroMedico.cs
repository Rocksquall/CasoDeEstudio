using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using Modelo;

namespace Modelo
{
    public class ClsCentroMedico
    {
        public string registrarCentroMedico(centro_medico centro)
        {
            string mensaje;

            OrmDataContext baseDeDatos = new OrmDataContext();


            try
            {
                baseDeDatos.centro_medico.InsertOnSubmit(centro);
                baseDeDatos.SubmitChanges();
                mensaje = "Se Registro";
            }
            catch (Exception ex)
            {
                mensaje = "Error al registrar " + ex.Message;

            }

            return mensaje;

        }
        public string actualizarCentroMedico(centro_medico cm)
        {
            string mensaje;

            OrmDataContext baseDeDatos = new OrmDataContext();

            try
            {
                var centroActualizar = (from centro_medico in baseDeDatos.centro_medico where centro_medico.idcentro_medico == cm.idcentro_medico select cm).FirstOrDefault();

                if (centroActualizar != null)
                {
                    centroActualizar.idcentro_medico = cm.idcentro_medico;
                    centroActualizar.nombre_centro = cm.nombre_centro;
                    centroActualizar.direccion_centro = cm.direccion_centro;
                    centroActualizar.foto_centro = cm.foto_centro;
                    centroActualizar.hora_inicio = cm.hora_inicio;
                    centroActualizar.hora_fin = cm.hora_fin;
                    centroActualizar.telefono_centro = cm.telefono_centro;
                    centroActualizar.visita_centro = cm.visita_centro;
                    centroActualizar.nivel_atencion_idnivel_atencion = cm.nivel_atencion_idnivel_atencion;
                    centroActualizar.especialidad_idespecialidad = cm.especialidad_idespecialidad;
                    centroActualizar.eps_ideps = cm.eps_ideps;
                    baseDeDatos.SubmitChanges();
                    mensaje = "Se Actualizo";
                }
                else
                {
                    mensaje = "El Centro Medico no existe";
                }
            }

            catch (Exception ex)
            {
                mensaje = "Error al actualizar: " + ex.Message;

            }
            return mensaje;


        }

        public string eliminarCentroMedico(int idcentro_medico)
        {
            string mensaje;

            OrmDataContext baseDeDatos = new OrmDataContext();


            try
            {
                var centroEliminar = (from ce in baseDeDatos.centro_medico where ce.idcentro_medico == idcentro_medico select ce).FirstOrDefault();
                if (centroEliminar != null)
                {
                    baseDeDatos.centro_medico.DeleteOnSubmit(centroEliminar);
                    baseDeDatos.SubmitChanges();
                    mensaje = "Se elimino";
                }
                else
                {
                    mensaje = "Usuario No existe";
                }


            }
            catch (Exception ex)
            {
                mensaje = "Error al Eliminar: " + ex.Message;

            }

            return mensaje;

        }
        public void ListaCentroMedico(ref GridView glvCentros)
        {
            OrmDataContext baseDeDatos = new OrmDataContext();
            glvCentros.DataSource = (from centro_medico in baseDeDatos.centro_medico select centro_medico).ToList();
            glvCentros.DataBind();
        }
    }
}

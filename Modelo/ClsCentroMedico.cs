﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

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
        public List<centro_medico> ListaCentroMedico(ref GridView glvCentros)
        {
            OrmDataContext baseDeDatos = new OrmDataContext();
            var ListaCentro = (from cm in baseDeDatos.centro_medico select cm).ToList();
            return ListaCentro;
        }
        public string actualizarCentroMedico(centro_medico centro)
        {
            string mensaje;

            OrmDataContext baseDeDatos = new OrmDataContext();


            try
            {
                var usuarioActualizar = (from ce in baseDeDatos.centro_medico where ce.idcentro_medico == centro.idcentro_medico select ce).FirstOrDefault();
                if (usuarioActualizar != null)
                {
                    baseDeDatos.SubmitChanges();
                    mensaje = "Se Actualizo";
                }
                else
                {
                    mensaje = "Usuario No existe";
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
    }
}

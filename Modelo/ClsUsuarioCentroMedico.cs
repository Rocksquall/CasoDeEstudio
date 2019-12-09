using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ClsUsuarioCentroMedico
    {
        public List<int> ListaCalificacion()
        {
            List<int> calificacion = new List<int>
            {
                1,
                2,
                3,
                4,
                5
            };
            return calificacion;
        }
        public string CalificarCentroMedico(usuario_centro_medico ucm)
        {
            string mensaje;

            OrmDataContext baseDeDatos = new OrmDataContext();

            try
            {
                var centroCalificar = (from usuario_centro_medico in baseDeDatos.usuario_centro_medico where usuario_centro_medico.idusuario_centro_medico == ucm.idusuario_centro_medico select usuario_centro_medico).FirstOrDefault();

                if (centroCalificar != null)
                {
                    centroCalificar.centro_medico_idcentro_medico = ucm.centro_medico_idcentro_medico;
                    centroCalificar.usuario_idusuario = ucm.usuario_idusuario;
                    centroCalificar.calificacion = ucm.calificacion;

                    baseDeDatos.usuario_centro_medico.InsertOnSubmit(ucm);
                    baseDeDatos.SubmitChanges();
                    mensaje = "Calificado con Exito";
                }
                else
                {
                    mensaje = "No se pudo calificar";
                }
            }

            catch (Exception ex)
            {
                mensaje = "Error al actualizar: " + ex.Message;

            }
            return mensaje;


        }
    }
}

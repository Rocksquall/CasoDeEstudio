using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Modelo
{
    public class ClsEspecialidad
    {
        public List<especialidad> ListaEspecialidad()
        {
            OrmDataContext baseDeDatos = new OrmDataContext();
            var ListaEspecialidad = (from es in baseDeDatos.especialidad select es).ToList();
            return ListaEspecialidad;
        }

        public string RegistrarEspecialidad(especialidad es)
        {
            string mensaje;

            OrmDataContext baseDeDatos = new OrmDataContext();


            try
            {
                baseDeDatos.especialidad.InsertOnSubmit(es);
                baseDeDatos.SubmitChanges();
                mensaje = "Se Registro Correctamente";
            }
            catch (Exception ex)
            {
                mensaje = "Error al Registrar" + ex.Message;
            }

            return mensaje;
        }

        public string ActualizarEspecialidad(especialidad es)
        {
            string mensaje;

            OrmDataContext baseDeDatos = new OrmDataContext();


            try
            {
                var espacialidadActualizar = (from esp in baseDeDatos.especialidad where esp.idespecialidad == es.idespecialidad select esp).FirstOrDefault();

                if (espacialidadActualizar != null)
                {
                    espacialidadActualizar.especialidad_eps = es.especialidad_eps;
                    baseDeDatos.SubmitChanges();
                    mensaje = "Se Actualizo Correctamente";
                }
                else
                {
                    mensaje = "La Especialidad No Existe";
                }


            }
            catch (Exception ex)
            {
                mensaje = "Error al Actualizar" + ex.Message;
            }

            return mensaje;
        }

        public string EliminarEspecialidad(int idEspecialidad)
        {
            string mensaje;

            OrmDataContext baseDeDatos = new OrmDataContext();


            try
            {
                var eliminarEspecialidad = (from esp in baseDeDatos.especialidad where esp.idespecialidad == idEspecialidad select esp).FirstOrDefault();

                if (eliminarEspecialidad != null)
                {
                    baseDeDatos.especialidad.DeleteOnSubmit(eliminarEspecialidad);
                    baseDeDatos.SubmitChanges();
                    mensaje = "Se Elimino Correctamente";
                }
                else
                {
                    mensaje = "La Especialidad No Existe";
                }


            }
            catch (Exception ex)
            {
                mensaje = "Error al Eliminar" + ex.Message;
            }

            return mensaje;
        }

        public void ListaEspecialidad(ref GridView gdvTablaEspecialidad)
        {
            OrmDataContext baseDeDatos = new OrmDataContext();
            gdvTablaEspecialidad.DataSource = (from esp in baseDeDatos.especialidad select esp).ToList();
            gdvTablaEspecialidad.DataBind();
        }

        public especialidad ListaEspecialidadId(int idEspecialidad)
        {
            OrmDataContext baseDeDatos = new OrmDataContext();
            var especialidad = (from esp in baseDeDatos.especialidad where esp.idespecialidad == idEspecialidad select esp).FirstOrDefault();

            return especialidad;
        }
    }
}




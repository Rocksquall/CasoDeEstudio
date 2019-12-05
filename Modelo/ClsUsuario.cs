using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Modelo
{
    public class ClsUsuario
    {

        public string registrarUsuario(usuario usua)
        {
            string mensaje;
            
            OrmDataContext baseDeDatos = new OrmDataContext();
            

            try
            {
                baseDeDatos.usuario.InsertOnSubmit(usua);
                baseDeDatos.SubmitChanges();
                mensaje = "Se Registro";
            }
            catch (Exception ex)
            {
                mensaje = "Error al registrar "+ ex.Message;
                
            }

            return mensaje;

        }

        public string actualizarUsuario(usuario usua)
        {
            string mensaje;

            OrmDataContext baseDeDatos = new OrmDataContext();


            try
            {
                var usuarioActualizar = (from us in baseDeDatos.usuario where us.idusuario== usua.idusuario select us).FirstOrDefault();
                if (usuarioActualizar != null)
                {
                    usuarioActualizar.nombre_u = usua.nombre_u;
                    usuarioActualizar.apellido_u = usua.apellido_u;
                    usuarioActualizar.cedula_u = usua.cedula_u;
                    usuarioActualizar.telefono_u = usua.telefono_u;
                    usuarioActualizar.correo_u = usua.correo_u;
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
        public string eliminarUsuario(int idusuario)
        {
            string mensaje;

            OrmDataContext baseDeDatos = new OrmDataContext();


            try
            {
                var usuarioEliminar = (from us in baseDeDatos.usuario where us.idusuario == idusuario select us).FirstOrDefault();
                if (usuarioEliminar != null)
                {
                    baseDeDatos.usuario.DeleteOnSubmit(usuarioEliminar);
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

        public void  listaUsuarios(ref GridView gdvTablaUsuario)
        {
            OrmDataContext baseDeDatos = new OrmDataContext();
            gdvTablaUsuario.DataSource = (from use in baseDeDatos.usuario select use).ToList();
            gdvTablaUsuario.DataBind();
        }

        public usuario listaUsuariosId(int idusuario)
        {
            OrmDataContext baseDeDatos = new OrmDataContext();
            var usuario = (from use in baseDeDatos.usuario where use.idusuario == idusuario select use).FirstOrDefault();

            return usuario;
        }

        public usuario login(string numDoc, string clave)
        {
            OrmDataContext baseDeDatos = new OrmDataContext();
            var login = (from usa in baseDeDatos.usuario where usa.cedula_u == numDoc && usa.clave_u == clave select usa).FirstOrDefault();
            return login;

        }

    }


}

using Modelo;
using System.Web.UI.WebControls;

namespace Clinica_Caso_Final
{
    public partial class Login : System.Web.UI.Page
    {


        protected void iniciarSesion_Row(object sender, AuthenticateEventArgs e)
        {
            usuario usuarioDto = new usuario();
#pragma warning disable CS0246 // El nombre del tipo o del espacio de nombres 'ClsLogin' no se encontró (¿falta una directiva using o una referencia de ensamblado?)
#pragma warning disable CS0246 // El nombre del tipo o del espacio de nombres 'ClsLogin' no se encontró (¿falta una directiva using o una referencia de ensamblado?)
            ClsLogin usuarioDao = new ClsLogin();
#pragma warning restore CS0246 // El nombre del tipo o del espacio de nombres 'ClsLogin' no se encontró (¿falta una directiva using o una referencia de ensamblado?)
#pragma warning restore CS0246 // El nombre del tipo o del espacio de nombres 'ClsLogin' no se encontró (¿falta una directiva using o una referencia de ensamblado?)

            usuarioDto = usuarioDao.login(iniciarSesion.UserName, iniciarSesion.Password);
            if (usuarioDto != null)
            {

                Session["idusuario"] = usuarioDto.idusuario;
                Session["cedula_u"] = usuarioDto.cedula_u;

                if (usuarioDto.rol_idrol == 1)
                {
                    Response.Redirect("indexAdministrador.aspx", false);
                }
                if (usuarioDto.rol_idrol == 2)
                {
                    Response.Redirect("indexEPS.aspx", false);
                }
                if (usuarioDto.rol_idrol == 3)
                {
                    Response.Redirect("indexUsuario.aspx", false);
                }
            }
            else
            {
                lblMensaje.Text = "Usuario o contraseña incorrecta";
            }

        }
    }
}
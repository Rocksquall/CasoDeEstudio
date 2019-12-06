using Modelo;
using System.Web.UI.WebControls;

namespace Clinica_Caso_Final
{
    public partial class Login : System.Web.UI.Page
    {


        protected void IniciarSesion2_Authenticate(object sender, AuthenticateEventArgs e)
        {
            eps usuarioDto = new eps();
#pragma warning disable CS0246 // El nombre del tipo o del espacio de nombres 'ClsLogin' no se encontró (¿falta una directiva using o una referencia de ensamblado?)
#pragma warning disable CS0246 // El nombre del tipo o del espacio de nombres 'ClsLogin' no se encontró (¿falta una directiva using o una referencia de ensamblado?)
            ClsLogin usuarioDao = new ClsLogin();
#pragma warning restore CS0246 // El nombre del tipo o del espacio de nombres 'ClsLogin' no se encontró (¿falta una directiva using o una referencia de ensamblado?)
#pragma warning restore CS0246 // El nombre del tipo o del espacio de nombres 'ClsLogin' no se encontró (¿falta una directiva using o una referencia de ensamblado?)

            usuarioDto = usuarioDao.loginEps(iniciarSesion.UserName, iniciarSesion.Password);
            if (usuarioDto != null)
            {

                Session["nitEPS"] = usuarioDto.nit_eps;
                if (usuarioDto.nombre_eps != null)
                {
                    Response.Redirect("indexEPS.aspx", false);
                }

            }
            else
            {
                lblMensajeEPS.Text = "Usuario o contraseña incorrecta";
            }

        }
    }
}
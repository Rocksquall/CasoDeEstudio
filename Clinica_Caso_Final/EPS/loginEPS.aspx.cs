using Modelo;
using System.Web.UI.WebControls;

namespace Clinica_Caso_Final
{
    public partial class Login : System.Web.UI.Page
    {


        protected void IniciarSesion2_Authenticate(object sender, AuthenticateEventArgs e)
        {
            eps usuarioDto = new eps();
            ClsLogin usuarioDao = new ClsLogin();

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
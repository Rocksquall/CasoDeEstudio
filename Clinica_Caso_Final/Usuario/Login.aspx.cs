using Modelo;
using System.Web.UI.WebControls;

namespace Clinica_Caso_Final
{
    public partial class Login : System.Web.UI.Page
    {


        protected void iniciarSesion_Row(object sender, AuthenticateEventArgs e)
        {
            usuario usuarioDto = new usuario();
            ClsLogin usuarioDao = new ClsLogin();

            usuarioDto = usuarioDao.login(iniciarSesion.UserName, iniciarSesion.Password);
            if (usuarioDto != null)
            {

                Session["idusuario"] = usuarioDto.idusuario;
                Session["cedula_u"] = usuarioDto.cedula_u;

                if (usuarioDto.rol_idrol == 1)
                {
                    Response.Redirect("indexAdministrador.aspx", false);
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
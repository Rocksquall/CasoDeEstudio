using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Clinica_Caso_Final
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void iniciarSesion_Authenticate(object sender, AuthenticateEventArgs e)
        {
            usuario usuarioDto = new usuario();
            ClsUsuario usuarioDao = new ClsUsuario();

            usuarioDto = usuarioDao.login(iniciarSesion.UserName, iniciarSesion.Password);
            if (usuarioDto != null)
            {

                Session["idusuario"] = usuarioDto.idusuario;
                Session["cedula_u"] = usuarioDto.cedula_u;

                if (usuarioDto.rol_idrol == 1)
                {
                    Response.Redirect("formularioRegistro.aspx",false);
                }
            }else
            {
                lblMensaje.Text = "Usuario o contraseña incorrecta";
            }

        }
    }
}
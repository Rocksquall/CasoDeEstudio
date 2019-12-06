﻿using System;
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


        protected void iniciarSesion_Authenticate(object sender, AuthenticateEventArgs e)
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
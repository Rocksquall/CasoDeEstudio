using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Clinica_Caso_Final.Administrador
{
    public partial class registrarEPS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                ClsListas lista = new ClsListas();
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {

            eps epsDto = new eps();
            ClsEps epsDao = new ClsEps();
            epsDto.nombre_eps = txtNombre_EPS.Text;
            epsDto.nit_eps = txtNit_Eps.Text;
            epsDto.telefono_eps = txtTelefono_EPS.Text;
            epsDto.direccion_eps = txtDireccion_EPS.Text;
            epsDto.clave_eps = txtClave_Eps.Text;
            epsDao.registrarEps(epsDto);


        }
    }
}
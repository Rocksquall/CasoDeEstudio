using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Clinica_Caso_Final.EPS
{
    public partial class RegistroEPSEspecialidadCentro : System.Web.UI.Page
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
                especialidad especialidadDto = new especialidad();
                ClsEspecialidad especialidadDao = new ClsEspecialidad();

                especialidadDto.especialidad_eps = txtespecialidad.Text;
                especialidadDao.RegistrarEspecialidad(especialidadDto);

                ClientScript.RegisterStartupScript(this.GetType(), "Registroespecialidad", "alerta()", true);
            }

            protected void btnRegistrar_Click2(object sender, EventArgs e)
            {
                Response.Redirect("crudEspecialidad.aspx", false);
            }
        }
    }
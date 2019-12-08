using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Clinica_Caso_Final.EPS
{
    public partial class registroCita : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarCita_Click(object sender, EventArgs e)
        {
            cita citadto = new cita();
            ClsCita citadao = new ClsCita();
            citadto.fecha_cita = txtFechaCita.Text;
            citadao.registrarCita(citadto);
        }
    }
}
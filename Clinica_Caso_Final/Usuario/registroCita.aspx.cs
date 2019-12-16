using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using Modelo;

namespace Clinica_Caso_Final.EPS
{
    public partial class registroCita : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClsListas lista = new ClsListas();
            lista.listaCentroMedico(ref ddlCentroMedico);
        }

        protected void BtnRegistrarCita_Click(object sender, EventArgs e)
        {
            cita citadto = new cita();
            ClsCita citadao = new ClsCita();


            citadto.fecha_cita = DateTime.Parse(txtFechaCita.Text);
           
            citadto.centro_medico_idcentro_medico = int.Parse(ddlCentroMedico.SelectedValue.ToString());
            citadto.usuario_idusuario = int.Parse(txtusuario.Text);
            citadao.registrarCita(citadto);
        }
    }
}
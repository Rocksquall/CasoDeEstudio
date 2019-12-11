using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Clinica_Caso_Final
{
    public partial class indexUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            usuario baseDeDatos = new usuario();

            if (!IsPostBack)
            {
                ClsListas lista = new ClsListas();
                lista.ListaNivelAtencion(ref ddlNivelAtencion);
                lista.ListaEspecialidad(ref ddlEspecialidad);
                lista.ListaEps(ref ddlEps);
            }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            centro_medico centroMedicoDto = new centro_medico();
            ClsCentroMedico centroMedicoDao = new ClsCentroMedico();
            centroMedicoDto.nombre_centro = txtCentro.Text;
            centroMedicoDto.direccion_centro = txtDireccionCentro.Text;
            string nombre = fudloadImagen.FileName;
            string ruta = "~/resource/img/" + nombre;
            fudloadImagen.SaveAs(Server.MapPath(ruta));
            centroMedicoDto.foto_centro = ruta;
            centroMedicoDto.hora_inicio = txtHoraInicioCentro.Text;
            centroMedicoDto.hora_fin = txtHoraFinCentro.Text;
            centroMedicoDto.telefono_centro = txtTelefonoCentro.Text;
            centroMedicoDto.visita_centro = txtVisitaCentro.Text;
            centroMedicoDto.nivel_atencion_idnivel_atencion = int.Parse(ddlNivelAtencion.SelectedValue.ToString());
            centroMedicoDto.especialidad_idespecialidad = int.Parse(ddlEspecialidad.SelectedValue.ToString());
            centroMedicoDto.eps_ideps = int.Parse(ddlEps.SelectedValue.ToString());
            centroMedicoDao.registrarCentroMedico(centroMedicoDto);
        }
    }
}
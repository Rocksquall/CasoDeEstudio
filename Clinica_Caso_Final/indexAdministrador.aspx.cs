using Modelo;
using System;

namespace Clinica_Caso_Final
{
    public partial class indexAdministrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            usuario baseDeDatos = new usuario();

            if (!IsPostBack)
            {
                ClsListas lista = new ClsListas();
                lista.listaNivelAtencion(ref ddlNivelAtencion);
                lista.listaEspecialidad(ref ddlEspecialidad);
                lista.listaEps(ref ddlEps);
            }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            centro_medico usuarioDto = new centro_medico();
            ClsCentroMedico usuarioDao = new ClsCentroMedico();
            usuarioDto.nombre_centro = txtCentro.Text;
            usuarioDto.direccion_centro = txtDireccionCentro.Text;
            usuarioDto.foto_centro = txtFotoCentro.Text;
            usuarioDto.hora_inicio = txtHoraInicioCentro.Text;
            usuarioDto.hora_fin = txtHoraFinCentro.Text;
            usuarioDto.telefono_centro = txtTelefonoCentro.Text;
            usuarioDto.visita_centro = txtVisitaCentro.Text;
            usuarioDto.nivel_atencion_idnivel_atencion = int.Parse(ddlNivelAtencion.SelectedValue.ToString()); ;
            usuarioDto.especialidad_idespecialidad = int.Parse(ddlEspecialidad.SelectedValue.ToString()); ;
            usuarioDto.eps_ideps = int.Parse(ddlEps.SelectedValue.ToString()); ;
            usuarioDao.registrarCentroMedico(usuarioDto);
            usuarioDao.registrarCentroMedico(usuarioDto);
        }

    }
}
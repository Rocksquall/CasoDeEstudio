using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

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
                ClsEps eps = new ClsEps();
                eps.listaEps(ref glvEps);
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


        protected void glvEps_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow fila = (GridViewRow)((Control)e.CommandSource).NamingContainer;
            int index = fila.RowIndex;
            if (e.CommandName == "Actualizar")
            {
                ClsEps eps = new ClsEps();

                txtidEps.Text = glvEps.Rows[index].Cells[0].Text;
                txtnitEps.Text = glvEps.Rows[index].Cells[1].Text;
                txtNombre_EPS.Text = glvEps.Rows[index].Cells[2].Text;
                txtDireccion_EPS.Text = glvEps.Rows[index].Cells[3].Text;
                txtTelefono_EPS.Text = glvEps.Rows[index].Cells[4].Text;
                eps.listaEps(ref glvEps);
            }
            if (e.CommandName == "Eliminar")
            {
                ClsEps eps = new ClsEps();
                eps.eliminarEps(int.Parse(glvEps.Rows[index].Cells[0].Text));
                eps.listaEps(ref glvEps);
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            eps epsDto = new eps();
            ClsEps eps = new ClsEps();

            epsDto.ideps = int.Parse(txtidEps.Text);
            epsDto.nit_eps = txtnitEps.Text;
            epsDto.nombre_eps = txtNombre_EPS.Text;
            epsDto.direccion_eps = txtDireccion_EPS.Text;
            epsDto.telefono_eps = txtTelefono_EPS.Text;
            eps.actualizareps(epsDto);
            eps.listaEps(ref glvEps);
        }
    }
}
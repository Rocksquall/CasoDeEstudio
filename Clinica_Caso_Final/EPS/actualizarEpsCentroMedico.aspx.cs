using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Clinica_Caso_Final.EPS
{
    public partial class actualizarEpsCentroMedico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClsCentroMedico centroMedico = new ClsCentroMedico();
                centroMedico.ListaCentroMedico(ref glvCentroMedico);

                ClsListas lista = new ClsListas();
                lista.ListaNivelAtencion(ref ddlNivelAtencion);
                lista.ListaEspecialidad(ref ddlEspecialidad);
                lista.ListaEps(ref ddlEps);
            }
        }
        protected void glvCentroMedico_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow fila = (GridViewRow)((Control)e.CommandSource).NamingContainer;
            int index = fila.RowIndex;
            if (e.CommandName == "Actualizar")
            {
                ClsCentroMedico centroMedico = new ClsCentroMedico();

                txtidcentro_medico.Text = glvCentroMedico.Rows[index].Cells[0].Text;
                txtnombre_centro.Text = glvCentroMedico.Rows[index].Cells[1].Text;
                txtdireccion_centro.Text = glvCentroMedico.Rows[index].Cells[2].Text;
                VisualizarImg.ImageUrl = glvCentroMedico.Rows[index].Cells[3].Text;
                txthora_inicio.Text = glvCentroMedico.Rows[index].Cells[4].Text;
                txthora_fin.Text = glvCentroMedico.Rows[index].Cells[5].Text;
                txttelefono_centro.Text = glvCentroMedico.Rows[index].Cells[6].Text;
                txtvisita_centro.Text = glvCentroMedico.Rows[index].Cells[7].Text;
                ddlNivelAtencion.Text = glvCentroMedico.Rows[index].Cells[8].Text;
                ddlEspecialidad.Text = glvCentroMedico.Rows[index].Cells[9].Text;
                ddlEps.Text = glvCentroMedico.Rows[index].Cells[10].Text;
                centroMedico.ListaCentroMedico(ref glvCentroMedico);
            }
            if (e.CommandName == "Eliminar")
            {
                ClsCentroMedico centroMedico = new ClsCentroMedico();
                centroMedico.eliminarCentroMedico(int.Parse(glvCentroMedico.Rows[index].Cells[0].Text));
                centroMedico.ListaCentroMedico(ref glvCentroMedico);
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            centro_medico ClsCentroMedicoDto = new centro_medico();
            ClsCentroMedico centroMedico = new ClsCentroMedico();

            ClsCentroMedicoDto.idcentro_medico = int.Parse(txtidcentro_medico.Text);
            ClsCentroMedicoDto.nombre_centro = txtnombre_centro.Text;
            ClsCentroMedicoDto.direccion_centro = txtdireccion_centro.Text;
            ClsCentroMedicoDto.foto_centro = VisualizarImg.ImageUrl;
            string nombre = fudloadImagen.FileName;
            string ruta = "~/resource/img/" + nombre;
            fudloadImagen.SaveAs(Server.MapPath(ruta));
            VisualizarImg.ImageUrl = ruta;
            ClsCentroMedicoDto.foto_centro = ruta;
            ClsCentroMedicoDto.hora_inicio = txthora_inicio.Text;
            ClsCentroMedicoDto.hora_fin = txthora_fin.Text;
            ClsCentroMedicoDto.telefono_centro = txttelefono_centro.Text;
            ClsCentroMedicoDto.visita_centro = txtvisita_centro.Text;
            ClsCentroMedicoDto.nivel_atencion_idnivel_atencion = int.Parse(ddlNivelAtencion.Text);
            ClsCentroMedicoDto.especialidad_idespecialidad = int.Parse(ddlEspecialidad.Text);
            ClsCentroMedicoDto.eps_ideps = int.Parse(ddlEps.Text);
            centroMedico.actualizarCentroMedico(ClsCentroMedicoDto);
            centroMedico.ListaCentroMedico(ref glvCentroMedico);
        }
    }
}


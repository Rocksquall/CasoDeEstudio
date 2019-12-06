using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Clinica_Caso_Final.EPS
{
    public partial class actualizarEpsEspecialidad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClsEspecialidad especialidad = new ClsEspecialidad();
                especialidad.ListaEspecialidad(ref gdvEspecialidad);
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {

            especialidad especialidadDto = new especialidad();
            ClsEspecialidad especialidad = new ClsEspecialidad();

            especialidadDto.idespecialidad = int.Parse(txtidEspecialidad.Text);
            especialidadDto.especialidad_eps = txtEspecialidad.Text;
            especialidad.ActualizarEspecialidad(especialidadDto);
            especialidad.ListaEspecialidad(ref gdvEspecialidad);
            pnlActualizar.Visible = false;
        }

        protected void glvEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void glvEspecialidad_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow fila = (GridViewRow)((Control)e.CommandSource).NamingContainer;
            int index = fila.RowIndex;
            if (e.CommandName == "Actualizar")
            {
                pnlActualizar.Visible = true;
                ClsEspecialidad especialidad = new ClsEspecialidad();
                txtidEspecialidad.Text = gdvEspecialidad.Rows[index].Cells[0].Text;
                txtEspecialidad.Text = gdvEspecialidad.Rows[index].Cells[1].Text;
                especialidad.ListaEspecialidad(ref gdvEspecialidad);
            }
            if (e.CommandName == "Eliminar")
            {
                ClsEspecialidad especialidad = new ClsEspecialidad();
                especialidad.EliminarEspecialidad(int.Parse(gdvEspecialidad.Rows[index].Cells[0].Text));
                especialidad.ListaEspecialidad(ref gdvEspecialidad);
            }

        }

        protected void btnActualizar_Click1(object sender, EventArgs e)
        {
            Response.Redirect("RegistroEPSEspecialidadCentro.aspx", false);
        }
    }
}

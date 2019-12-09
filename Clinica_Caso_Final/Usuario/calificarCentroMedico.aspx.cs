using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Clinica_Caso_Final.Usuario
{
    public partial class calificarCentroMedico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClsCentroMedico centroMedico = new ClsCentroMedico();
                centroMedico.ListaCentroMedico(ref glvCentros);
            }
        }
        protected void glvCentros_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow fila = (GridViewRow)((Control)e.CommandSource).NamingContainer;
            int index = fila.RowIndex;
            if (e.CommandName == "Calificar")
            {

                usuario usuarioDto = new usuario();
                ClsUsuario usuario = new ClsUsuario();

                ClsUsuarioCentroMedico usuarioCentroMedico = new ClsUsuarioCentroMedico();
                txtcentro_medico_idcentro_medico.Text = glvCentros.Rows[index].Cells[0].Text;
                txtusuario_idusuario.Text = usuarioDto.idusuario.ToString();


            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            usuario_centro_medico usuario_centro_medicoDto = new usuario_centro_medico();
            ClsUsuarioCentroMedico usuario_centro_medico = new ClsUsuarioCentroMedico();

            usuario_centro_medicoDto.idusuario_centro_medico = int.Parse(txtusuario_idusuario.Text);
            usuario_centro_medicoDto.centro_medico_idcentro_medico = int.Parse(txtcentro_medico_idcentro_medico.Text);
            usuario_centro_medicoDto.calificacion = txtcalificacion.Text;

            usuario_centro_medico.CalificarCentroMedico(usuario_centro_medicoDto);

        }
    }
}
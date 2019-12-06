using Modelo;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Clinica_Caso_Final
{
    public partial class crudUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClsUsuario usuario = new ClsUsuario();
                usuario.listaUsuarios(ref glvUsuarios);
            }
        }

        protected void glvUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow fila = (GridViewRow)((Control)e.CommandSource).NamingContainer;
            int index = fila.RowIndex;
            if (e.CommandName == "Actualizar")
            {
                ClsUsuario usuario = new ClsUsuario();
                txtIdUsuario.Text = glvUsuarios.Rows[index].Cells[0].Text;
                txtNombre.Text = glvUsuarios.Rows[index].Cells[1].Text;
                txtApellido.Text = glvUsuarios.Rows[index].Cells[2].Text;
                txtCedula.Text = glvUsuarios.Rows[index].Cells[3].Text;
                txtTelefono.Text = glvUsuarios.Rows[index].Cells[4].Text;
                txtCorreo.Text = glvUsuarios.Rows[index].Cells[5].Text;
                usuario.listaUsuarios(ref glvUsuarios);
            }
            if (e.CommandName == "Eliminar")
            {
                ClsUsuario usuario = new ClsUsuario();
                usuario.eliminarUsuario(int.Parse(glvUsuarios.Rows[index].Cells[0].Text));
                usuario.listaUsuarios(ref glvUsuarios);
            }
        }


        protected void btnActualizar_Click(object sender, EventArgs e)
        {

            usuario usuarioDto = new usuario();
            ClsUsuario usuario = new ClsUsuario();

            usuarioDto.idusuario = int.Parse(txtIdUsuario.Text);
            usuarioDto.nombre_u = txtNombre.Text;
            usuarioDto.apellido_u = txtApellido.Text;
            usuarioDto.cedula_u = txtCedula.Text;
            usuarioDto.telefono_u = txtTelefono.Text;
            usuarioDto.correo_u = txtCorreo.Text;
            usuario.actualizarUsuario(usuarioDto);
            usuario.listaUsuarios(ref glvUsuarios);
        }

        //

    }
}
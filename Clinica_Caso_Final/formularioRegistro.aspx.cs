using Modelo;
using System;

namespace Clinica_Caso_Final
{
    public partial class formularioRegistro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            usuario baseDeDatos = new usuario();

            if (!IsPostBack)
            {
                ClsListas lista = new ClsListas();
                lista.ListaRol(ref ddlRol);


            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            usuario usuarioDto = new usuario();
            ClsUsuario usuarioDao = new ClsUsuario();
            usuarioDto.nombre_u = txtNombre.Text;
            usuarioDto.apellido_u = txtApellido.Text;
            usuarioDto.cedula_u = txtCedula.Text;
            usuarioDto.correo_u = txtCorreo.Text;
            usuarioDto.telefono_u = txtTelefono.Text;
            usuarioDto.clave_u = txtClave.Text;
            usuarioDto.rol_idrol = int.Parse(ddlRol.SelectedValue.ToString()); ;
            usuarioDao.registrarUsuario(usuarioDto);
        }

    }
}

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
#pragma warning disable CS1061 // "ClsListas" no contiene una definición para "listaNivelAtencion" ni un método de extensión accesible "listaNivelAtencion" que acepte un primer argumento del tipo "ClsListas" (¿falta alguna directiva using o una referencia de ensamblado?)
                lista.listaNivelAtencion(ref ddlNivelAtencion);
#pragma warning restore CS1061 // "ClsListas" no contiene una definición para "listaNivelAtencion" ni un método de extensión accesible "listaNivelAtencion" que acepte un primer argumento del tipo "ClsListas" (¿falta alguna directiva using o una referencia de ensamblado?)
#pragma warning disable CS1061 // "ClsListas" no contiene una definición para "listaEspecialidad" ni un método de extensión accesible "listaEspecialidad" que acepte un primer argumento del tipo "ClsListas" (¿falta alguna directiva using o una referencia de ensamblado?)
                lista.listaEspecialidad(ref ddlEspecialidad);
#pragma warning restore CS1061 // "ClsListas" no contiene una definición para "listaEspecialidad" ni un método de extensión accesible "listaEspecialidad" que acepte un primer argumento del tipo "ClsListas" (¿falta alguna directiva using o una referencia de ensamblado?)
#pragma warning disable CS1061 // "ClsListas" no contiene una definición para "listaEps" ni un método de extensión accesible "listaEps" que acepte un primer argumento del tipo "ClsListas" (¿falta alguna directiva using o una referencia de ensamblado?)
                lista.listaEps(ref ddlEps);
#pragma warning restore CS1061 // "ClsListas" no contiene una definición para "listaEps" ni un método de extensión accesible "listaEps" que acepte un primer argumento del tipo "ClsListas" (¿falta alguna directiva using o una referencia de ensamblado?)
            }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            centro_medico usuarioDto = new centro_medico();
#pragma warning disable CS0246 // El nombre del tipo o del espacio de nombres 'ClsCentroMedico' no se encontró (¿falta una directiva using o una referencia de ensamblado?)
#pragma warning disable CS0246 // El nombre del tipo o del espacio de nombres 'ClsCentroMedico' no se encontró (¿falta una directiva using o una referencia de ensamblado?)
            ClsCentroMedico usuarioDao = new ClsCentroMedico();
#pragma warning restore CS0246 // El nombre del tipo o del espacio de nombres 'ClsCentroMedico' no se encontró (¿falta una directiva using o una referencia de ensamblado?)
#pragma warning restore CS0246 // El nombre del tipo o del espacio de nombres 'ClsCentroMedico' no se encontró (¿falta una directiva using o una referencia de ensamblado?)
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
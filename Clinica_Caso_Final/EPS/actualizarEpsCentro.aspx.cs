using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Clinica_Caso_Final.EPS
{
    public partial class actualizarEps : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClsEps eps = new ClsEps();
                eps.listaEps(ref glvEps);
            }
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


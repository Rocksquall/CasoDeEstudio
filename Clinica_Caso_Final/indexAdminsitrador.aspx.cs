using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Clinica_Caso_Final
{
    public partial class indexAdministrador
    {
        protected void Page_Load(object sender, EventArgs e)
        {
       

            if (!IsPostBack)
            {
                ClsListas lista = new ClsListas();
                lista.listaNivelAtencion(ref ddl;


            }
        }

    }
}

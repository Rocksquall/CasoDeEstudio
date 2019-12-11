using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.DataVisualization;


using Modelo;

namespace Clinica_Caso_Final.Administrador
{
    public partial class reportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnGraficoCircular_Click(object sender, EventArgs e)
        {
            graficoCalificaciones.Visible = true;
            graficoCalificaciones.DataSource = ClsUtilidad.listaCalificaciones;
            graficoCalificaciones.Series["Series1"].XValueMember = "Calificacion";
            graficoCalificaciones.Series["Series1"].YValueMembers = "Cantidad";

        }

        protected void btnGraficoNuevaEps_Click(object sender, EventArgs e)
        {
            graficoCalificaciones.Visible = true;
            graficoCalificaciones.DataSource = ClsUtilidad.listaCalificaciones1;
            graficoCalificaciones.Series["Series1"].XValueMember = "Calificacion";
            graficoCalificaciones.Series["Series1"].YValueMembers = "Cantidad";

        }

        protected void btnGraficoCountry_Click(object sender, EventArgs e)
        {
            graficoCalificaciones.Visible = true;
            graficoCalificaciones.DataSource = ClsUtilidad.listaCalificaciones2;
            graficoCalificaciones.Series["Series1"].XValueMember = "Calificacion";
            graficoCalificaciones.Series["Series1"].YValueMembers = "Cantidad";

        }

        protected void btnGraficoOccidente_Click(object sender, EventArgs e)
        {
            graficoCalificaciones.Visible = true;
            graficoCalificaciones.DataSource = ClsUtilidad.listaCalificaciones3;
            graficoCalificaciones.Series["Series1"].XValueMember = "Calificacion";
            graficoCalificaciones.Series["Series1"].YValueMembers = "Cantidad";

        }

        protected void btnGraficoCaracas_Click(object sender, EventArgs e)
        {
            graficoCalificaciones.Visible = true;
            graficoCalificaciones.DataSource = ClsUtilidad.listaCalificaciones4;
            graficoCalificaciones.Series["Series1"].XValueMember = "Calificacion";
            graficoCalificaciones.Series["Series1"].YValueMembers = "Cantidad";

        }
    }
}
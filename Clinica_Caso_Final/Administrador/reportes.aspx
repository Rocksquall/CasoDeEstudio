<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reportes.aspx.cs" Inherits="Clinica_Caso_Final.Administrador.reportes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous" />
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
    <link rel="shortcut icon" type="image/x-icon" href="../../resource/img/icono3.png" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="row">
                <div class="card col-1"></div>
                <div class="card col-4">
                    <br />
                    <h5>
                        <center>Centros Medicos Disponibles</center>
                    </h5>
                    <br />




                    <asp:Button ID="btnGraficoNuevaEps" class="btn btn-info" runat="server" Text="Centro 1" OnClick="btnGraficoNuevaEps_Click" /><br />
                    <asp:Button ID="btnGraficoCountry" class="btn btn-info" runat="server" Text="Centro 2" OnClick="btnGraficoCountry_Click" /><br />
                    <asp:Button ID="btnGraficoOcciddente" class="btn btn-info" runat="server" Text="Centro 3" OnClick="btnGraficoOccidente_Click" /><br />
                    <asp:Button ID="btnGraficoCaracas" class="btn btn-info" runat="server" Text="Centro 4" OnClick="btnGraficoCaracas_Click" /><br />
                    <asp:Button ID="btnGraficoCircular" class="btn btn-info" runat="server" Text="Centro 5"
                        OnClick="btnGraficoCircular_Click" /><br />
                </div>
                <div class="card col-2">
                </div>
                <div class="card col-4">
                    <br />
                    <h5>
                        <center>Grafico Centros Medicos </center>
                    </h5>
                    <br />
                    <center>


            <asp:Chart ID="graficoCalificaciones" runat="server" >
                <series>
                    <asp:Series Name="Series1" ChartType="Bar" IsValueShownAsLabel="True">

                    </asp:Series>

                </series>
                <chartareas><asp:ChartArea Name="ChartArea1"></asp:ChartArea></chartareas>
            </asp:Chart>
                       
                         
                     
                     </center>
                </div>
                <div class="card col-1"></div>
            </div>
        </div>
    </form>

</body>
</html>

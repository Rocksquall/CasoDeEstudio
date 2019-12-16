<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexAdministrador.aspx.cs" Inherits="Clinica_Caso_Final.SeleccionAdministrador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="formularioSeleccion" runat="server">
        <div>
            <a href="registrarEPS.aspx">Registrar EPS</a>
            <a href="editarEPS.aspx">Consultar y editar EPS</a>
            <a href="../EPS/registroEPSCentro.aspx">Registrar Centro Medico</a>
            <a href="../EPS/actualizarEpsCentroMedico.aspx">Consultar y editar Centro Medico</a>
            <a href="reportes.aspx">reportes</a>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginEPS.aspx.cs" Inherits="Clinica_Caso_Final.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:Login ID="iniciarSesionEPS" runat="server" OnAuthenticate="iniciarSesion_Authenticate" TitleText="Iniciar Sesión" UserNameLabelText="NIT EPS"></asp:Login>
        </div>
        <asp:Label ID="lblMensajeEPS" runat="server"></asp:Label>
        <br />
        <a href="Login.aspx">¿Eres Usuario?</a>
        <br />
        <a href="LoginAdmin.aspx">¿Eres Administrador?</a></form>
</body>
</html>
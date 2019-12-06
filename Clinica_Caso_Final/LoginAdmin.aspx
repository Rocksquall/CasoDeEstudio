<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginAdmin.aspx.cs" Inherits="Clinica_Caso_Final.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form3" runat="server">
        <div>
            <asp:Login ID="iniciarSesionAdmin" runat="server" OnAuthenticate="iniciarSesion_Authenticate" TitleText="Iniciar Sesión" UserNameLabelText="Documento Usuario"></asp:Login>
        </div>
        <asp:Label ID="lblMensajeAdmin" runat="server"></asp:Label>
        <br />
        <a href="Login.aspx">¿Eres Usuario?</a><br />
        <a href="LoginEPS.aspx">¿Eres EPS?</a>
    </form>
</body>
</html>
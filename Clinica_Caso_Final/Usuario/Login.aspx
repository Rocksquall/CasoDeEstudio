<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Clinica_Caso_Final.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Login ID="iniciarSesion" runat="server" OnAuthenticate="iniciarSesion_Row" TitleText="Iniciar Sesión" UserNameLabelText="Documento Usuario"></asp:Login>
        </div>
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        <br />
        <a href="../EPS/LoginEPS.aspx">¿Eres EPS?</a>
        <br />
        </form>
</body>
</html>
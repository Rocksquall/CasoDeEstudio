<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Clinica_Caso_Final.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../resource/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../resource/css/app.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-12" class="formulario">
                <asp:Login  classCheckBoxStyle-CssClass="mt-3" PasswordLabelText-CssClass="form-control" LoginButtonStyle-CssClass="btn btn-danger" LabelStyle-CssClass="form-control"  ID="iniciarSesion" runat="server" OnAuthenticate="iniciarSesion_Row" TitleText="Iniciar Sesión" UserNameLabelText="Documento Usuario"></asp:Login>
            </div>
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            <br />
            <a href="../EPS/LoginEPS.aspx">¿Eres EPS?</a>
            <br />
        </div>
    </form>

    <link href="../resource/js/jquery-3.4.1.min.js" rel="stylesheet" />
    <link href="../resource/js/bootstrap.min.js" rel="stylesheet" />
</body>
</html>

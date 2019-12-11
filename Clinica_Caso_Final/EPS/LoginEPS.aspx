<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginEPS.aspx.cs" Inherits="Clinica_Caso_Final.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../resource/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../resource/css/app.css" rel="stylesheet" />
</head>
<body>
    <div class="formulario-top">
        <div class="card center" style="width: 25rem;">
            <form id="form2" runat="server">
                <div class="row">
                    <div class="formulario">
                        <div>
                            <asp:Login LabelStyle-CssClass="" LoginButtonStyle-CssClass="btn btn-danger btn-lg btn-block" TitleTextStyle-CssClass="font-weight-bold text-center pt-6"  ID="iniciarSesionEPS" runat="server" OnAuthenticate="IniciarSesion2_Authenticate" TitleText="Iniciar Sesión" UserNameLabelText="NIT EPS"></asp:Login>
                        </div>
                        <a href="../Usuario/Login.aspx">¿Eres Usuario o Administrador?</a>
                    </div>
                    <asp:Label ID="lblMensajeEPS" runat="server"></asp:Label>
                </div>
            </form>
        </div>
    </div>
    <link href="../resource/js/jquery-3.4.1.min.js" rel="stylesheet" />
    <link href="../resource/js/bootstrap.min.js" rel="stylesheet" />
</body>
</html>

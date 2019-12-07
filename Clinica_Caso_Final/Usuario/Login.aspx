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
 <div class="formulario-top">
  <div class="card center" style="width: 25rem;">
    <form id="form1" runat="server">
        <div class="row">
            <div class="formulario">
                <asp:Login LabelStyle-CssClass="" LoginButtonStyle-CssClass="btn btn-danger btn-lg btn-block" TitleTextStyle-CssClass="font-weight-bold text-center pt-6" ID="iniciarSesion" runat="server" OnAuthenticate="iniciarSesion_Row" TitleText="Iniciar Sesión" UserNameLabelText="Documento Usuario: "></asp:Login>
                <a href="../EPS/LoginEPS.aspx">¿Eres EPS?</a>
                </div>
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        </div>
    </form>
   </div>
  </div>
    <link href="../resource/js/jquery-3.4.1.min.js" rel="stylesheet" />
    <link href="../resource/js/bootstrap.min.js" rel="stylesheet" />
</body>
</html>

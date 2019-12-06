<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexUsuario.aspx.cs" Inherits="Clinica_Caso_Final.indexUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Index Usuario</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>                   
            <asp:Button ID="btn_consulta" runat="server" Text="Realizar Consulta" />
            <asp:Button ID="btn_sitios_cercanos" runat="server" Text="Buscar sitio Cercano" />

        </div>
    </form>
</body>
</html>

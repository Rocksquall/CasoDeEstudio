<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroEPSEspecialidadCentro.aspx.cs" Inherits="Clinica_Caso_Final.EPS.RegistroEPSEspecialidadCentro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server">
            <div>
                <asp:Label ID="lblEspecialidad_EPS" runat="server" Text="Especialidad Eps: "></asp:Label>
                <asp:TextBox ID="txtespecialidad" placeholder="Especialidad" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtespecialidad" ErrorMessage="Debe ingresar el Nombre de la Especialidad es obligatorio" ForeColor="#CC0066"></asp:RequiredFieldValidator>
            </div>

            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
        </asp:Panel>
    </form>
</body>
</html>

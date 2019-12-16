<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formularioRegistro.aspx.cs" Inherits="Clinica_Caso_Final.formularioRegistro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblLogueado" runat="server"></asp:Label>
        </div>
        <div>
            <div>
                <asp:Label ID="lblNombre" runat="server" Text="Nombre: "></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre" ErrorMessage="Debe ingresar el Nombre " ForeColor="#CC0066"></asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:Label ID="lblApellido" runat="server" Text="Apellido: "></asp:Label>
                <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtApellido" ErrorMessage="Debe ingresar el Apellido" ForeColor="#CC0066"></asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:Label ID="lblCedula" runat="server" Text="Cedula: "></asp:Label>
                <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCedula" ErrorMessage="Debe ingresar su número de documento" ForeColor="#CC0066"></asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:Label ID="lblTelefono" runat="server" Text="Telefono: "></asp:Label>
                <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtTelefono" ErrorMessage="Debe ingresar su número de  Telefono" ForeColor="#CC0066"></asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:Label ID="lblCorreo" runat="server" Text="Correo: "></asp:Label>
                <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCorreo" ErrorMessage="Debe ingresar su Correo " ForeColor="#CC0066"></asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:Label ID="lblClave" runat="server" Text="Clave: "></asp:Label>
                <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtClave" ErrorMessage="Debe ingresar una Clave " ForeColor="#CC0066"></asp:RequiredFieldValidator>
            </div>
            <asp:DropDownList ID="ddlRol" runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrarEPS.aspx.cs" Inherits="Clinica_Caso_Final.Administrador.registrarEPS" %>

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
                <div>
                    <asp:Label ID="lblNit_EPS" runat="server" Text="Nit_Eps: "></asp:Label>
                    <asp:TextBox ID="txtNit_Eps" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNit_Eps" ErrorMessage="Debe ingresar el Nit es obligatorio" ForeColor="#CC0066"></asp:RequiredFieldValidator>

                </div>
                <div>
                    <asp:Label ID="lblNombre_EPS" runat="server" Text="Nombre Eps: "></asp:Label>
                    <asp:TextBox ID="txtNombre_EPS" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNombre_Eps" ErrorMessage="Debe ingresar el Nombre de la Eps es obligatorio" ForeColor="#CC0066"></asp:RequiredFieldValidator>
                </div>
                <div>
                    <asp:Label ID="lblDireccion_Eps" runat="server" Text="Direccion EPS: "></asp:Label>
                    <asp:TextBox ID="txtDireccion_EPS" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDireccion_Eps" ErrorMessage="Debe ingresar la Dirección de la Eps es obligatorio" ForeColor="#CC0066"></asp:RequiredFieldValidator>
                </div>
                <div>
                    <asp:Label ID="lblTelefono_EPS" runat="server" Text="Telefono EPS: "></asp:Label>
                    <asp:TextBox ID="txtTelefono_EPS" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtTelefono_Eps" ErrorMessage="Debe ingresar el Telefono de la Eps es obligatorio" ForeColor="#CC0066"></asp:RequiredFieldValidator>
                </div>

                <div>
                    <asp:Label ID="lblClave" runat="server" Text="Clave: "></asp:Label>
                    <asp:TextBox ID="txtClave_Eps" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtClave_Eps" ErrorMessage="Debe ingresar la Clave de la Eps es obligatorio" ForeColor="#CC0066"></asp:RequiredFieldValidator>
                </div>

            </div>
            <div>
                <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
            </div>
        </asp:Panel>
    </form>
</body>
</html>

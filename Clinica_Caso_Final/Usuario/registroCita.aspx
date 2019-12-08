<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registroCita.aspx.cs" Inherits="Clinica_Caso_Final.EPS.registroCita" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel runat="server">
            <div>
                <h1>Registro Cita</h1>
            </div>
            <div>
                <div>
                    <asp:Label ID="lblFechaCita" runat="server" Text="Fecha Cita: "></asp:Label>
                    <asp:TextBox ID="txtFechaCita" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblCentroMedico" runat="server" Text="Centro Medico: "></asp:Label>
                    <asp:DropDownList ID="ddlCentroMedico" runat="server">
                    </asp:DropDownList>
                </div>
                <div>
                    <asp:Button ID="btnRegistrarCita" runat="server" Text="Registrar" OnClick="BtnRegistrarCita_Click" />
                </div>
            </div>
        </asp:Panel>
    </form>
</body>
</html>

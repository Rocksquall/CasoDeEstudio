<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexAdminsitrador.aspx.cs" Inherits="Clinica_Caso_Final.indexUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Index Usuario</title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <div>
                <div>
                    <asp:Label ID="lblIdCentro" runat="server" Text="ID:"></asp:Label>
                    <asp:TextBox ID="txtIdCentro" runat="server" Enabled="False"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblCentro" runat="server" Text="Nombre Centro Medico: "></asp:Label>
                    <asp:TextBox ID="txtCentro" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblDireccionCentro" runat="server" Text="Direccion: "></asp:Label>
                    <asp:TextBox ID="txtDireccionCentro" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblFotoCentro" runat="server" Text="Foto: "></asp:Label>
                    <asp:TextBox ID="txtFotoCentro" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblHoraInicioCentro" runat="server" Text="Hora Inicio: "></asp:Label>
                    <asp:TextBox ID="txtHoraInicioCentro" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblHoraFinCentro" runat="server" Text="Hora Fin: "></asp:Label>
                    <asp:TextBox ID="txtHoraFinCentro" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblTelefonoCentro" runat="server" Text="Telefono: "></asp:Label>
                    <asp:TextBox ID="txtTelefonoCentro" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblVisitaCentro" runat="server" Text="Visita Centro: "></asp:Label>
                    <asp:TextBox ID="txtVisitaCentro" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblNivelAtencionCentro" runat="server" Text="Nivel Atencion: "></asp:Label>
                    <asp:DropDownList ID="ddlNivelAtencion" runat="server"></asp:DropDownList>
                </div>
                <div>
                    <asp:Label ID="lblEspecialidadCentro" runat="server" Text="Especialidad: "></asp:Label>
                    <asp:DropDownList ID="txtEspecialidadCentro" runat="server" DataSourceID="LinqDataSource2" DataTextField="especialidad" DataValueField="especialidad_idespecialidad"></asp:DropDownList>
                    <asp:LinqDataSource ID="LinqDataSource2" runat="server" ContextTypeName="Modelo.OrmDataContext" EntityTypeName="" TableName="centro_medico">
                    </asp:LinqDataSource>
                </div>
                <div>
                    <asp:Label ID="lblEpsCentro" runat="server" Text="EPS: "></asp:Label>
                    <asp:DropDownList ID="txtEpsCentro" runat="server" DataSourceID="LinqDataSource2" DataTextField="eps" DataValueField="eps_ideps"></asp:DropDownList>
                </div>

            </div>
            <br />
            <asp:Button ID="btn_registro_centro_medico" runat="server" Text="Registrar Centro Medico" />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calificarCentroMedico.aspx.cs" Inherits="Clinica_Caso_Final.Usuario.calificarCentroMedico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="formularioCalificacion" runat="server">
        <asp:Panel ID="pnlConsultaCentro" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Lista Centros Medicos"></asp:Label>
            <asp:GridView ID="glvCentros" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="glvCentros_RowCommand" Width="606px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="idcentro_medico" HeaderText="ID" />
                    <asp:BoundField DataField="nombre_centro" HeaderText="Nombre" />
                    <asp:BoundField DataField="direccion_centro" HeaderText="Apellido" />
                    <asp:BoundField DataField="telefono_centro" HeaderText="Cedula" />
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                            <asp:ImageButton Width="20px" ID="imgActualizar" runat="server" ImageUrl="~/resource/img/editar.png" CommandName="Calificar" />
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </asp:Panel>

        <asp:Panel ID="pnlCalificar" runat="server">
            <asp:Label ID="Label2" runat="server" Text="Calificar Centro Medico"></asp:Label>
            <div>
                <div>
                    <asp:Label ID="lblcentro_medico_idcentro_medico" runat="server" Text="Centro Medico:"></asp:Label>
                    <asp:TextBox ID="txtcentro_medico_idcentro_medico" runat="server" Enabled="False"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblusuario_idusuario" runat="server" Text="Nombre Usuario:"></asp:Label>
                    <asp:TextBox ID="txtusuario_idusuario" runat="server" Enabled="False"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblcalificacion" runat="server" Text="Calificacion:"></asp:Label>
                    <asp:TextBox ID="txtcalificacion" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Button ID="btnCalificar" runat="server" Text="Calificar" OnClick="btnActualizar_Click" />
                </div>
            </div>
        </asp:Panel>


    </form>
</body>
</html>

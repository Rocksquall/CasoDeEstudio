<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editarEPS.aspx.cs" Inherits="Clinica_Caso_Final.indexAdministrador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="formAdministrador" runat="server">

      
         <div>
                         <asp:Panel ID="pnlConsulta" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Lista EPS"></asp:Label>
                <asp:GridView ID="glvEps" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="Black" OnRowCommand="glvEps_RowCommand" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2">
                    <Columns>
                        <asp:BoundField DataField="ideps" HeaderText="ID" />
                        <asp:BoundField DataField="nit_eps" HeaderText="Nit" />
                        <asp:BoundField DataField="nombre_eps" HeaderText="Nombre" />
                        <asp:BoundField DataField="direccion_eps" HeaderText="Direccion" />
                        <asp:BoundField DataField="telefono_eps" HeaderText="Telefono" />
  
                        <asp:TemplateField HeaderText="Acciones">
                            <ItemTemplate>
                                <asp:ImageButton Width="20px" ID="imgActualizar" runat="server" ImageUrl="~/resource/img/editar.png" CommandName="Actualizar" />
                                <asp:ImageButton ID="imgEliminar" runat="server" ImageUrl="~/resource/img/eliminar.png" CommandName="Eliminar" Width="20px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
                             <br />
                             <asp:Panel ID="pnlActualizar" runat="server" Height="237px">
                                 <asp:Label ID="Label2" runat="server" Text="Actualizar Datos"></asp:Label>
                                 <div>
                                     <div>
                                         <asp:Label ID="lblidEps" runat="server" Text="Id:"></asp:Label>
                                         <asp:TextBox ID="txtidEps" runat="server" Enabled="False"></asp:TextBox>
                                     </div>
                                     <div>
                                         <asp:Label ID="lblnitEps" runat="server" Text="Nit:"></asp:Label>
                                         <asp:TextBox ID="txtnitEps" runat="server" Enabled="False"></asp:TextBox>
                                     </div>
                                     <div>
                                         <asp:Label ID="lblNombre_EPS" runat="server" Text="Nombre: "></asp:Label>
                                         <asp:TextBox ID="txtNombre_EPS" runat="server"></asp:TextBox>
                                     </div>
                                     <div>
                                         <asp:Label ID="lblDireccion_EPS" runat="server" Text="Direccion: "></asp:Label>
                                         <asp:TextBox ID="txtDireccion_EPS" runat="server"></asp:TextBox>
                                     </div>
                                     <div>
                                         <asp:Label ID="lblTelefono_EPS" runat="server" Text="Telefono: "></asp:Label>
                                         <asp:TextBox ID="txtTelefono_EPS" runat="server"></asp:TextBox>
                                     </div>
                                     <div>
                                         <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" />
                                     </div>
                                 </div>
                             </asp:Panel>
            </asp:Panel>
           
        </div>
    </form>
</body>
</html>

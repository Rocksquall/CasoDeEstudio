<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="actualizarEpsCentro.aspx.cs" Inherits="Clinica_Caso_Final.EPS.actualizarEps" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
        <div>
            <asp:Panel ID="pnlConsulta" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Lista EPS"></asp:Label>
                <asp:GridView ID="glvCentroMedico" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="Black" OnRowCommand="glvCentroMedico_RowCommand" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2">
                    <Columns>
                        <asp:BoundField DataField="idCentroMedico" HeaderText="ID" />
                        <asp:BoundField DataField="nombre_centro" HeaderText="Centro Medico" />
                        <asp:BoundField DataField="direccion_centro" HeaderText="Direccion" />
                        <asp:BoundField DataField="foto" HeaderText="Foto" />
                        <asp:BoundField DataField="hora_inicio" HeaderText="Hora Inicio" />
                        <asp:BoundField DataField="hora_fin" HeaderText="Hora Fin" />
                        <asp:BoundField DataField="telefono" HeaderText="Telefono" />
                        <asp:BoundField DataField="visita" HeaderText="Visita" />
                        <asp:BoundField DataField="FK_idNivelAtencion" HeaderText="Nivel De Atencion" />
                        <asp:BoundField DataField="FK_idEpecialidad" HeaderText="Especialidad" />
                        <asp:BoundField DataField="FK_idEps" HeaderText="Eps" />

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
            </asp:Panel>
            <asp:Panel ID="pnlActualizar" runat="server" Height="552px">
                <asp:Label ID="Label2" runat="server" Text="Actualizar Datos"></asp:Label>

                <div>
                    <div>
                        <div>
                            <asp:Label ID="lblIdCentroMedico" runat="server" Text="Id Centro Medio: "></asp:Label>
                            <asp:TextBox ID="txtIdCentroMedico" runat="server" Enabled="False" placeholder="ID"></asp:TextBox>
                        </div>
                        <div>
                            <asp:Label ID="lblNombreMedico" runat="server" Text="Nombre Centro Medio: "></asp:Label>
                            <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre Centro Medico"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <asp:Label ID="lblDireccion" runat="server" Text="Direccion: "></asp:Label>
                            <asp:TextBox ID="txtDireccion" runat="server" placeholder="Dirección"></asp:TextBox>
                        </div>
                        <div>
                            <asp:Label ID="lblfoto" runat="server" Text="Foto: "></asp:Label>
                            <asp:FileUpload ID="fudloadImagen" accept=".jpg" runat="server" Width="268px" CssClass="form-control" />
                        </div>
                    </div>
                    <br />
                    <div>
                        <div>
                            <asp:Image ID="VisualizarImg" runat="server" CssClass="form-control" Height="215px" Style="margin-top: 11px" Width="297px" />
                        </div>
                    </div>
                    <br />
                    <div>
                        <div>
                            <asp:Label ID="lblHoraInicio" runat="server" Text="Hora Inicio"></asp:Label>
                            <asp:TextBox ID="txtHoraInicio" runat="server" placeholder="Hora Inicio"></asp:TextBox>
                        </div>
                        <div>
                            <asp:Label ID="lblHoraFin" runat="server" Text="Hora Fin"></asp:Label>
                            <asp:TextBox ID="txtHoraFin" runat="server" placeholder="Hora Fin"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div>
                            <asp:Label ID="lblTelefono" runat="server" Text="Telefono"></asp:Label>
                            <asp:TextBox ID="txttelefono" runat="server" placeholder="Telefono"></asp:TextBox>
                        </div>
                        <div>
                            <asp:Label ID="lblVisita" runat="server" Text="Visita"></asp:Label>
                            <asp:TextBox ID="txtVisita" runat="server" placeholder="Visita"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                    <div>
                        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
                    </div>
                </div>
            </asp:Panel>
        </div>
    </form>
</body>
</html>

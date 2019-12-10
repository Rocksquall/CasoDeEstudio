<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="actualizarEpsCentroMedico.aspx.cs" Inherits="Clinica_Caso_Final.EPS.actualizarEpsCentroMedico" %>

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
                        <asp:BoundField DataField="idcentro_medico" HeaderText="ID: " />
                        <asp:BoundField DataField="nombre_centro" HeaderText="Nombre Centro: " />
                        <asp:BoundField DataField="direccion_centro" HeaderText="Direccion: " />
                        <asp:BoundField DataField="foto_centro" HeaderText="Foto: " />
                        <asp:BoundField DataField="hora_inicio" HeaderText="Hora Inicio: " />
                        <asp:BoundField DataField="hora_fin" HeaderText="Hora Fin: " />
                        <asp:BoundField DataField="telefono_centro" HeaderText="Telefono: " />
                        <asp:BoundField DataField="visita_centro" HeaderText="Horario Visita: " />
                        <asp:BoundField DataField="nivel_atencion_idnivel_atencion" HeaderText="Nivel de Atencion: " />
                        <asp:BoundField DataField="especialidad_idespecialidad" HeaderText="Especialidad: " />
                        <asp:BoundField DataField="eps_ideps" HeaderText="Eps: " />
  
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
            <asp:Panel ID="pnlActualizar" runat="server" Height="237px">
                <asp:Label ID="Label2" runat="server" Text="Actualizar Datos"></asp:Label>
                <div>
                     <div>
                        <asp:Label ID="lblidcentro_medico" runat="server" Text="Id: "></asp:Label>
                        <asp:TextBox ID="txtidcentro_medico" runat="server" Enabled="False"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="lblnombre_centro" runat="server" Text="Nombre: "></asp:Label>
                        <asp:TextBox ID="txtnombre_centro" runat="server" Enabled="False"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="lbldireccion_centro" runat="server" Text="Direccion: "></asp:Label>
                        <asp:TextBox ID="txtdireccion_centro" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="lblfoto_centro" runat="server" Text="Foto: "></asp:Label>
                        <asp:TextBox ID="txtfoto_centro" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="lblhora_inicio" runat="server" Text="Hora Inicio: "></asp:Label>
                        <asp:TextBox ID="txthora_inicio" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="lblhora_fin" runat="server" Text="Hora Fin: "></asp:Label>
                        <asp:TextBox ID="txthora_fin" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="lbltelefono_centro" runat="server" Text="Telefono: "></asp:Label>
                        <asp:TextBox ID="txttelefono_centro" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="lblvisita_centro" runat="server" Text="Visita: "></asp:Label>
                        <asp:TextBox ID="txtvisita_centro" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="lblnivel_atencion_idnivel_atencion" runat="server" Text="Nivel de Atencion: "></asp:Label>
                        <asp:DropDownList ID="ddlNivelAtencion" runat="server"></asp:DropDownList>
                    </div>
                    <div>
                        <asp:Label ID="lblespecialidad_idespecialidad" runat="server" Text="Especialidad: "></asp:Label>
                        <asp:DropDownList ID="ddlEspecialidad" runat="server"></asp:DropDownList>
                    </div>
                    <div>
                        <asp:Label ID="lbleps_ideps" runat="server" Text="Eps: "></asp:Label>
                        <asp:DropDownList ID="ddlEps" runat="server"></asp:DropDownList>
                    </div>
                    <div>
                        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
                    </div>
                </div>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
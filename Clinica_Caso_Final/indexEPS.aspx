<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexEPS.aspx.cs" Inherits="Clinica_Caso_Final.indexUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Index Usuario</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btn_registro_centro" runat="server" Text="Registrar Centro Medico" />

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="idcentro_medico" DataSourceID="EPS_centros">
                <Columns>
                    <asp:BoundField DataField="idcentro_medico" HeaderText="idcentro_medico" InsertVisible="False" ReadOnly="True" SortExpression="idcentro_medico" />
                    <asp:BoundField DataField="nombre_centro" HeaderText="nombre_centro" SortExpression="nombre_centro" />
                    <asp:BoundField DataField="direccion_centro" HeaderText="direccion_centro" SortExpression="direccion_centro" />
                    <asp:BoundField DataField="foto_centro" HeaderText="foto_centro" SortExpression="foto_centro" />
                    <asp:BoundField DataField="hora_inicio" HeaderText="hora_inicio" SortExpression="hora_inicio" />
                    <asp:BoundField DataField="hora_fin" HeaderText="hora_fin" SortExpression="hora_fin" />
                    <asp:BoundField DataField="telefono_centro" HeaderText="telefono_centro" SortExpression="telefono_centro" />
                    <asp:BoundField DataField="visita_centro" HeaderText="visita_centro" SortExpression="visita_centro" />
                    <asp:BoundField DataField="nivel_atencion_idnivel_atencion" HeaderText="nivel_atencion_idnivel_atencion" SortExpression="nivel_atencion_idnivel_atencion" />
                    <asp:BoundField DataField="especialidad_idespecialidad" HeaderText="especialidad_idespecialidad" SortExpression="especialidad_idespecialidad" />
                    <asp:BoundField DataField="eps_ideps" HeaderText="eps_ideps" SortExpression="eps_ideps" />
                </Columns>
            </asp:GridView>
            <asp:LinqDataSource ID="EPS_centros" runat="server" ContextTypeName="Modelo.OrmDataContext" EntityTypeName="" TableName="centro_medico">
            </asp:LinqDataSource>
        </div>

            <asp:Panel ID="pnlConsulta" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Lista Centros Medicos"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnlActualizar" runat="server">
                <asp:Label ID="Label2" runat="server" Text="Actualizar Datos"></asp:Label>
                <div>
                    <div>
                        <asp:Label ID="lblIdUsuario" runat="server" Text="ID:"></asp:Label>
                        <asp:TextBox ID="txtIdUsuario" runat="server" Enabled="False"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="lblNombre" runat="server" Text="Nombre: "></asp:Label>
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="lblApellido" runat="server" Text="Apellido: "></asp:Label>
                        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="lblCedula" runat="server" Text="Cedula: "></asp:Label>
                        <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="lblTelefono" runat="server" Text="Telefono: "></asp:Label>
                        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="lblCorreo" runat="server" Text="Correo: "></asp:Label>
                        <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
                    </div>  
                    <div>
                        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
                    </div>
                </div>
            </asp:Panel>
    </form>
</body>
</html>

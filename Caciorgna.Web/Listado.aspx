<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="Caciorgna.Web.Listado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
&nbsp;&nbsp;&nbsp;Todas las personas<br />
            <asp:GridView ID="dgvListado1" runat="server" AutoGenerateColumns="False" DataSourceID="odsGrillaTodasPersonas">
                <Columns>
                    <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                    <asp:BoundField DataField="FechaNacimiento" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                    <asp:BoundField DataField="Tipo_Persona" HeaderText="Tipo_Persona" SortExpression="Tipo_Persona" />
                </Columns>
            </asp:GridView>
        </div>
        <asp:ObjectDataSource ID="odsGrillaTodasPersonas" runat="server" SelectMethod="RecuperarTodos" TypeName="Caciorgna.Datos.Persona"></asp:ObjectDataSource>
        <br />
        <br />
        Personas filtradas por tipo de persona<br />
            <asp:DropDownList ID="ddlTipoPersona" runat="server">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnRecuperar" runat="server" OnClick="btnRecuperar_Click" Text="Recuperar" />
            <br />
        <asp:GridView ID="dgvListado2" runat="server" AutoGenerateColumns="False" DataSourceID="odsGrillaPorTipoPersona">
            <Columns>
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="FechaNacimiento" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Tipo_Persona" HeaderText="Tipo_Persona" SortExpression="Tipo_Persona" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="odsGrillaPorTipoPersona" runat="server" SelectMethod="RecuperarPorTipoPersona" TypeName="Caciorgna.Negocio.Persona">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlTipoPersona" Name="idTipoPersona" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </form>
</body>
</html>

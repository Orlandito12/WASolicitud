<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CURegistroSolicitud.ascx.cs" Inherits="WASolicitud.Controles.Formulario.CURegistroSolicitud" %>
<asp:Panel ID="PanelRegistroSolicitud" runat="server">
    <fieldset>
        <legend>Registro de Solicitud</legend>
        <asp:Label ID="LabelFechaSolicitud" runat="server" Text="Fecha de Solicitud:" AssociatedControlID="txtFechaSolicitud"></asp:Label>
        <asp:TextBox ID="txtFechaSolicitud" runat="server" TextMode="Date"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFechaSolicitud" runat="server" ControlToValidate="txtFechaSolicitud" ErrorMessage="La fecha es requerida" ForeColor="Red" />
        <br />
        <asp:RequiredFieldValidator ID="RequiredTipoSolicitud" runat="server" ControlToValidate="ddlTipoSolicitud" ErrorMessage="El tipo de solicitud es requerido" ForeColor="Red" />
        <br />

        <asp:Label ID="LabelEstado" runat="server" Text="Estado:" AssociatedControlID="txtEstado"></asp:Label>
        <asp:TextBox ID="txtEstado" runat="server" />
        <asp:RequiredFieldValidator ID="RequiredEstado" runat="server" ControlToValidate="txtEstado" ErrorMessage="El estado es requerido" ForeColor="Red" />
        <br />


        <asp:Button ID="btnRegistrarSolicitud" runat="server" Text="Registrar Solicitud" OnClick="btnRegistrarSolicitud_Click" />
    </fieldset>
</asp:Panel>
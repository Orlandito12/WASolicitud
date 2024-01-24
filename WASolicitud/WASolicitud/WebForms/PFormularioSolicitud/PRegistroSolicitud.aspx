<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PRegistroSolicitud.aspx.cs" Inherits="WASolicitud.WebForms.PFormularioSolicitud.PRegistroSolicitud" %>
<%@ Register Src="~/Controles/CURegistroSolicitud.ascx" TagPrefix="uc" TagName="RegistroSolicitud" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro de Solicitud</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc:RegistroSolicitud runat="server" ID="CURegistroSolicitud" />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Video>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>DanArzolaDetails</title>
    <style type="text/css">
        .style1
        {
            font-family: lazer84;
            font-size: large;
        }
        .style2
        {
            font-family: lazer84;
            font-size: 50pt;
            text-align: center;
        }
        .style3
        {
            font-family: lazer84;
            font-size: x-large;
        }
        .style4
        {
            font-size: x-large;
        }
    </style>
</head>
<body background="../../Content/images/bgDetails.jpg">

    <fieldset style="color: #FFFF00; font-family: lazer84">
        <legend class="style2">DETALLES</legend>
        
        <div class="style3">Id Video<br />
        </div>
        <div class="style1"><%: Model.IdVideo %></div>
        <br />
        <div class="style1"><span class="style4">Nom b r e</span><br />
        </div>
        <div class="style1"><%: Model.Nombre %></div>
        <br />
        <div class="style1"><span class="style4">U r l&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <img alt="start" src="https://un-defined.hotglue.me/?start.head.156825781149" 
                style="height: 139px; width: 174px; float: right" /></span><br />
        </div>
        <div class="style1"><%: Model.Url %></div>
        <br />
        <div class="style1"><span class="style4">Fecha&nbsp; Publicacion</span><br />
        </div>
        <div class="style1"><%: String.Format("{0:g}", Model.FechaPublicacion) %></div>
        
    </fieldset>
    <p style="font-family: 'Death Star'; font-size: large; color: #FFFFFF">
        <span class="style1">
        <%: Html.ActionLink("Edit", "DanArzolagaEdit", new { id=Model.IdVideo }) %> 
        </span>|
        <%: Html.ActionLink("Regresar", "DanArzolaga") %>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>

</body>
</html>


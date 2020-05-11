<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Video>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>DanArzolaga</title>
    <style type="text/css">
        .style1
        {
            font-size: 70pt;
            font-family: Arcade;
            font-weight: normal;
            text-align: center;
        }
        .style3
        {
            width: 330px;
        }
        .style4
        {
            width: 115px;
        }
        .style5
        {
            font-size: small;
        }
        .style6
        {
            width: 115px;
            font-size: small;
            text-align: center;
        }
        .style9
        {
            width: 405px;
        }
        .style11
        {
            width: 405px;
            text-align: center;
        }
        .style13
        {
            width: 368px;
        }
        .style14
        {
            width: 368px;
            text-align: center;
        }
        .style15
        {
            width: 371px;
        }
        .style16
        {
            width: 371px;
            text-align: center;
        }
        .style17
        {
            font-family: "Karmatic Arcade";
        }
        .style18
        {
            font-size: medium;
        }
        .style19
        {
            color: #FFFFFF;
        }
        .style20
        {
            font-family: "Karmatic Arcade";
            font-size: medium;
            color: #FFFFFF;
        }
    </style>
</head>
<body background="../../Content/images/bgVideo.png">
<a href="/Persona/DanArzolaga">&nbsp;<span class="style20">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Regresar</span></a>
    <h1 class="style1" style="color: #C6CBF5">LISTA DE VIDEOS</h1>
    <p>
    <img src="../../Content/images/steven.png" style="margin-left: 557px" /></p>
&nbsp;
        
     
     <span class="style17"><span class="style18"><span class="style19">&nbsp;<%: Html.ActionLink("Agregar Video", "Create") %></span></span></span>
    <table style="font-family: lazer84; font-size: medium; color: #FFFF00; border-style: groove; border-color: #C0C0C0; font-weight: normal; border-collapse: separate; border-spacing: inherit;" 
        title="Videos">
        <tr>
            <th class="style3"></th>
            <th class="style4">
                Id Video
            </th>
            <th class="style13">
                Nombre
            </th>
            <th class="style15">
                Url
            </th>
            <th class="style9">
                Fecha&nbsp; Publicacion
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td class="style3">
                <%: Html.ActionLink("Editar", "Edit", new { id=item.IdVideo }) %> |
                <%: Html.ActionLink("Detalle", "Details", new { id=item.IdVideo })%> |
                <%: Html.ActionLink("Borrar", "Delete", new { id=item.IdVideo })%>
            </td>
            <td style="font-family: Consolas; font-weight: bold; color: #FFFFFF" 
                class="style6">
                <span class="style5">
                <%: item.IdVideo %>
            </td>
            <td style="font-family: Consolas; font-weight: bold; color: #FFFFFF" 
                class="style14">
                <%: item.Nombre %>
            </td>
            <td style="font-family: Consolas; font-weight: bold; color: #FFFFFF" 
                class="style16">
                <%: item.Url %>
            </td>
            <td style="font-family: Consolas; font-weight: bold; color: #FFFFFF" 
                class="style11">
                <%: String.Format("{0:g}", item.FechaPublicacion) %>
                </span>
            </td>
        </tr>
    
    <% } %>

    </table>



</body>
</html>


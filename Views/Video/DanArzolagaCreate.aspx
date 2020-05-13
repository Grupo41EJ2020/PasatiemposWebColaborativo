<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Video>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>DanArzolagaCreate</title>
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
        .style3
        {
            font-size: x-large;
        }
        .style4
        {
            text-align: center;
            font-size: x-large;
        }
    </style>
</head>
<body background="../../Content/images/bgCreate.jpg">
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset style="font-family: 'ENDLESS BUMMER'; color: #DA2C43; font-size: medium">
            <legend style="text-align: center; font-size: 40pt">Datos del Video&nbsp;
                <img alt="Sticker GIF | Gfycat" 
                    src="https://thumbs.gfycat.com/UniformFluffyCrownofthornsstarfish-small.gif" 
                    style="height: 159px; width: 250px" /></legend>
            
            <div class="style4">
                <%: Html.LabelFor(model => model.IdVideo) %>
            </div>
            <span class="style3">
            <div class="style1">
                <%: Html.TextBoxFor(model => model.IdVideo) %>
                <%: Html.ValidationMessageFor(model => model.IdVideo) %>
            </div>
            
            <div class="style1">
                <%: Html.LabelFor(model => model.Nombre) %>
            </div>
            <div class="style1">
                <%: Html.TextBoxFor(model => model.Nombre) %>
                <%: Html.ValidationMessageFor(model => model.Nombre) %>
            </div>
            
            <div class="style1">
                <%: Html.LabelFor(model => model.Url) %>
            </div>
            <div class="style1">
                <%: Html.TextBoxFor(model => model.Url) %>
                <%: Html.ValidationMessageFor(model => model.Url) %>
            </div>
            
            <div class="style1">
                <%: Html.LabelFor(model => model.FechaPublicacion) %>
            </div>
            <div class="style1">
                <%: Html.TextBoxFor(model => model.FechaPublicacion) %>
                <%: Html.ValidationMessageFor(model => model.FechaPublicacion) %>
                </span>
            </div>
            
            <p>
                <input type="submit" value="Create" start="fileopen" 
                    style="color: #FFFFFF; text-transform: lowercase; font-weight: bold; font-family: Consolas; background-color: #0033CC;" />
            </p>
        </fieldset>

    <% } %>

    <div style="font-family: Abduction2000; font-size: x-large; font-weight: 700; color: #FFFFFF">
        <%: Html.ActionLink("Regresar", "DanArzolaga") %>
    </div>

</body>
</html>


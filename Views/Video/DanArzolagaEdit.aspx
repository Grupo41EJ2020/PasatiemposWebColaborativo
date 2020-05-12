<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Video>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>DanArzolagaEdit</title>
    <style type="text/css">
        .editor-label
        {
            width: 839px;
        }
        .editor-field
        {
            width: 989px;
            text-align: center;
            margin-top: 0px;
        }
        .style1
        {
            width: 989px;
            text-align: center;
        }
    </style>
</head>
<body background="../../Content/images/bgEdit.jpg">
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset style="font-family: Arcade; font-size: xx-large; color: #FFFFFF">
            <legend style="text-align: center; font-size: 40pt">Datos del Video</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.IdVideo) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.IdVideo) %>
                <%: Html.ValidationMessageFor(model => model.IdVideo) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Nombre) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Nombre) %>
                <%: Html.ValidationMessageFor(model => model.Nombre) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Url) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Url) %>
                <%: Html.ValidationMessageFor(model => model.Url) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.FechaPublicacion) %>
            </div>
            <div class="style1">
                <%: Html.TextBoxFor(model => model.FechaPublicacion, String.Format("{0:g}", Model.FechaPublicacion)) %>
                <%: Html.ValidationMessageFor(model => model.FechaPublicacion) %>
            </div>
            
            <p style="font-family: Consolas">
                <input type="submit" value="Guardar" 
                    style="font-family: Consolas; font-size: medium; font-weight: 700" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <img alt="Retro Unusual Clipart Gif Jpg Png| (50)++ Amazing Cliparts #RUCGJP ..." 
                    src="https://bestanimations.com/Computers/funny-computer-animated-gif-29.gif" 
                    style="height: 176px; width: 174px" /></p>
        </fieldset>

    <% } %>

    <div style="font-family: Consolas; font-size: large; font-weight: 700">
        <%: Html.ActionLink("Regresar", "DanArzolaga") %>
    </div>

</body>
</html>


<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Video>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

    }
</script>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>DanArzolagaDelete</title>
    <style type="text/css">
        .display-field
        {
            font-family: Consolas;
        }
        .style1
        {
            font-family: "Karmatic Arcade";
        }
        .style2
        {
            width: 163px;
            height: 145px;
        }
        .style3
        {
            font-size: x-large;
        }
    </style>
</head>
<body bgcolor="#000000" style="color: #FFD12A">
    <h3 class="style1">¿Estas seguro que quieres eliminar esto?</h3>
    <fieldset style="font-family: 'Karmatic Arcade'; font-size: x-large">
        <legend style="text-align: center; font-size: 40pt">&nbsp;Datos del Video<img 
                alt="fantasma" class="style2" src="../../Content/images/ghost.gif" /><br />
        </legend>
        
        <div class="display-label">Id Video</div>
        <div class="display-field"><%: Model.IdVideo %></div>
        
        <div class="display-label">Nombre</div>
        <div class="display-field"><%: Model.Nombre %></div>
        
        <div class="display-label">Url</div>
        <div class="display-field"><%: Model.Url %></div>
        
        <div class="display-label">Fecha Publicacion</div>
        <div class="display-field"><%: String.Format("{0:g}", Model.FechaPublicacion) %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p style="font-family: Arcade; color: #FFFFFF; font-size: medium">
		    <input type="submit" value="Eliminar" 
                
                style="font-weight: 700; font-family: Consolas; font-size: medium; background-color: #FFFF00;" /> |
		    <span class="style3">&nbsp;&nbsp;
		    <%: Html.ActionLink("Regresar", "DanArzolaga") %>
            </span>
        </p>
    <% } %>

</body>
</html>


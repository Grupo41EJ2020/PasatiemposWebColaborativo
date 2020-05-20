<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Video>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Crear nuevo video</title>
</head>
<body>
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Datos</legend>
            
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
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.FechaPublicacion) %>
                <%: Html.ValidationMessageFor(model => model.FechaPublicacion) %>
            </div>
            
            <p>
                <input type="submit" value="Crear video" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar a la lista", "danielamaldonadognz")%>
    </div>

</body>
</html>


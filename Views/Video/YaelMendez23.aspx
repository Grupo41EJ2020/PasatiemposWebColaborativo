<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Video>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Lista de Videos de: YaelMendez23</title>
</head>
<body>
    <table>
        <tr>
            <th></th>
            <th>
                IdVideo
            </th>
            <th>
                Nombre
            </th>
            <th>
                Url
            </th>
            <th>
                FechaPublicacion
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    7
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new {  id=item.IdVideo }) %> 
                <%: Html.ActionLink("Ver Detalles", "Details", new {  id=item.IdVideo  })%> 
                <%: Html.ActionLink("Borrar", "Delete", new { id=item.IdVideo })%>
            </td>
            <td>
                <%: item.IdVideo %>
            </td>
            <td>
                <%: item.Nombre %>
            </td>
            <td>
                <%: item.Url %>
            </td>
            <td>
                <%: String.Format("{0:g}", item.FechaPublicacion) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Crear Nuevo Video", "Create") %>
    </p>

</body>
</html>


<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Video>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title> Lista de Videos de jenniferhdzf</title>
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
               
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "jenniferhdzfEdit", new { id = item.IdVideo })%> |
                <%: Html.ActionLink("Detalles", "jenniferhdzfDetails", new { id = item.IdVideo })%> |
                <%: Html.ActionLink("Eliminar", "jenniferhdzDelete", new { id = item.IdVideo })%>
            </td>
            <td>
                <%: item.IdVideo %>
            </td>
            <td>
                <%: item.Nombre %>
            </td>
            <td>
              
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Crear Nuevo", "Create") %>
    </p>

</body>
</html>


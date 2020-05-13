<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Video>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Lista de Videos de: LIIGabriel</title>
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

                        

            
        </tr>

    <% foreach (var item in Model) { %>
    
        <td>
            <td>
                <%: Html.ActionLink("Editar", "LIIGabrielEdit", new { id=item.IdVideo  }) %> |
                <%: Html.ActionLink("Ver detalles", "LIIGabrielDetails", new {  id=item.IdVideo })%> |
                <%: Html.ActionLink("Borrar", "LIIGabrielDelete", new {  id=item.IdVideo  })%>
            </td>
            <td>
                <%: item.IdVideo %>
            </td>
            <td>
                <%: item.Nombre %>

            </td>
            </td>                        
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Crear Nuevo Video", "Create") %>
    </p>

</body>
</html>


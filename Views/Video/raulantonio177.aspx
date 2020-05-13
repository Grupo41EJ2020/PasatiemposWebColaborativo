<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Video>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>raulantonio177</title>
     <style type="text/css">
    table, th, td
    {
        border: 1px solid white;
    }
    table
    {
        border-collapse: collapse;
        font-family: Arial;
        font-size: 14px;
    }
    th
    {
        background-color: #064E97;
        color: white;
        text-transform: uppercase;
    }
    th, td 
    {
        border-bottom: 1px solid #ddd;
    }
    tr:hover {background-color: #f5f5f5;}
    </style>
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
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "raulantonio177Edit", new { id = item.IdVideo })%> |
                <%: Html.ActionLink("Detalles", "raulantonio177Detalles", new { id = item.IdVideo })%> |
                <%: Html.ActionLink("Delete", "raulantonio177Delete", new { id = item.IdVideo })%>
            </td>
            <td>
                <%: item.IdVideo %>
            </td>
            <td>
                <%: item.Nombre %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
        <a href="/Persona/raulantonio177">Regresar a pasatiempos</a>
    </p>

</body>
</html>


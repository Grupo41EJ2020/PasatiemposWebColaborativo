<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Video>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>JonathanVazquez</title>
    <style>
        *
        {
            margin: 0;
            padding: 0;
            font-family: consolas;
            box-sizing: border-box;
            }
            body
            {
                background: #050801;
                font-family: arial;
                }
                body,html
                {
                    height: 100%;
                    margin: 0;
			        font-size: 16px;
			        font-family: "Lato", sans-serif;
			        font-weight: 400;
			        line-height: 1.8em;
			        color: #666;
			        }
			        a
			        {
			            position: relative;
 	                    display: inline-block;
 	                    padding: 25px 30px;
 	                    margin: 40px 0;
 	                    color: #03e9f4;
 	                    font-size: 24px;
 	                    text-decoration: none;
 	                    text-transform: uppercase;
 	                    overflow: hidden;
 	                    transition: 0.5s;
 	                    letter-spacing: 4px;
 	                    -webkit-box-reflect:below 1px linear-gradient(transparent, #0005);
 	                    }
 	                     a:nth-child(2)
 	                     {
 	                        filter: hue-rotate(290deg);
                            }
                            a:nth-child(3)
                            {
 	                            filter: hue-rotate(110deg);
                            }
 	                        a:hover
 	                        {
 	                            background: #03e9f4;
 	                            color: #050801;
 	                            box-shadow: 0 0 5px #03e9f4,
 				                            0 0 25px #03e9f4,
 				                            0 0 50px #03e9f4,
 				                               0 0 200px #03e9f4;
 				                               }
 				                               a span
 				                               {
 				                                   position: absolute;
 	                                               display: block;
 	                                               }
 	                                               a span:nth-child(1)
 	                                               {
 	                                                   top: 0;
 	                                                   left: -100%;
 	                                                   width: 100%;
 	                                                   height: 2px;
 	                                                   background: linear-gradient(90deg,transparent, #03e9f4);
 	                                                   animation: animate1 1s linear infinite;
 	                                                   }
 	                                                   @keyframes animate1
 	                                                   {
 	                                                       0%
 	                                                       {
 	                                                       left: -100%;
 	                                                       }
 	                                                       50%, 100%
 	                                                       {
 	                                                           left: 100%;
 	                                                           }
 	                                                           }
 	                                                           a span:nth-child(2)
 	                                                           {
 	                                                               top: -100;
 	                                                               right: 0;
 	                                                               width: 2px;
 	                                                               height: 100%;
 	                                                               background: linear-gradient(180deg,transparent, #03e9f4);
 	                                                               animation: animate2 1s linear infinite;
 	                                                               animation-delay: 0.25s;
 	                                                               }
 	                                                               @keyframes animate2
 	                                                               {
 	                                                                   0%
 	                                                                   {
 	                                                                   top: -100%;
 	                                                                   }
 	                                                                   50%, 100%
 	                                                                   {
 	                                                                       top: 100%;
 	                                                                       }
 	                                                                       }
 	                                                                       a span:nth-child(3)
 	                                                                       {
 	                                                                           bottom: 0;
 	                                                                           right: -100%;
 	                                                                           width: 100%;
 	                                                                           height: 2px;
 	                                                                           background: linear-gradient(270deg,transparent, #03e9f4);
 	                                                                           animation: animate3 1s linear infinite;
 	                                                                           animation-delay: 0.5s;
 	                                                                           }
 	                                                                           @keyframes animate3
 	                                                                           {
 	                                                                               0%
 	                                                                               {
 	                                                                               right: -100%;
 	                                                                               }
 	                                                                               50%, 100%
 	                                                                               {
 	                                                                                   right: 100%;
 	                                                                                   }
 	                                                                                   }
 	                                                                                   a span:nth-child(4)
 	                                                                                   {
 	                                                                                       bottom: -100%;
 	                                                                                       left: 0;
 	                                                                                       width: 2px;
 	                                                                                       height: 100%;
 	                                                                                       background: linear-gradient(360deg,transparent, #03e9f4);
 	                                                                                       animation: animate4 1s linear infinite;
 	                                                                                       animation-delay: 0.75s;
 	                                                                                       }
 	                                                                                       @keyframes animate4
 	                                                                                       {
 	                                                                                           0%
 	                                                                                           {
 	                                                                                           bottom: -100%;
 	                                                                                           }
 	                                                                                           50%, 100%
 	                                                                                           {
 	                                                                                               bottom: 100%;
 	                                                                                               }
 	                                                                                               }
 	                                                                                               .pimg1
 	                                                                                               {
 	                                                                                                   position:relative;
			                                                                                           opacity: 0.70;
			                                                                                           background-position: center;
			                                                                                           background-size: cover;
			                                                                                           background-repeat: no-repeat;
			                                                                                           background-attachment: fixed;
			                                                                                           }
			                                                                                           .pimg1
			                                                                                           {
			                                                                                               background-image: url('https://elandroidelibre.elespanol.com/wp-content/uploads/2014/08/wallpaper-2941175.jpg');
			                                                                                               min-height: 100%;
			                                                                                               }
			                                                                                               .menu
			                                                                                               {
			                                                                                                   padding: 10px 20px;
			                                                                                                   }
			                                                                                                   .section
			                                                                                                   {
			                                                                                                       text-align: center;
			                                                                                                       padding: 25px 40px;
			                                                                                                       }
			                                                                                                       .section-dark
			                                                                                                       {
			                                                                                                           background-color: #282e34;
			                                                                                                           color:#ddd;
			                                                                                                           }
			                                                                                                           .ptext
			                                                                                                           {
			                                                                                                               position: absolute;
			                                                                                                               top: 50%;
			                                                                                                               width: 100%;
			                                                                                                               text-align: center;
			                                                                                                               color: #000;
			                                                                                                               font-size: 27px;
			                                                                                                               letter-spacing: 8px;
			                                                                                                               text-transform: uppercase;
			                                                                                                               }
			                                                                                                               .ptext .border
			                                                                                                               {
			                                                                                                                   background-color: #111;
			                                                                                                                   color: #fff;
			                                                                                                                   padding: 20px;
			                                                                                                                   }
			                                                                                                                   .ptext .border .trans
			                                                                                                                   {
			                                                                                                                       background-color: transparent;
			                                                                                                                       }
			                                                                                                                       #main-container
			                                                                                                                       {
			                                                                                                                           margin: 150px auto;
			                                                                                                                           width:  600px;
			                                                                                                                           }
			                                                                                                                           #main-container
			                                                                                                                           {
			                                                                                                                               margin: 150px auto;
			                                                                                                                               width:  600px;
			                                                                                                                               }
			                                                                                                                               table
			                                                                                                                               {
			                                                                                                                                   background-color: white;
			                                                                                                                                   text-align: left;
			                                                                                                                                   border-collapse: collapse;
			                                                                                                                                   width: 100%; 
			                                                                                                                                   }
			                                                                                                                                   th, td
			                                                                                                                                   {
			                                                                                                                                       border: solid 1px black;
			                                                                                                                                       }
			                                                                                                                                       thead
			                                                                                                                                       {
			                                                                                                                                           background-color: #246355;
			                                                                                                                                           border-bottom: solid 5px #0F362D;
			                                                                                                                                           color: white;
			                                                                                                                                           }
			                                                                                                                                           tr:nth-child(even)
			                                                                                                                                           {
			                                                                                                                                               background-color: #ddd;
			                                                                                                                                               }
			                                                                                                                                               tr:hover
			                                                                                                                                               {
			                                                                                                                                                   background-color: #369681;
			                                                                                                                                                   color: white;
			                                                                                                                                                   }
			                                                                                                                                                   </style>
</head>
<body>
<a href="/Persona/JonathanVazquez">
		<span></span>
		<span></span>
		<span></span>
		<span></span>
		Regresar
	</a>
	<div class="pimg1">
		<div class="ptext">
			<span class="border">
				Videos
			</span>
		</div>
	</div>
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
                FechaPublicacion
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "JonathanVBEdit", new { id=item.IdVideo  }) %> |
                <%: Html.ActionLink("Ver detalles", "JonathanVazquezDetails", new {  id=item.IdVideo })%> |
                <%: Html.ActionLink("Borrar", "JonathanVBDelete", new {  id=item.IdVideo  })%>
            </td>
            <td>
                <%: item.IdVideo %>
            </td>
            <td>
                <%: item.Nombre %>
            </td>
            <td>
                <%: String.Format("{0:g}", item.FechaPublicacion) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Crear nuevo video", "Create") %>
    </p>
    </br>
</body>
</html>


﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Edalmaj</title>
    <link href="../../Content/Site.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        body 
        {
            background-color:#191919;
            padding-left:10%;
            padding-right:10%;
        }

        h1
        {
            font-size:50px;
        }

        h1, h2, ul
        {
            font-family:Arial;
            color:#F9F9F9;
        }

        a 
        {
            font-family:Arial;
            color:White;
        }
    </style>
</head>
<body>
    <h1>Pasatiempos de Edalmaj</h1>
    <h2>Estar en la computadora</h2>
    <ul>
        <li>Ver videos</li>
        <li>Escuchar Música</li>
        <li>Jugar LoL</li>
    </ul>
    <h2>Canción Favorita</h2>
    <iframe width="560" height="315" src="https://www.youtube.com/embed/u6lihZAcy4s"
     frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; 
     picture-in-picture" allowfullscreen></iframe>
     <br />
    <a href="/Video/Edalmaj">Ver Videos</a>
    <br />
     <a href="/Persona/Index">Regresar</a>
</body>
</html>

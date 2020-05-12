<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>JonathanVazquez</title>
    <style>
		body,html{
			height: 100%;
			margin: 0;
			font-size: 16px;
			font-family: "Lato", sans-serif;
			font-weight: 400;
			line-height: 1.8em;
			color: #666;
		}
		.pimg1, .pimg2, .pimg3, .pimg4{
			position:relative;
			opacity: 0.70;
			background-position: center;
			background-size: cover;
			background-repeat: no-repeat;
			background-attachment: fixed;
		}
		.pimg1{
			background-image: url('https://get.wallhere.com/photo/new-york-skyscrapers-buildings-city-685670.jpg');
			min-height: 100%;
		}
		.pimg2{
			background-image: url('https://i.ytimg.com/vi/_QoZDC8fFEI/maxresdefault.jpg');
			min-height: 400px;
		}
		.pimg3{
			background-image: url('https://i.ytimg.com/vi/4TJ9Bzj_EnA/maxresdefault.jpg');
			min-height: 400px;
		}
		.pimg4{
			background-image: url('https://economyclassandbeyond.boardingarea.com/wp-content/uploads/2017/06/K66688-07-MAX-10.jpg');
			min-height: 100%;
		}
		.section{
			text-align: center;
			padding: 50px 80px;
		}
		.section-dark{
			background-color: #282e34;
			color:#ddd;
		}
		.ptext{
			position: absolute;
			top: 50%;
			width: 100%;
			text-align: center;
			color: #000;
			font-size: 27px;
			letter-spacing: 8px;
			text-transform: uppercase;
		}
		.ptext .border{
			background-color: #111;
			color: #fff;
			padding: 20px;
		}
		.ptext .border .trans{
			background-color: transparent;
		}
	</style>
</head>
<body>
   <div class="pimg1">
		<div class="ptext">
			<span class="border">
				Mis Pasatiempos
			</span>
		</div>
	</div>
	<section class="section section-dark">
		<p>Jonathan Yair Vazquez Buenrostro</p>
	</section>

	<div class="pimg2">
		<div class="ptext">
			<span class="border">
				League of legends
			</span>
		</div>
	</div>
	<section class="section section-dark">
		<p>Me gusta jugar league of legends, actualmente soy platino usando solo a shen</p>
	</section>

	<div class="pimg3">
		<div class="ptext">
			<span class="border">
				Electronica
			</span>
		</div>
	</div>
	<section class="section section-dark">
		<p>Me gusta la musica, escucho de todo tipo </p>
	</section>

	<div class="pimg4">
		<div class="ptext">
			<span class="border">
				Viajar
			</span>
		</div>
	</div>
	<section class="section section-dark">
		<p>Me gusta conocer nuevos lugares</p>
	</section>
    <a href="/Persona/Index">Regresa a la lista</a>
    <a href="/Video/JonathanVazquez">Ver videos</a>
    
</body>
</html>
<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>JonathanVazquez</title>
    <style>
        *{
 	margin: 0;
 	padding: 0;
 	font-family: consolas;
 	box-sizing: border-box;
 }
 body{
 	min-height: 100vh;
 	background: #050801;
 }
 a{
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
 a:nth-child(2){
 	filter: hue-rotate(110deg);
 }
 a:hover{
 	background: #03e9f4;
 	color: #050801;
 	box-shadow: 0 0 5px #03e9f4,
 				0 0 25px #03e9f4,
 				0 0 50px #03e9f4,
 				0 0 200px #03e9f4;
 }
 a span{
 	position: absolute;
 	display: block;
 }
 a span:nth-child(1){
 	top: 0;
 	left: -100%;
 	width: 100%;
 	height: 2px;
 	background: linear-gradient(90deg,transparent, #03e9f4);
 	animation: animate1 1s linear infinite;
 }
 @keyframes animate1{
 	0%{
 		left: -100%;
 	}
 	50%, 100%{
 		left: 100%;
 	}
 }
 a span:nth-child(2){
 	top: -100;
 	right: 0;
 	width: 2px;
 	height: 100%;
 	background: linear-gradient(180deg,transparent, #03e9f4);
 	animation: animate2 1s linear infinite;
 	animation-delay: 0.25s;
 }
 @keyframes animate2{
 	0%{
 		top: -100%;
 	}
 	50%, 100%{
 		top: 100%;
 	}
 }
 a span:nth-child(3){
 	bottom: 0;
 	right: -100%;
 	width: 100%;
 	height: 2px;
 	background: linear-gradient(270deg,transparent, #03e9f4);
 	animation: animate3 1s linear infinite;
 	animation-delay: 0.5s;
 }
 @keyframes animate3{
 	0%{
 		right: -100%;
 	}
 	50%, 100%{
 		right: 100%;
 	}
 }
a span:nth-child(4){
 	bottom: -100%;
 	left: 0;
 	width: 2px;
 	height: 100%;
 	background: linear-gradient(360deg,transparent, #03e9f4);
 	animation: animate4 1s linear infinite;
 	animation-delay: 0.75s;
 }
 @keyframes animate4{
 	0%{
 		bottom: -100%;
 	}
 	50%, 100%{
 		bottom: 100%;
 	}
 }
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
			background-image: url('https://i.ytimg.com/vi/Y-wFgP0S0PM/maxresdefault.jpg');
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
<a href="/Persona/Index">
		<span></span>
		<span></span>
		<span></span>
		<span></span>
		Regresar
	</a>
	<a href="/Video/JonathanVazquez">
		<span></span>
		<span></span>
		<span></span>
		<span></span>
		Videos
	</a>
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
</body>
</html>
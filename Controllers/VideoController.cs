using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.SqlClient;
using System.Data;
using MVCLaboratorio.Utilerias;
using MVCLaboratorio.Models;

namespace MVCLaboratorio.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LIIGabriel()
        {
            //obtener todos los videos
            DataTable dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure); 

            List<Video> lstvideos = new List<Video>();

            //convertir el DataTable en List<Video> 

            foreach (DataRow item in dtVideos.Rows)
            {
                Video datosVideo = new Video();

                datosVideo.IdVideo = int.Parse(item["IdVideo"].ToString());
                datosVideo.Nombre = item["Nombre"].ToString();
                datosVideo.Url = item["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                lstvideos.Add(datosVideo);

            }

            return View(lstvideos);
        }

        public ActionResult lesliemorales26()
        {
            //obtener todos los videos
            DataTable dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstvideos = new List<Video>();

            //convertir el DataTable en List<Video>

            foreach (DataRow item in dtVideos.Rows)
            {
                Video datosVideo = new Video();

                datosVideo.IdVideo = int.Parse(item["IdVideo"].ToString());
                datosVideo.Nombre = item["Nombre"].ToString();
                datosVideo.Url = item["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                lstvideos.Add(datosVideo);

            }

            return View(lstvideos);

        }
        public ActionResult Edalmaj()
        {
            DataTable dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstvideos = new List<Video>();

            foreach (DataRow item in dtVideos.Rows)
            {
                Video datosVideo = new Video();

                datosVideo.IdVideo = int.Parse(item["IdVideo"].ToString());
                datosVideo.Nombre = item["Nombre"].ToString();
                datosVideo.Url = item["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                lstvideos.Add(datosVideo);

            }
            return View(lstvideos);
        }

        public ActionResult SantosGuzman01()
        {
            DataTable dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstvideos = new List<Video>();

            foreach (DataRow item in dtVideos.Rows)
            {
                Video datosVideo = new Video();

                datosVideo.IdVideo = int.Parse(item["IdVideo"].ToString());
                datosVideo.Nombre = item["Nombre"].ToString();
                datosVideo.Url = item["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                lstvideos.Add(datosVideo);
            }
            return View(lstvideos);
        }

        public ActionResult ialemares()
        {
            DataTable dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstvideos = new List<Video>();

            foreach (DataRow item in dtVideos.Rows)
            {
                Video datosVideo = new Video();

                datosVideo.IdVideo = int.Parse(item["IdVideo"].ToString());
                datosVideo.Nombre = item["Nombre"].ToString();
                datosVideo.Url = item["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                lstvideos.Add(datosVideo);
            }

            return View(lstvideos);
        }


        public ActionResult raulantonio177()
        {
            DataTable datosVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> listaVideo = new List<Video>();

            foreach (DataRow video in datosVideo.Rows)
            {
                Video oVideo = new Video();

                oVideo.IdVideo = int.Parse(video["IDVIDEO"].ToString());
                oVideo.Nombre = video["NOMBRE"].ToString();
                oVideo.Url = video["URL"].ToString();
                oVideo.FechaPublicacion = DateTime.Parse(video["FECHAPUBLICACION"].ToString());

                listaVideo.Add(oVideo);
            }
            return View(listaVideo);

        }
        public ActionResult mauricioTapia()
        {
            DataTable Datos_Video = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lista_Video = new List<Video>();

            foreach (DataRow item in Datos_Video.Rows)
            {
                Video dts_video = new Video();

                dts_video.IdVideo = int.Parse(item["IdVideo"].ToString());
                dts_video.Nombre = item["Nombre"].ToString();
                dts_video.Url = item["Url"].ToString();
                dts_video.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                lista_Video.Add(dts_video);
            }
            return View(lista_Video);
        }

        public ActionResult DANI1356779()
        {
            DataTable dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstvideos = new List<Video>();

            foreach (DataRow item in dtVideos.Rows)
            {
                Video datosVideo = new Video();

                datosVideo.IdVideo = int.Parse(item["IdVideo"].ToString());
                datosVideo.Nombre = item["Nombre"].ToString();
                datosVideo.Url = item["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                lstvideos.Add(datosVideo);
            }

            return View(lstvideos);
        
    }
        public ActionResult YaelMendez23()
        {
    //obtener todos los videos
            DataTable dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstvideos = new List<Video>();
             //convertir el DataTable en List<Video>

            foreach (DataRow item in dtVideos.Rows)
            {
                Video datosVideo = new Video();

                datosVideo.IdVideo = int.Parse(item["IdVideo"].ToString());
                datosVideo.Nombre = item["Nombre"].ToString();
                datosVideo.Url = item["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                lstvideos.Add(datosVideo);
            }

            return View(lstvideos);
        }

        public ActionResult DanArzolaga()
        {
            //obtener los videos de la base de datos
            DataTable dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstVideo = new List<Video>();

            //convertir el DataTable en List
            foreach (DataRow item in dtVideos.Rows)
            {
                Video dtsVideo = new Video();

                dtsVideo.IdVideo = int.Parse(item["IdVideo"].ToString());
                dtsVideo.Nombre = item["Nombre"].ToString();
                dtsVideo.Url = item["Url"].ToString();
                dtsVideo.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                lstVideo.Add(dtsVideo);
            }

            return View(lstVideo);
        }
        public ActionResult JassoB57()
        {
            //obtener todos los videos
            DataTable dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstvideos = new List<Video>();

            //convertir el DataTable en List<Video>

            foreach (DataRow item in dtVideos.Rows)
            {
                Video datosVideo = new Video();

                datosVideo.IdVideo = int.Parse(item["IdVideo"].ToString());
                datosVideo.Nombre = item["Nombre"].ToString();
                datosVideo.Url = item["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                lstvideos.Add(datosVideo);
            }

            return View(lstvideos);
        }
    }


}

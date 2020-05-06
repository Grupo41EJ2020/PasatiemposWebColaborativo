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
        public ActionResult Monse03()
        {

            DataTable dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);
            List<Video> Istvideos = new List<Video>();

            foreach (DataRow item in dtVideos.Rows)
            {
                Video datosVideo = new Video();
                datosVideo.IdVideo = int.Parse(item["IdVideo"].ToString());
                datosVideo.Nombre = item["Nombre"].ToString();
                datosVideo.Url = item["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());
                Istvideos.Add(datosVideo);
            }
            return View(Istvideos);

        }

        public ActionResult NoelGamez()
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

        public ActionResult AndreaEstrada21()
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

        public ActionResult AnaKarenLopez()
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

        public ActionResult PriscilaCtz()
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

<<<<<<< HEAD

             public ActionResult ialemares()
        {
                 DataTable dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

                 List<Video> lstvideos = new List<Video>();

                 foreach (DataRow item in dtVideos.Rows)
                 {
                     Video datosVideo = new Video();

                     datosVideo.IdVideo = int.Parse(item["IdVideo"].ToString());
                     datosVideo.Nombre= item["Nombre"].ToString();
                     datosVideo.Url= item["Url"].ToString();
                     datosVideo.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                     lstvideos.Add(datosVideo);
                 }
                 
                 return View(lstvideos);
        }

            
=======
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
>>>>>>> 63335d6558e6d771b42c5890af01610ca09370f1
        }
    }


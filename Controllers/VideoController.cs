﻿using System;
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

        public ActionResult Quique07Ds()
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

        public ActionResult Quique07DsDetails(int id)
        {
             //consultar los datos del video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Video miVideo = new Video();

            if (dtVideo.Rows.Count > 0)
            {
                miVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                miVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                miVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                miVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());
                return View(miVideo);
            }
            else 
            {  
                //no encontrado 
                return View("Error");
            }
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

        public ActionResult LIIGabrielDetails(int id) {
            //consultar los datos del video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Video miVideo = new Video();

            if (dtVideo.Rows.Count > 0)
            {
                miVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                miVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                miVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                miVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());
                return View(miVideo);
            }
            else {  //no encontrado 
                return View("Error");
            }
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

            public ActionResult lesliemorales26Details(int id) {
            //consultar los datos del video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Video miVideo = new Video();

            if (dtVideo.Rows.Count > 0)
            {
                miVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                miVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                miVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                miVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["fechaPublicacion"].ToString());
                return View(miVideo);
            }
            else
            {
                //No encontrado
                return View("Error");
            }
          
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
        public ActionResult SantosGuzman01Details (int id) {

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorId",CommandType.StoredProcedure,parametros);

            Video miVideo = new Video();

            if(dtVideo.Rows.Count > 0)
            {
                miVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                miVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                miVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                miVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());
                return View(miVideo);
            }
            else {
                return View("Error");
            }
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

        public ActionResult alemaresDetails(int id) {
            //Consultar los datos del video 
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("IdVideo", id));

            DataTable dtVideo = BaseHelper.ejecutarConsulta("Sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Video miVideo = new Video();

            if (dtVideo.Rows.Count > 0)
            { 
                miVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                miVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                miVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                miVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["Fecha Publicacion"].ToString());
                return View(miVideo);
            }

            else
            { //No encontrado 
                return View("Error");
            }
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
        public ActionResult DANI1356779Detalles(int id)
        {
            //consultar los datos del video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Video miVideo = new Video();

            if (dtVideo.Rows.Count > 0)
            {
                miVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                miVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                miVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                miVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());
                return View(miVideo);
            }
            else
            {  //no encontrado 
                return View("Error");
            }
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
        public ActionResult luiks13()
        {
            //obtiene los videos en la base de datos
            DataTable dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstVideo = new List<Video>();

            //convierte el DataTable en List

            foreach (DataRow item in dtVideos.Rows)
            {
                Video datosVideo = new Video();

                datosVideo.IdVideo = int.Parse(item["IdVideo"].ToString());
                datosVideo.Nombre = item["Nombre"].ToString();
                datosVideo.Url = item["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());


                lstVideo.Add(datosVideo);
            }

            return View(lstVideo);
        }

        public ActionResult jahirgranadosV()
        {
            //Carga los videos desde la base de datos
            DataTable dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstVideos = new List<Video>();

            foreach (DataRow item in dtVideos.Rows)
            {
                Video datosVideo = new Video();

                datosVideo.IdVideo = int.Parse(item["IdVideo"].ToString());
                datosVideo.Nombre = item["Nombre"].ToString();
                datosVideo.Url = item["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                lstVideos.Add(datosVideo);
            }
            return View(lstVideos);

        }
        public ActionResult Alancrypto()
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

        public ActionResult JustAlvaro()
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

        public ActionResult AnaKarenLopezDetails(int id)
        {
            //consultar datos del video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Video miVideo = new Video();

            if (dtVideo.Rows.Count > 0)
            {
                miVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                miVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                miVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                miVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());
                return View(miVideo);
            }
            else
            {  
                return View("Error");
            }
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
        public ActionResult Monse03Details(int id)
        {
            //consultar los datos del video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);
            Video miVideo = new Video();
            if (dtVideo.Rows.Count > 0)
            {
                miVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                miVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                miVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                miVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());
                return View(miVideo);
            }
            else
            {
                return View("ERROR");
            }

        }


        public ActionResult danielamaldonadognz()
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
        public ActionResult danielamaldonadognzDetails(int id)
        {
            //consultar los datos del video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);
            Video miVideo = new Video();
            if (dtVideo.Rows.Count > 0)
            {
                miVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                miVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                miVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                miVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());
                return View(miVideo);
            }
            else
            {
                return View("ERROR");
            }

        }       
    }
}


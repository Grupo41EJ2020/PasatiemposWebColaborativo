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

        public ActionResult LIIGabrielDetails(int id)
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

        public ActionResult LIIGabrielDelete(int id){
            //obtener info del video
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

        [HttpPost]
        public ActionResult LIIGabrielDelete(int id, FormCollection frm) {
            //obtener info del video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("LIIGabriel");
        }

        public ActionResult LIIGabrielEdit(int id) { 
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

        [HttpPost]
        public ActionResult LIIGabrielEdit(int id,Video datos) {
            //realizar el update
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("LIIGabriel");            
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

        public ActionResult Quique07DsDelete(int id)
        {
            //obtener info del video
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

        [HttpPost]
        public ActionResult Quique07DsDelete(int id, FormCollection frm)
        {
            //obtener info del video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Quique07Ds");
        }

        public ActionResult Quique07DsEdit(int id)
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

        [HttpPost]
        public ActionResult Quique07DsEdit(int id, Video datos)
        {
            //realizar el update
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Quique07Ds");
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

        public ActionResult lesliemorales26Details(int id)
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

        public ActionResult EdalmajDetails(int id)
        {
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

        public ActionResult EdalmajDelete(int id) 
        {
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

        [HttpPost]
        public ActionResult EdalmajDelete(int id, FormCollection frm)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Edalmaj");
        }

        public ActionResult EdalmajEdit(int id)
        {
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

        [HttpPost]
        public ActionResult EdalmajEdit(int id, Video datos)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));

            BaseHelper.ejecutarSentencia("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("Edalmaj");
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
        public ActionResult SantosGuzman01Details(int id)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorId", CommandType.StoredProcedure, parametros);

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
        public ActionResult SantosGuzman01Delete(int id)
        {
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
        [HttpPost]
        public ActionResult SantosGuzman01Delete(int id, FormCollection frm)
        {
            //obtener info del video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("SantosGuzman01");
        }
        public ActionResult SantosGuzman01Edit(int id)
        {
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
        [HttpPost]
        public ActionResult SantosGuzman01Edit(int id, Video datos)
        {
            //realizar el update
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("SantosGuzman01");
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

        public ActionResult alemaresDetails(int id)
        {
            //Consultar los datos del video 
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("IdVideo", id));

            DataTable dtVideo = BaseHelper.ejecutarConsulta("Sp_Video_ConsultarPorID", CommandType.StoredProcedure, Parametros);

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

        public ActionResult raulantonio177Detalles(int id)
        {
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

        public ActionResult raulantonio177Delete(int id) 
        {
            //Accion que solo muestra informacion

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

        [HttpPost]
        public ActionResult raulantonio177Delete(int id, FormCollection frm)
        {
            //Accion que elimina de la bd

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("raulantonio177");
        }

        public ActionResult raulantonio177Edit(int id)
        { 
            //Accion que recupera informacion

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

        [HttpPost]
        public ActionResult raulantonio177Edit(int id, Video oVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", oVideo.Nombre));
            parametros.Add(new SqlParameter("@Url", oVideo.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", oVideo.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("raulantonio177");         
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
        public ActionResult mauricioTapiaDetalles(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Video MiVideo = new Video();
            if (dtVideo.Rows.Count > 0)
            {
                MiVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                MiVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                MiVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                MiVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());
                return View(MiVideo);
            }
            else
            {
                return View("ERROR");
            }
        }
        public ActionResult mauricioTapiaBorrar(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Video MiVideo = new Video();
            if (dtVideo.Rows.Count > 0)
            {
                MiVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                MiVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                MiVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                MiVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());
                return View(MiVideo);
            }
            else
            {
            return View("ERROR");
                }
        }
        [HttpPost]
        public ActionResult mauricioTapiaBorrar(int id, FormCollection frm)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo",id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("mauricioTapia");
        }
        public ActionResult mauricioTapiaEditar(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Video MiVideo = new Video();
            if (dtVideo.Rows.Count > 0)
            {
                MiVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                MiVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                MiVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                MiVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());
                return View(MiVideo);
            }
            else
            {
                return View("ERROR");
            }
        }
        [HttpPost]
        public ActionResult mauricioTapiaEditar(int id, Video datos_video)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("Nombre", datos_video.Nombre));
            parametros.Add(new SqlParameter("Url", datos_video.Url));
            parametros.Add(new SqlParameter("FechaPublicacion", datos_video.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return View();
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
        public ActionResult DANI1356779Borrar(int id)
        {
            //obtener info del video
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

        [HttpPost]
        public ActionResult DANI1356779Borrar(int id, FormCollection frm)
        {
            //obtener info del video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("DANI1356779");
        }

        public ActionResult DANI1356779Editar(int id)
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

        [HttpPost]
        public ActionResult DANI1356779Editar(int id, Video datos)
        {
            //realizar el update
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("DANI1356779");
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
        public ActionResult DanArzolagaDetails(int id)
        {
            //consulta los detalles de video
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@IdVideo", id));
            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorId", CommandType.StoredProcedure, parametros);

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
                //si no encuentra la vista
                return View("DanError");
            }


        }

        public ActionResult DanArzolagaDelete(int id)
        {
            //Borrar video de la base de datos

            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@IdVideo", id));

            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorId", CommandType.StoredProcedure, parametros);

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
                return View("DanError");
            }
        }
        [HttpPost]
        public ActionResult DanArzolagaDelete(int id, FormCollection dtVideo)
        {
            //ejecura el delete del registro seleccionado
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("DanArzolaga");
        }

        public ActionResult DanArzolagaEdit(int id)
        {
            //consulta la informacion del video de la base de datos
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorId", CommandType.StoredProcedure, parametros);

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
                //no lo encontro
                return View("DanError");
            }
        }

        [HttpPost]
        public ActionResult DanArzolagaEdit(string Nombre, string Url, DateTime FechaPublicacion)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@Nombre", Nombre));
            parametros.Add(new SqlParameter("@Url", Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", FechaPublicacion));

            BaseHelper.ejecutarSentencia("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("DanArzolaga");
        }

        public ActionResult DanArzolagaCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DanArzolagaCreate(string Nombre, string Url, DateTime FechaPublicacion)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@Nombre", Nombre));
            parametros.Add(new SqlParameter("@Url", Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", FechaPublicacion));

            BaseHelper.ejecutarSentencia("sp_Video_Insertar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("DanArzolaga");
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


        public ActionResult JassoB57Details(int id)
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
            { //No encontrado
                return View("Error");
            }
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

        public ActionResult jahirgranadosDetails(int id)
        {
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

        public ActionResult AnaKarenLopezDelete(int id)
        {
            //Obtendremos la info del video
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
        [HttpPost]
        public ActionResult AnaKarenLopezDelete(int id, FormCollection frm)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("AnaKarenLopez");
        }

        public ActionResult AnaKarenLopezEdit(int id)        
        { 
            //obtener la informacion del video para llenar las cajas con los datos
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
        [HttpPost]
        public ActionResult AnaKarenLopezEdit(int id, Video datos)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));
            
            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("AnaKarenLopez");
            
        }

        public ActionResult AnaKarenLopezCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AnaKarenLopezCreate(string Nombre, string Url, DateTime FechaPublicacion)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Nombre", Nombre));
            parametros.Add(new SqlParameter("@Url", Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", FechaPublicacion));

            BaseHelper.ejecutarSentencia("sp_Video_Insertar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("AnaKarenLopez");
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
        public ActionResult Monse03Delete(int id)
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
        [HttpPost]
        public ActionResult Monse03Delete(int id, FormCollection frm)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Monse03");


        }
        public ActionResult Monse03Edit(int id)
        {
          
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
        [HttpPost]
        public ActionResult Monse03Edit(int id, Video datos)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Monse03");


        }

        public ActionResult Debany1108()
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
        public ActionResult Debany1108Details(int id)
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

        public ActionResult NoelGamezDetails(int id)
        {
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

        public ActionResult NoelGamezDelete(int id)
        {
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

        [HttpPost]
        public ActionResult NoelGamezDelete(int id, FormCollection frm)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("NoelGamez");
        }

        public ActionResult NoelGamezEdit(int id)
        {
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

        [HttpPost]
        public ActionResult NoelGamezEdit(int id, Video datos)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));


            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("NoelGamez");
        }

        public ActionResult JonathanVazquez()
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
        public ActionResult JonathanVazquezDetails(int id)
        {
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
        
        public ActionResult ghs29()
        {
            //obtener los videos
            DataTable datosVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> listaVideo = new List<Video>();

            foreach (DataRow video in datosVideo.Rows)
            {
                Video dVideo = new Video();

                dVideo.IdVideo = int.Parse(video["idvideo"].ToString());
                dVideo.Nombre = video["nombre"].ToString();
                dVideo.Url = video["url"].ToString();
                dVideo.FechaPublicacion = DateTime.Parse(video["fechapubli"].ToString());

                listaVideo.Add(dVideo);
            }
            return View(listaVideo);

        }

        public ActionResult ghs29(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            DataTable dtVideo = BaseHelper.ejecutarConsulta("SP_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

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

        public ActionResult Alexibarra999()
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
        public ActionResult Alexibarra999Details(int id)
        {
            {
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
        }
  
        public ActionResult Ashbatis30()
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

        public ActionResult Ashbatis30Details(int id)
        {
            {
                //Consultar datos del video
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
                else //No encontrado
                {
                    return View("Error");
                }
            }
        }
            
            public ActionResult AndreaEstrada21()
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
            public ActionResult AndreaEstrada21Details(int id)
            {
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
            public ActionResult AndreaEstrada21Delete(int id)
            {
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
            [HttpPost]
            public ActionResult AndreaEstrada21Delete(int id, FormCollection frm)
            {
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@IdVideo", id));

                BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
                return RedirectToAction("AndreaEstrada21");
            }
            public ActionResult AndreaEstrada21Edit(int id)
            {
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
            [HttpPost]
            public ActionResult AndreaEstrada21Edit(int id, Video datos)
            {
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@IdVideo", id));
                parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
                parametros.Add(new SqlParameter("@Url", datos.Url));
                parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));

                BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
                return RedirectToAction("AndreaEstrada21");       
            }
            public ActionResult AlancryptoDetails(int id)
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

            public ActionResult PriscilaCtzDetails(int id)
            {

                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@IdVideo", id));

                DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorId", CommandType.StoredProcedure, parametros);

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
            public ActionResult RogelioRodriguez()
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
            public ActionResult RogelioRodriguezDetails(int id)
            {

                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@IdVideo", id));

                DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorId", CommandType.StoredProcedure, parametros);

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
                public ActionResult Andreagpp()
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

                public ActionResult JAOG2000()
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

                public ActionResult JAOG2000Details(int id)
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

                public ActionResult JAOG2000Delete(int id)
                {
                    //obtener info del video
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

                [HttpPost]
                public ActionResult JAOG2000Delete(int id, FormCollection frm)
                {
                    //obtener info del video
                    List<SqlParameter> parametros = new List<SqlParameter>();
                    parametros.Add(new SqlParameter("@IdVideo", id));

                    BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
                    return RedirectToAction("LIIGabriel");
                }

                public ActionResult JAOG2000Edit(int id)
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

                [HttpPost]
                public ActionResult JAOG2000Edit(int id, Video datos)
                {
                    //realizar el update
                    List<SqlParameter> parametros = new List<SqlParameter>();
                    parametros.Add(new SqlParameter("@IdVideo", id));
                    parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
                    parametros.Add(new SqlParameter("@Url", datos.Url));
                    parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));

                    BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
                    return RedirectToAction("LIIGabriel");
                }


            }
        }
    


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
        RepositorioVideo repoVideo = new RepositorioVideo();

        public ActionResult LIIGabriel()
        {
            return View(repoVideo.obtenerVideos());
        }

        public ActionResult jenniferhdzf()
        {
            return View(repoVideo.obtenerVideos());
        }




        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LIIGabrielDetails(int id)
        {
            return View(repoVideo.obtenerVideo(id));
        }

        public ActionResult LIIGabrielDelete(int id)
        {
            return View(repoVideo.obtenerVideo(id));
        }

        [HttpPost]
        public ActionResult LIIGabrielDelete(int id, FormCollection frm)
        {
            repoVideo.eliminarVideo(id);
            return RedirectToAction("LIIGabriel");
        }

        public ActionResult LIIGabrielEdit(int id)
        {
            return View(repoVideo.obtenerVideo(id));
        }

        [HttpPost]
        public ActionResult LIIGabrielEdit(int id, Video datos)
        {
            datos.IdVideo = id;
            repoVideo.actualizarVideo(datos);
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

        public ActionResult lesliemorales26Delete(int id)
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
                miVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["fechaPublicacion"].ToString());
                return View(miVideo);
            }
            else
            {
                //No encontrado
                return View("Error");
            }

        }

        [HttpPost]
        public ActionResult lesliemorales26Delete(int id, FormCollection frm)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("lesliemorales26");
        }

        public ActionResult lesliemorales26Edit(int id)
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
                miVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["fechaPublicacion"].ToString());
                return View(miVideo);
            }
            else
            {
                //No encontrado
                return View("Error");
            }
        }

        [HttpPost]
        public ActionResult lesliemorales26Edit(int id, Video datos)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("lesliemorales26");
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
            return View(repoVideo.obtenerVideos());
        }

        public ActionResult alemaresDetails(int id)
        {
            //Consultar los datos del video 
            return View(repoVideo.obtenerVideo(id));
        }

        public ActionResult alemaresDelete(int id)
        {
            //obtener info del video
            return View(repoVideo.obtenerVideo(id));

        }

        [HttpPost]
        public ActionResult alemaresDelete(int id, FormCollection frm)
        {
            //obtener info del video
            repoVideo.eliminarVideo(id);
            return RedirectToAction("LIIGabriel");
        }

        public ActionResult alemaresEdit(int id)
        {
            //consultar los datos del video
            return View(repoVideo.obtenerVideo(id));
        }

        [HttpPost]
        public ActionResult alemaresEdit(int id, Video datos)
        {
            //realizar el update
            datos.IdVideo = id;
            repoVideo.actualizarVideo(datos);
            return RedirectToAction("LIIGabriel");
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
            parametros.Add(new SqlParameter("IdVideo", id));
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
            parametros.Add(new SqlParameter("IdVideo", id));
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
            parametros.Add(new SqlParameter("IdVideo", id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("mauricioTapia");
        }
        public ActionResult mauricioTapiaEditar(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("IdVideo", id));
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



        public ActionResult YaelMendez23Detalles(int id)
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

        public ActionResult YaelMendez23Delete(int id)
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
        public ActionResult YaelMendez23Delete(int id, FormCollection frm)
        {
            //obtener info del video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("YaelMendez23");
        }



        public ActionResult YaelMendez23Edit(int id)
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
        public ActionResult YaeMendez23Edit(int id, Video datos)
        {
            //realizar el update
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));

            BaseHelper.ejecutarSentencia("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("YaelMendez23");
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
            return View(repoVideo.obtenerVideos());

        }


        public ActionResult JassoB57Details(int id)
        {
            return View(repoVideo.obtenerVideo(id));
        }
        public ActionResult JassoB57Delete(int id)
        {

            return View(repoVideo.obtenerVideo(id));
        }

        [HttpPost]
        public ActionResult JassoB57Delete(int id, FormCollection frm)
        {
            repoVideo.eliminarVideo(id);
            return RedirectToAction("JassoB57");
        }

        public ActionResult JassoB57Edit(int id)
        {
            return View(repoVideo.obtenerVideo(id));
        }

        [HttpPost]
        public ActionResult JassoB57Edit(int id, Video datos)
        {
            datos.IdVideo = id;
            repoVideo.actualizarVideo(datos);
            return RedirectToAction("JassoB57");
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

        public ActionResult luiks13Details(int id)
        {
            //Consultar los datos del video
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
            { //no encontrado
                return View("error");
            }
        }

        public ActionResult luiks13Delete(int id)
        {  //obtener info del video
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
            { //no encontrado
                return View("error");
            }

        }

        [HttpPost]
        public ActionResult luiks13Delete(int id, FormCollection frm)
        {
            //obtener info del video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("luiks13");
        }

        public ActionResult luiks13Edit(int id)
        {
            //Obtener la info del video para llenar las cajas con los datos
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
            { //no encontrado
                return View("error");
            }

        }

        [HttpPost]
        public ActionResult luiks13Edit(int id, Video datos)
        {
            //Realizar Update
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));
            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("luiks13");
            return View();
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

        public ActionResult JustAlvaroDetails(int id)
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
        public ActionResult JustAlvaroDelete(int id)
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
        public ActionResult JustAlvaroDelete(int id, FormCollection frm)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("JustAlvaro");
        }

        public ActionResult JustAlvaroEdit(int id)
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
        public ActionResult JustAlvaroEdit(int id, Video datos)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("JustAlvaro");


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

        public ActionResult Debany1108Delete(int id)
        {
            //obtener la informacion del video
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
        public ActionResult Debany1108Delete(int id, FormCollection frm)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("debany1108");
        }

        public ActionResult Debany1108Edit(int id)
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
        public ActionResult Debany1108Edit(int id, Video datos)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("debany1108");
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

        public ActionResult danielamaldonadognzDelete(int id)
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
        public ActionResult danielamaldonadognzDelete(int id, FormCollection frm)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("danielamaldonadognz");
        }

        public ActionResult danielamaldonadognzEdit(int id)
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
        public ActionResult danielamaldonadognzEdit(int id, Video datos)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("danielamaldonadognz");

        }

        public ActionResult danielamaldonadognzCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult danielamaldonadognzCreate(string Nombre, string Url, DateTime FechaPublicacion)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Nombre", Nombre));
            parametros.Add(new SqlParameter("@Url", Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", FechaPublicacion));

            BaseHelper.ejecutarSentencia("sp_Video_Insertar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("danielamaldonadognz");
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

                dVideo.IdVideo = int.Parse(video["IdVideo"].ToString());
                dVideo.Nombre = video["Nombre"].ToString();
                dVideo.Url = video["Url"].ToString();
                dVideo.FechaPublicacion = DateTime.Parse(video["FechaPublicacion"].ToString());

                listaVideo.Add(dVideo);
            }
            return View(listaVideo);

        }

        public ActionResult ghs29Detalles(int id)
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
        public ActionResult ghs29Borrar(int id)
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
        public ActionResult ghs29borrar(int id, FormCollection frm)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("IdVideo", id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("ghs29");
        }
        public ActionResult ghs29Editar(int id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("IdVideo", id));
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
        public ActionResult ghs29Editar(int id, Video datos_video)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("IdVideo", id));
            parametros.Add(new SqlParameter("Nombre", datos_video.Nombre));
            parametros.Add(new SqlParameter("Url", datos_video.Url));
            parametros.Add(new SqlParameter("FechaPublicacion", datos_video.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return View();
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
        public ActionResult Alexibarra999Delete(int id)
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
            {
                return View("Error");
            }
        }

        [HttpPost]
        public ActionResult Alexibarra999Delete(int id, FormCollection frm)
        {
            //obtener info del video 
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Alexibarra999");
        }

        public ActionResult Alexibarra999Edit(int id)
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
                return View("Error");
            }
        }
        [HttpPost]
        public ActionResult Alexibarra999Edit(int id, Video datos)
        {
            //realizar el update
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));
            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Alexibarra999");
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
        public ActionResult Ashbatis30Delete(int id)
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
        public ActionResult Ashbatis30Delete(int id, FormCollection frm)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Ashbatis30");
        }

        public ActionResult Ashbatis30Edit(int id)
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
        public ActionResult Ashbatis30Edit(int id, Video datos)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Ashbatis30");
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
        public ActionResult PriscilaCtzDelete(int id)
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
        public ActionResult PriscilaCtzDelete(int id, FormCollection frm)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("PriscilaCtz");
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
        public ActionResult PriscilaCtzEdit(int id)
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
        public ActionResult PriscilaCtzEdit(int id, Video datos)
        {
            //realizar el update
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("PriscilaCtz");
        }
        public ActionResult RogelioRodriguezDetails(int id)
        {
            //Consultar los datos
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

        public ActionResult RogelioRodriguezDelete(int id)
        {
            //obtener info del video
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
        [HttpPost]
        public ActionResult RogelioRodriguezDelete(int id, FormCollection frm)
        {
            //obtener info del video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("RogelioRodriguez");
        }

        public ActionResult RogelioRodriguezEdit(int id)
        {
            //Consultar los datos del video
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

        [HttpPost]
        public ActionResult RogelioRodriguezEdit(int id, Video datos)
        {
            //realizar el update
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("RogelioRodriguez");
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

        public ActionResult AndreagppDetails(int id)
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


        public ActionResult AndreagppDelete(int id)
        {
            //Consultar informacion del Video
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

        [HttpPost]
        public ActionResult AndreagppDelete(int id, FormCollection frm)
        {
            //obtener info del video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Andreagpp");
        }

        public ActionResult AndreagppEdit(int id)
        {
            //Consultar los datos del video
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
        public ActionResult AndreagppEdit(int id, Video datos)
        {
            //Realizar el Update
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("Andreagpp");
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

        public ActionResult AlancryptoDelete(int id)
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
        public ActionResult AlancryptoDelete(int id, FormCollection frm)
        {
            //obtener info del video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Alancrypto");
        }

        public ActionResult AlancryptoEdit(int id)
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
        public ActionResult AlancryptoEdit(int id, Video datos)
        {
            //realizar el update
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Alancrypto");
        }

        //
        public ActionResult PaolaDuarteLrd()
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

        public ActionResult PaolaDuarteLrdDetails(int id)
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

        public ActionResult PaolaDuarteLrdDelete(int id)
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
        public ActionResult PaolaDuarteLrdDelete(int id, FormCollection frm)
        {
            //obtener info del video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("PaolaDuarteLrd");
        }

        public ActionResult PaolaDuarteLrdEdit(int id)
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
        public ActionResult PaolaDuarteLrdEdit(int id, Video datos)
        {
            //realizar el update
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("PaolaDuarteLrd");
        }

        public ActionResult JonathanVBDelete(int id)
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
        public ActionResult JonathanVBDelete(int id, FormCollection frm)
        {
            //obtener info del video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("JonathanVazquez");
        }

        public ActionResult JonathanVBEdit(int id)
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
        public ActionResult JonathanVBEdit(int id, Video datos)
        {
            //realizar el update
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("JonathanVazquez");
        }

        public ActionResult Isaac()
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

        public ActionResult IsaacDetails(int id)
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

        public ActionResult IsaacDelete(int id)
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
        public ActionResult IsaacDelete(int id, FormCollection frm)
        {
            //obtener info del video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Quique07Ds");
        }

        public ActionResult IsaacEdit(int id)
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
        public ActionResult IsaacEdit(int id, Video datos)
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


        public ActionResult jenniferhdzfDetails(int id)
        {
            return View(repoVideo.obtenerVideo(id));
        }

        public ActionResult jenniferhdzDelete(int id)
        {
            return View(repoVideo.obtenerVideo(id));
        }

        [HttpPost]
        public ActionResult jenniferhdzDelete(int id, FormCollection frm)
        {
            repoVideo.eliminarVideo(id);
            return RedirectToAction("jenniferhdzf");
        }

        public ActionResult jenniferhdzfEdit(int id)
        {
            return View(repoVideo.obtenerVideo(id));
        }

        [HttpPost]
        public ActionResult jenniferhdzfEdit(int id, Video datos)
        {
            datos.IdVideo = id;
            repoVideo.actualizarVideo(datos);
            return RedirectToAction("jenniferhdzf");
        }
        public ActionResult SirObzedat()
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
        public ActionResult SirObzedatDetails(int id)
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
        public ActionResult SirObzedatDelete(int id)
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
        public ActionResult SirObzedatDelete(int id, FormCollection frm)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("SirObzedat");
        }

        public ActionResult SirObzedatEdit(int id)
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
        public ActionResult SirObzedatEdit(int id, Video datos)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("SirObzedat");
        }

        public ActionResult JonatanGC7()
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
        public ActionResult JonatanGC7Details(int id)
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

        public ActionResult JonatanGC7Delete(int id)
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
        public ActionResult JonatanGC7Delete(int id, FormCollection frm)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("JonatanGC7");
        }

        public ActionResult JonatanGC7Edit(int id)

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
        public ActionResult JonatanGC7Edit(int id, Video datos)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            parametros.Add(new SqlParameter("@Nombre", datos.Nombre));
            parametros.Add(new SqlParameter("@Url", datos.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datos.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("JonatanGC7");
        }
        public ActionResult aboitesabril13()
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
    }
}

    


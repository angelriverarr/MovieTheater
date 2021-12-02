using PryectoMovieTheater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PryectoMovieTheater.Controllers
{
    public class AdministradorwebController : Controller
    {
        // GET: Administradorweb
        public ActionResult UpData()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Recursos imagen)
        {



            String ruta = Server.MapPath("~/img/");
            ruta += imagen.file.FileName;

            imagen.file.SaveAs(ruta);

            return View();
        }
        public ActionResult Inicio()
        {
            return View();
        }
    }
}
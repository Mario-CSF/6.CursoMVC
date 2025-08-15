using _6.CursoMVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6.CursoMVC.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public ActionResult Index()
        {
            if (TempData["Message"] != null)
                ViewBag.Message = TempData["Message"].ToString();
         
            return View();
        }

        [HttpPost]
        public ActionResult Save(FileViewModel model)
        {
            string RutaSitio = Server.MapPath("~/");
            string PathArchivo1 = Path.Combine(RutaSitio+"/Files/archivo1.png");
            string PathArchivo2 = Path.Combine(RutaSitio+"/Files/archivo2.png");
            
            if(!ModelState.IsValid)
            {
                return View("Index", model);
            }

            model.Archivo1.SaveAs(PathArchivo1);
            model.Archivo2.SaveAs(PathArchivo2);

            TempData["Message"] = "Los archivos fueron cargados";
            return RedirectToAction("Index");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using IEApplication.Models;

namespace IEApplication.Controllers
{
    public class HomeController : Controller
    {
        private IEDatabaseEntities context = new IEDatabaseEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult EmergencyPage()
        {
            ViewBag.Message = "Map showing nearest dental clinics.";

            return View();
        }

        public ActionResult GeneralPage()
        {
            ViewBag.Message = "Map showing dental clinics with waiting time.";

            return View();
        }
        public JsonResult GetAllLocation()
        {
            var data = context.google_map.ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

    }
}
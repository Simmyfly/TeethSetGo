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
        private TeethSetGoDBEntities context = new TeethSetGoDBEntities();
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
            var data = context.Clinics.ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult General_Toothache()
        {
            ViewBag.Message = "Toothache Problem (General cases)";
            return View();
        }

        public ActionResult Emergency_Toothache()
        {
            ViewBag.Message = "Toothache Problem (Emergency cases)";
            return View();
        }

        public ActionResult Cavities()
        {
            ViewBag.Message = "Cavities Problem";
            return View();
        }
        public ActionResult Emergency_Cavities()
        {
            ViewBag.Message = "Cavities Problem (Emergency cases)";
            return View();
        }
        public ActionResult General_Cavities()
        {
            ViewBag.Message = "Cavities Problem (Non-Emergency cases)";
            return View();
        }
        public ActionResult SensitiveToCold()
        {
            ViewBag.Message = "SensitiveToCold Problem";
            return View();
        }
    }
}
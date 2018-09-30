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

        public ActionResult Prevention()
        {
            ViewBag.Message = "Prevention";

            return View();
        }

        public ActionResult Quiz()
        {
            ViewBag.Message = "Prevention - Quiz for dental knowledge";

            return View();
        }

        public ActionResult Hotels()
        {
            ViewBag.Message = "Hotels nearby hospitals";

            return View();
        }

        public ActionResult EmergencyPage()
        {
            ViewBag.Message = "Map showing nearest dental clinics.";

            return View();
        }
        public ActionResult AllClinics()
        {
            ViewBag.Message = "Dental Clinics in Queensland";

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
        public ActionResult Toothache()
        {
            ViewBag.Message = "Toothache Problem";
            return View();
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
        public ActionResult Emergency_SensitiveToCold()
        {
            ViewBag.Message = "Sensitive to Cold Problem (Emergency cases)";
            return View();
        }
        public ActionResult General_SensitiveToCold()
        {
            ViewBag.Message = "Sensitive to Cold Problem (Non-Emergency cases)";
            return View();
        }
        public ActionResult TooManyTeeth()
        {
            ViewBag.Message = "Too Many Teeth Problem";
            return View();
        }
        public ActionResult Emergency_TooManyTeeth()
        {
            ViewBag.Message = "Too Many Teeth Problem (Emergency cases)";
            return View();
        }
        public ActionResult General_TooManyTeeth()
        {
            ViewBag.Message = "Too Many Teeth Problem (Non-Emergency cases)";
            return View();
        }
       
        public ActionResult GapBetweenTeeth()
        {
            ViewBag.Message = "Gap Between Teeth Problem";
            return View();
        }
        public ActionResult Emergency_GapBetweenTeeth()
        {
            ViewBag.Message = "Gap Between Teeth Problem (Emergency cases)";
            return View();
        }
        public ActionResult General_GapBetweenTeeth()
        {
            ViewBag.Message = "Gap Between Teeth Problem (Non-Emergency cases)";
            return View();
        }
        public ActionResult ChippedTooth()
        {
            ViewBag.Message = "Chipped Tooth Problem";
            return View();
        }
        public ActionResult Emergency_ChippedTooth()
        {
            ViewBag.Message = "Chipped Tooth Problem (Emergency cases)";
            return View();
        }
        public ActionResult KnockedOutTooth()
        {
            ViewBag.Message = "Knocked Out Tooth Problem";
            return View();
        }
        public ActionResult Emergency_KnockedOutTooth()
        {
            ViewBag.Message = "Knocked Out Tooth Problem";
            return View();
        }
        public ActionResult GumProblem()
        {
            ViewBag.Message = "Gum Problem";
            return View();
        }
        public ActionResult Emergency_GumProblem()
        {
            ViewBag.Message = "Gum Problem (Emergency Cases)";
            return View();
        }
        public ActionResult WisdomTeethProblem()
        {
            ViewBag.Message = "Wisdom Teeth Problem";
            return View();
        }
        public ActionResult Emergency_WisdomTeethProblem()
        {
            ViewBag.Message = "Wisdom Teeth Problem(Emergency Cases)";
            return View();
        }
        public ActionResult CrookedTeeth()
        {
            ViewBag.Message = "Crooked Teeth Problem";
            return View();
        }
        public ActionResult Emergency_CrookedTeeth()
        {
            ViewBag.Message = "Crooked Teeth Problem(Emergency Cases)";
            return View();
        }
        public ActionResult General_CrookedTeeth()
        {
            ViewBag.Message = "Crooked Teeth Problem(General Cases)";
            return View();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IEApplication.Controllers
{
    public class HomeController : Controller
    {
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
    }
}
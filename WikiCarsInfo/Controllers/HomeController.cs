using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WikiCarsInfo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BMW()
        {
            return View();
        }

        public ActionResult BMW520()
        {
            return View();
        }
        public ActionResult BMW7()
        {
            return View();
        }
        public ActionResult BMWi8()
        {
            return View();
        }
        public ActionResult AUDI()
        {
            return View();
        }
        public ActionResult AUDIA8()
        {
            return View();
        }
        public ActionResult AUDIQ8()
        {
            return View();
        }
        public ActionResult AUDIR8()
        {
            return View();
        }
        public ActionResult MERC()
        {
            return View();
        }
        public ActionResult MERCSLS()
        {
            return View();
        }
        public ActionResult MERCC()
        {
            return View();
        }
        public ActionResult MERCS()
        {
            return View();
        }
        public ActionResult _Layout()
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
    }
}
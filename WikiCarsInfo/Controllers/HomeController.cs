using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WikiCarsInfo.Controllers
{
    public class HomeController : Controller
    {
        [Route("index")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("bmw")]
        public ActionResult BMW()
        {
            return View();
        }

        [Route("audi")]
        public ActionResult AUDI()
        {
            return View();
        }

        [Route("merc")]
        public ActionResult MERC()
        {
            return View();
        }

        
        [Route("about")]
        public ActionResult About()
        {
            return View();
        }

        [Route("contact")]
        public ActionResult Contact()
        {
            return View();
        }
    }
}
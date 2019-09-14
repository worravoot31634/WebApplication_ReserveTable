using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReserveTable.Controllers
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

        public ActionResult Promotion1()
        {

            return View();
        }
        public ActionResult Promotion2()
        {

            return View();
        }
        public ActionResult Promotion3()
        {

            return View();
        }
        public ActionResult Promotion4()
        {

            return View();
        }
        public ActionResult Promotion5()
        {

            return View();
        }
    }
}
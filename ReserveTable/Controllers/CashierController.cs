using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReserveTable.Controllers
{
    public class CashierController : Controller
    {
        // GET: Cashier
        public ActionResult Index()
        {
            return View();
        }
    }
}
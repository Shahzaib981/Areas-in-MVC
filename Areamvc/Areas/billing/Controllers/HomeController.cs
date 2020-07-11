using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Areamvc.Areas.billing.Controllers
{
    public class HomeController : Controller
    {
        // GET: billing/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace first_webapplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id)
        {
            return Content("Hello "+id+"!");
        }
        public ActionResult About()
        {
            return View();
        }
    }
}
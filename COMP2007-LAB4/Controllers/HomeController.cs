using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP2007_LAB4.Controllers
{
    public class HomeController : Controller
    {
        //GET: /Home/Index or /
        public ActionResult Index()
        {
            return View();
        }

        //GET: /Home/About or /
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //GET: /Home/Contactr or /
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
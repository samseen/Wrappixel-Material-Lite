using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wrappixel_Material_Lite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PagesBlank()
        {
            return View();
        }

        public ActionResult PagesProfile()
        {
            return View();
        }

        public ActionResult TableBasic()
        {
            return View();
        }

        public ActionResult Icons()
        {
            return View();
        }

        public ActionResult NotFoundPage()
        {
            return View();
        }

        public ActionResult GoogleMap()
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
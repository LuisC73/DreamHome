using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DreamHome.Controllers
{
    public class housesController : Controller
    {
        // GET: houses
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RegisterHouses()
        {
            ViewBag.show = "houses";
            return View();
        }

        public ActionResult EditHouses()
        {
            ViewBag.show = "houses";
            return View();
        }

        public ActionResult DeleteHouses()
        {
            ViewBag.show = "houses";
            return View();
        }

        public ActionResult SelectHouses()
        {
            ViewBag.show = "houses";
            return View();
        }
    }
}
using Shop.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        [Authentificate]
        public ActionResult Index()
        {
            return RedirectToAction("../Account/Register");

            return View();
        }

        public ActionResult About()
        {
            if (!User.Identity.IsAuthenticated) throw new Exception();

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XFWebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var p = Request.Url.GetLeftPart(UriPartial.Authority);
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}

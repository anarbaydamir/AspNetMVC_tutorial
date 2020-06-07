using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCProject.Controllers
{
    public class RedirectController : Controller
    {
        public RedirectResult Index()
        {
            return Redirect ("~/view");
        }
        public RedirectToRouteResult Index3()
        {
            return RedirectToAction("Index");
            //return RedirectToAction("Index", "View");
            //return RedirectToAction("Index", new { controller = "View", id = 5 });
            //return RedirectToRoute("Default", new { controller = "View", index = "Index2" });
        }
    }
}

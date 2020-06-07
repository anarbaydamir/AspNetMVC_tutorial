using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCProject.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Anar Baydamirov";
        }

        public ActionResult IndexView()
        {
            return View("IndexView");
        }

        [NonAction] //means this is not a controller method
        public string testMethod()
        {
            return "salam";
        }

        [ActionName("indexview")] //give name to controller
        public ActionResult Index2()
        {
            return View();
        }

        //[AcceptVerbs(HttpVerbs.Get)]
        //[HttpPost]
        //[AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public ActionResult actionMethod()
        {
            return Content("Something");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCProject.Controllers
{
    public class ViewController : Controller
    {
        public ViewResult Index()
        {
            return View ("Index");
        }

        public PartialViewResult Index2()
        {
            return PartialView("Index2");
        }
    }
}

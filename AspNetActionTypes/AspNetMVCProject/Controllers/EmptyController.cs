using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCProject.Controllers
{
    public class EmptyController : Controller
    {
        public ActionResult Index()
        {
            return new EmptyResult ();
        }

        public EmptyResult Index2()
        {
            return null;
        }
    }
}

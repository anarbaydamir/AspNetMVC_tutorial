using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCProject.Controllers
{
    public class JavaScriptController : Controller
    {
        public ActionResult Index()
        {
            return View ("Index");
        }

        public JavaScriptResult Alert()
        {
            return JavaScript("alert('Hi man')");
        }
    }

}

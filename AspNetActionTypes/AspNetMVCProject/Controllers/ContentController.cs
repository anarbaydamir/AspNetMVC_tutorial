using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCProject.Controllers
{
    public class ContentController : Controller
    {
        public ContentResult Index()
        {
            //return Content("Anar Baydamirov");
            //return Content("Anar Baydamirov", "text/html; charset=utf-8");
            return Content("Anar Baydamirov", "text/html", Encoding.UTF8);
        }

        public ContentResult Index2()
        {
            return Content("<b>Anar Baydamirov</b>", "text/plain");
        }

        public ContentResult Index3()
        {
            var xml = "<products>" +
                      "<product><name>Notebook</name></product>" +
                      "<product><name>PC</name></product>" +
                      "</products>";

            return Content(xml,"application/xml");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;

namespace AspNetMVCProject.Controllers
{
    public class HTTPController : Controller
    {
        public HttpStatusCodeResult Index()
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadGateway);

            //return new HttpStatusCodeResult(HttpStatusCode.BadGateway, "Bad gateway from mvc");

            //return new HttpStatusCodeResult(502);
        }

        public HttpUnauthorizedResult Index2()
        {
            return new HttpUnauthorizedResult();

            //return new HttpUnauthorizedResult("not authonticated");
        }

        public HttpNotFoundResult Index3()
        {
            return new HttpNotFoundResult();

            //return new HttpNotFoundResult("Sorry, not found");
        }
    }
}

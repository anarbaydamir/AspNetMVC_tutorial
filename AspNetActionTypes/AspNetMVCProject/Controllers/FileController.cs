using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCProject.Controllers
{
    public class FileController : Controller
    {
        public FileResult Index()
        {
            return File("file.doc", "application/msword"); //fayl download olunub baxilir
            //return File("file.doc", "application/msword", "file.doc"); //fayla ad verirsen
            //return File("file.txt", "text/plain"); //texti browserde achir
            //return File("file.txt", "text/plain", "file.txt"); //fayla ad verilir
        }

        public FileContentResult Index2()
        {
            byte[] bytes = System.IO.File.ReadAllBytes(Server.MapPath("file.txt")); //bytelarla fayli vermek

            return File(bytes, "text/plain", "file.txt");
        }

        public ActionResult Index3()
        {
            var fileStream = new FileStream(Server.MapPath("file.txt"), FileMode.Open); //filestreamla vermek

            return File(fileStream, "file.txt");
        }
    }
}

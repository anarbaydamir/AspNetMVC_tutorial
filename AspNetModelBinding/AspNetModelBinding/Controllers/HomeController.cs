using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetModelBinding.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //RouteDate
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];

            //query String
            var lastName = Request.QueryString["lastName"];


            return RedirectToAction("Index2",
                new { controller="Home",action="index",id=1,lastName="Baydamirov" }); //eger route'da lastName yoxdursa bunu querystring kimi gonderecek
        }

        public ActionResult Index2()
        {
            return new EmptyResult();
        }

        public ActionResult Index3(int id,string name,string lastName)//methodun deyerlerinde ilk once route'da varsa hemin deyerleri getirir, eger yoxdursa forma baxir orda da yoxdursa querystringe baxir. Hech birinde yoxdursa null verir
        {
            return new EmptyResult();
        }


        //postdan parameterleri goturme
        [HttpPost]
        public ActionResult Index4()
        {
            var name = Request.Form["name"];
            var lastName = Request.Form["lastName"];

            return new EmptyResult();
        }

        [HttpPost]
        public ActionResult Index5(string name,string lastName)
        {
            return new EmptyResult();
        }

        [HttpPost]
        public ActionResult Index6(FormCollection formCollection)
        {
            var name = formCollection["name"];
            var lastName = formCollection["lastName"];

            return new EmptyResult();
        }

        //bir de custom class kimi qebul ede bilerik parameterleri. Java'da @ModelAttribute kimi
    }
}

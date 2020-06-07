using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Asp.netMVCModel.Entity;
using Asp.netMVCModel.Models;

namespace Asp.netMVCModel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Projects> projects = new List<Projects>();
            projects.Add(new Projects(1, "project1"));
            projects.Add(new Projects(2, "project2"));

            List<Users> users = new List<Users>();
            users.Add(new Users(1, "Anar", "Baydamirov"));
            users.Add(new Users(2, "Misha", "Elmir"));

            var model = new HomeIndexViewModels();
            model.projects = projects;
            model.users = users;
            return View ("Index",model);
           // return View("Index", model:model);
        }

        public ActionResult Index2()
        {
            ViewData["message"] = "hello viewdata";

            ViewBag.Message = "hello viewbag"; //burdaki message menim verdiyim xususi addir

            TempData["tempMessage"] = "hello tempdata";

            return View("Index");
        }
    }
}

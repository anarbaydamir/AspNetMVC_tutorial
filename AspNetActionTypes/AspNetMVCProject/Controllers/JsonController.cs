using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCProject.Controllers
{
    public class Product
    {
        public string name { get; set; }
        public int unitPrice { get; set; }
    }
    public class JsonController : Controller
    {
        public JsonResult Index()
        {
            var products = new List<Product>();
            products.Add(new Product { name = "Anar", unitPrice = 5 });
            products.Add(new Product { name = "Misha", unitPrice = 10 });

            return Json(products, "application/json", Encoding.UTF8, JsonRequestBehavior.AllowGet); //default denyGet
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult HelloWorld()
        {
            HelloWorldModel model = new HelloWorldModel
            {
                Name = "Zvi Rotsztein",
                DOB = Convert.ToDateTime("1987 - 01 - 01"),
                HomeTown="London",
                PathToImage= "https://beithorah.co.il/wp-content/uploads/2020/06/%D7%94%D7%A8%D7%91-%D7%A6%D7%91%D7%99-%D7%A8%D7%95%D7%98%D7%A0%D7%A9%D7%98%D7%99%D7%99%D7%9F-1.jpg"
            };
            return View(model);
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempData_Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TempData["myKey"] = "This is my Date From TempData";
            return View();
        }

        public ActionResult Index2()
        {
            //ViewBag.MyKey = TempData["myKey"];
            //TempData.Keep("myKey");
            ViewBag.MyKey = TempData.Peek("myKey");

            //for Close or End session
            Session.Abandon();
            return View();
        }

        public ActionResult Index3()
        {
            //ViewBag.MyKey = TempData["myKey"];
            //TempData.Keep("myKey");

            ViewBag.MyKey = TempData.Peek("myKey");

            return View();
        }
    }
}
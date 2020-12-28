using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Learning.Controllers
{
    public class HomeController : Controller
    {
        #region CommentedCode

        //public string Index()
        //{
        //    return "Hello from index method Controller";
        //}

        //public string Name()
        //{
        //    return "Hello from Name method";
        //}
        #endregion

        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Index()
        {
            return View("~/Views/MyView/NewView.cshtml");
        }

        public ViewResult AboutUs()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTTP_Verbs.Models;

namespace HTTP_Verbs.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Profile(Student student)
        {
            return View();
        }

        [HttpPut]
        public ActionResult UpdateProfile(int id, Student student)
        {
            return View();
        }

        [HttpDelete]
        public ActionResult DeleteProfile(int id, Student student)
        {
            return View();
        }

    }
}
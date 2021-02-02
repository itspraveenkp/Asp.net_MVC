using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validation_in_MVC_with_strongly_binding.Models;

namespace Validation_in_MVC_with_strongly_binding.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult submitData(Employee emp)
        {
            if (ModelState.IsValid)
            { 
                return View();
            }
            return View("Index");
        }
    }
}
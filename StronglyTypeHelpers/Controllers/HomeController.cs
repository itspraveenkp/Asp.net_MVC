using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StronglyTypeHelpers.Models;

namespace StronglyTypeHelpers.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
                Address = "This is my address...",
                Name = "Praveen",
                isEmployee = true

            };
            return View(emp);
        }

        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            return View();
        }
    }
}
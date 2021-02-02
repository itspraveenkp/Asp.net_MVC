using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Templated_HTML_helpers.Models;

namespace Templated_HTML_helpers.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
                ID = 1,
                Name = "Praveen",
                Email = "itspraveenkp@gmail.com",
                DateOfBirth = DateTime.Now,
                IsOnline = true
            };
            return View(emp);
        }

        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            return View();
        }
    }
} 
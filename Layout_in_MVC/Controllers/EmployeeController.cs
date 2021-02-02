using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Layout_in_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [Route("Employee")]
        public ActionResult getList()
        {
            return View();
        }

        [Route("New-Employee")]
        public ActionResult addEmployee()
        {
            return View();
        }
    }
}
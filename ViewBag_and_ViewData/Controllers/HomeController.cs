using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBag_and_ViewData.Models;

namespace ViewBag_and_ViewData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.MyCustomProperty = "Praveen Prajapati";

            ViewBag.myList = new List<string>() { "Ganeshay", "Shiva", "Mahesh", "Bramha" };

            List<Employee> empList = new List<Employee>()
            {
                new Employee(){ ID=101, Name="Neetu", Email ="n@gmail.com" },
                new Employee(){ ID=102, Name="Neha", Email ="Ne@gmail.com" },
                new Employee(){ ID=103, Name="Prince", Email ="P@gmail.com" },
                new Employee(){ ID=104, Name="Sanjay", Email ="s@gmail.com" },
                new Employee(){ ID=105, Name="Ravi", Email ="r@gmail.com" },
                new Employee(){ ID=106, Name="Rakesh", Email ="r@gmail.com" },
                new Employee(){ ID=107, Name="Vijay", Email ="v@gmail.com" },
                new Employee(){ ID=108, Name="Ritesh", Email ="r@gmail.com" },
                new Employee(){ ID=109, Name="Ashish", Email ="a@gmail.com" },
                new Employee(){ ID=110, Name="Rajesh", Email ="ra@gmail.com" },
                new Employee(){ ID=111, Name="Atul", Email ="a@gmail.com" },
                new Employee(){ ID=112, Name="Suman", Email ="s@gmail.com" },
            };

            ViewBag.MyEmployeeList = empList;
            
            return View();
        }

        public ActionResult Dem()
        {
            ViewData["MyKey"] = "This is value for key";

            ViewData["MyList"] = new List<string>() { "Ganeshay", "Shiva", "Mahesh", "Bramha" };

            return View();
        }
    }
}
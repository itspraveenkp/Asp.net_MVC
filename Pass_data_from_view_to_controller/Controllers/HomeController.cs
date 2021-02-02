using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pass_data_from_view_to_controller.Models;

namespace Pass_data_from_view_to_controller.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        //with parameter
        [HttpPost]
        public string PostUsingParameters(string firstName, string lastName)
        {
            return "From Parameters " + firstName + ", " + lastName;
        }

        //Without Parameter
        [HttpPost]
        public string PostUsingRequest()
        {
            string firstName = Request["firstName"];
            string lastName = Request["lastName"];

            return "From Request " + firstName + ", " + lastName;
        }

        [HttpPost]
        public string PostUsingFormCollection(FormCollection form)
        {
            string firstName = form["firstName"];
            string lastName = form["lastName"];

            return "From FormCollection " + firstName + ", " + lastName;
        }

        public string PostUsingStrongllyBinding(Employee emp)
        {
            return "From Stronglly Binding " + emp.firstName + "," + emp.lastName;
        }
    }
}
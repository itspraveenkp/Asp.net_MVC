using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Learning.Models;

namespace MVC_Learning.Controllers
{
    public class EmployeeController : Controller
    {
        #region CommentedCode

        //public string EmployeeProfile(int id)
        //{
        //    string profile = string.Empty;
        //    if (id == 1)
        //    {
        //        profile = "Employee 1 Profile";
        //    }
        //    else if (id == 2)
        //    {
        //        profile = "Employee 1 Profile";
        //    }
        //    else
        //    {
        //        profile = "No Record found";
        //    }

        //    return profile;
        //}

        ////int? department = null;
        //public string Address(int id, int? code=null)
        //{
        //    return "id = " + id + " Dept = " + code;
        //}
        #endregion

        public ActionResult Index()
        {
            var data = getEmployee();
            return View(data);
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        private Employee getEmployee()
        {
            return new Employee()
            {
                ID = 1,
                Name = "Praveen",
                Address = "Bandra"
            };
        }
    }
}
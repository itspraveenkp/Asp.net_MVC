using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Attribute_Routing.Models;

namespace Attribute_Routing.Controllers
{
    [RoutePrefix("Student")]
    public class StudentController : Controller
    {
        //[Route("Student")]
        [Route("")]
        public ActionResult GetAllStudent()
        {
            var students = Student();
            return View(students);
        }

        //[Route("Student/{id}")]
        //[Route("{id}")]

        //pass as int value
        [Route("{id:int}")]

        //pass as minimum value
        [Route("{id:int:min(4)}")]
        public ActionResult GetStudent(int id)
        {
            var students = Student().FirstOrDefault(x => x.ID == id);
            return View(students);
        }

        //[Route("Student/{id}/Address")]
        [Route("{id}/Address")]
        public ActionResult GetStudentAddress(int id)
        {
            var studentsAddress = Student().Where(x => x.ID == id).Select(x => x.Address).FirstOrDefault();
            return View(studentsAddress);
        }

        [Route("{NewData}")]
        public string MyString(string NewData)
        {
            return NewData;
        }

        //We can you more than one router for one method
        //but not can use more than one method same name router
        [Route("~/About-us")]
        [Route("~/Aboutus")]
        public string AboutUs()
        {
            return "This is my About US";
        }

        private List<Students> Student()
        {
            return new List<Students>()
            {
                new Students()
                {
                    ID = 1,
                    Name = "1 Student",
                    Class = "First",

                    Address = new Address()
                    {
                        Address1 = "This is Address of Student 1",
                        City = "Student City 1",
                        HomeNumber = "This is a Home Number of Student 1"
                    }
                },

                new Students()
                {
                    ID = 2,
                    Name = "2 Student",
                    Class = "Two",

                    Address = new Address()
                    {
                        Address1 = "This is Address of Student 2",
                        City = "Student City 2",
                        HomeNumber = "This is a Home Number of Student 2"
                    }
                },
                new Students()
                {
                    ID = 3,
                    Name = "3 Student",
                    Class = "Three",

                    Address = new Address()
                    {
                        Address1 = "This is Address of Student 3",
                        City = "Student City 3",
                        HomeNumber = "This is a Home Number of Student 3"
                    }
                },
                new Students()
                {
                    ID = 4,
                    Name = "4 Student",
                    Class = "Four",

                    Address = new Address()
                    {
                        Address1 = "This is Address of Student 4",
                        City = "Student City 4",
                        HomeNumber = "This is a Home Number of Student 4"
                    }
                },

             };
    }
    }
}
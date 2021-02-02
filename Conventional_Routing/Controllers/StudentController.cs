using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Conventional_Routing.Models;

namespace Conventional_Routing.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult GetAllStudent()
        {
            var student = students();
            return View(student);
        }

        public ActionResult GetStudent(int id)
        {
            var student = students().FirstOrDefault(x => x.ID == id);
            return View(student);
        }

        public ActionResult GetStudentAddress(int id)
        {
            var studentAddress = students().Where(x => x.ID == id).Select(x => x.Address).FirstOrDefault();
            return View(studentAddress);
        }

        private List<Student> students()
        {
            return new List<Student>()
            {
                new Student()
                {
                    ID = 1,
                    Name = "1 student",
                    Class = "First",

                    Address = new Address()
                    {
                        Address1 = "This is my Address student 1",
                        City = "Student City1",
                        HomeNumber = "Student 2"

                    }

                },

                new Student()
                { 
                    ID= 2,
                    Name = "Student 2",
                    Class = "Second",
                    Address = new Address()
                    { 
                        Address1 = "This is student 2 Address",
                        City = "Student 2 city",
                        HomeNumber = "Student 2"
                    }

                },
                new Student()
                {
                    ID = 3,
                    Name = "3 student",
                    Class = "Three",

                    Address = new Address()
                    {
                        Address1 = "This is my Address student 3",
                        City = "Student City3",
                        HomeNumber = "Student 3"

                    }

                },

                new Student()
                {
                    ID= 4,
                    Name = "Student 4",
                    Class = "Four",
                    Address = new Address()
                    {
                        Address1 = "This is student 4 Address",
                        City = "Student 4 city",
                        HomeNumber = "Student 4"
                    }

                },
                new Student()
                {
                    ID = 5,
                    Name = "5 student",
                    Class = "Five",

                    Address = new Address()
                    {
                        Address1 = "This is my Address student 5",
                        City = "Student City5",
                        HomeNumber = "Student 5"

                    }

                },

                new Student()
                {
                    ID= 6,
                    Name = "Student 6",
                    Class = "Six",
                    Address = new Address()
                    {
                        Address1 = "This is student 6 Address",
                        City = "Student 6 city",
                        HomeNumber = "Student 6"
                    }

                },
            };

        }
    }
}
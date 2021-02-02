using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Templated_HTML_helpers.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Display(Name = "Please Enter Your Name")]
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsOnline { get; set; }

        [Display(Name = "Please Enter Date")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [DataType(DataType.Time)]
        public DateTime BirthTime { get; set; }
    }
}
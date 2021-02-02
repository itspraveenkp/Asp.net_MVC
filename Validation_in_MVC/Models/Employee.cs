using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Validation_in_MVC.Models
{
    public class Employee
    {
        //Custom Error Message
        [Required(ErrorMessage ="Please Enter Your First Name")]
        
        //System Error Message
        //[Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Range(18,100)]
        public int Age { get; set; }
    }
}
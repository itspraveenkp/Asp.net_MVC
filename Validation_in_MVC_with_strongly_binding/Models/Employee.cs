using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Validation_in_MVC_with_strongly_binding.Models
{
    public class Employee
    {
        //We can write custome Error message just write after required like [required(ErrorMessage = "Please Enter")] 
        //[Required]
        //custome error message
        [Required(ErrorMessage = "Please Enter FullName")]
        public string firstName { get; set; }
        [Required]
        public string  lastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Range(18, 100)]
        public int Age { get; set; }
    }
}
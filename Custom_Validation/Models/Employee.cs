using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Custom_Validation.Models
{
    public class Employee
    {
        [Required]
        public string Name { get; set; }

        //[PraveenValidation]

        //Custome Message
        [PraveenValidation(ErrorMessage = "Praveen is required")]

        public string Message { get; set; }
    }
}
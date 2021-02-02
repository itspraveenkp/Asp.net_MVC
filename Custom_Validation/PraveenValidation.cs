using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Custom_Validation
{
    public class PraveenValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string message = value.ToString();
                if (message.Contains("Praveen"))
                {
                    return ValidationResult.Success;
                }
            }
            //ErrorMessage = ErrorMessage ?? "Field Must Contain Praveen";

            ErrorMessage = ErrorMessage ?? validationContext.DisplayName + "Field Must Contain Praveen";

            //return new ValidationResult("Field Must Contain Praveen ");
            return new ValidationResult(ErrorMessage);
        }
    }
}
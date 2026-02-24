using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreValidation.Models.Validation
{
    public  class FutureDateValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object value, ValidationContext validationContext)
        {
            if(value is DateTime date)
            {
                if( date > DateTime.Now)
                {
                    return new ValidationResult("Enrollment date cannot be of future");
                }
            }
            return ValidationResult.Success;
        }
    }
}

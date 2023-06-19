using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Form_P.Models
{
    public class BirthdateValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime dob = Convert.ToDateTime(value);

              
                int age = DateTime.Today.Year - dob.Year;

               
                if (age < 20)
                {
                    return new ValidationResult("Age must be greater than 20.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
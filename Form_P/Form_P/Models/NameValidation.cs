using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Form_P.Models
{
    public class NameValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string name = value.ToString();

                
                if (!IsValidName(name))
                {
                    return new ValidationResult("Name can only contain alphabets, spaces, and dots.");
                }
                if (name.Length > 99)
                {
                    return new ValidationResult("Name length must be less than 100 characters.");
                }
            }

            return ValidationResult.Success;
        }

        private bool IsValidName(string name)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(name, "^[a-zA-Z .]*$");
        }
    }
}
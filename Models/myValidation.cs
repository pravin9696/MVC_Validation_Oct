using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Validation_Oct.Models
{
    public class myValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value!=null)
            {
                String nm = value.ToString();
                if (nm.Contains("pravin"))
                {
                    return ValidationResult.Success;
                }
            }
            ErrorMessage = ErrorMessage ?? "message must contain pravin word";
            return new ValidationResult(ErrorMessage);
        }
    }
}
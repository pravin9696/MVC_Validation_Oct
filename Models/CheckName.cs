using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Validation_Oct.Models
{
    public class CheckName:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value!=null)
            {
                String sName = value.ToString();
                if (sName.Contains("Mr.")|| sName.Contains("Ms.")|| sName.Contains("Mrs."))
                {
                    return ValidationResult.Success;
                }
            }
            String msg = ErrorMessage ?? " Student Name must contain Mr. Or Ms. Or Mrs.";


            return new ValidationResult(msg);
           
        }
    }
}
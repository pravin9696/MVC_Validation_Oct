using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Validation_Oct.Models
{
    public class DifferentContactValidator:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //value ==>contact2

            //contact1??

            var std =(Student) validationContext.ObjectInstance;
            if (value!=null && std.contact1!=null)
            {
               string c1 = std.contact1;
                string c2 = value.ToString();

                if (c1.CompareTo(c2)!=0)
                {
                    return ValidationResult.Success;
                }
            }

            return new ValidationResult("contact 1 and contact 2 must be different!!!");

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Validation_Oct.Models
{
    public class StudentFeedback
    {
        [Required]
        public String Name { get; set; }
        [myValidation]
        public String message { get; set; }
    }
}
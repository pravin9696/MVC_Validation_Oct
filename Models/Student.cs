using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Validation_Oct.Models
{

    //client side validation
    public class Student
    {
        [Required(ErrorMessage ="Name of student is required!!!")]
        public int Roll { get; set; }//required
        [Required( ErrorMessage ="Enter Name",AllowEmptyStrings =true)]
        [CheckName]
        public String Name { get; set; }//required
        [Required()]
        [Range(0,500,ErrorMessage ="Enter Total marks between 0 to 500 only")]
       
        public int TotalMarks { get; set; }//required AND total Marks >=0 and <= 500

        [Required]
        [MinLength(5)]
        [MaxLength(10)]
        public string Password { get; set; }
        [Required]
        [Compare(otherProperty:"Password")]
        public String RePassword { get; set; }

        [EmailAddress]
        [Required]
        
        public String email { get; set; }

        [Required]
        public String contact1 { get; set; }

        [Required]
        [DifferentContactValidator]
        public String contact2 { get; set; } //contact2 must be different from contact1

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        

    }
}
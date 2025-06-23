using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Validation_Oct.Models
{
    // perform server side validation
    public class Employee
    {
        public int Id { get; set; }
        public String Name { get; set; } // required
        public int Salary { get; set; }  // salary  10000 to 35000   AND required
    }
}
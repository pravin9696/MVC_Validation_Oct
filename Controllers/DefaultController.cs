using MVC_Validation_Oct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Validation_Oct.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        //server side validation
        public ActionResult AddEmployee(Employee emp)
        {
            if (string.IsNullOrEmpty(emp.Name))//name empty
            {
                ModelState.AddModelError("Name","Name required!!");
            }
            if (emp.Salary<10000 || emp.Salary>35000)
            {
                ModelState.AddModelError("Salary", "Salary must be between 10000 to 35000");
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        // client side validation
        public ActionResult AddStudent(Student std)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
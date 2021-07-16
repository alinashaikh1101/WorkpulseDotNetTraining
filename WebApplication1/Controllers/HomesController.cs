using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomesController : Controller
    {
        static IList<Employee> EmployeeList = new List<Employee>{
                new Employee() { EmployeeId = 1, Name = "John", Age = 18 } ,
                new Employee() {EmployeeId = 2,  Name = "Steve",  Age = 21 } ,
                new Employee() { EmployeeId= 3, Name = "Bill",  Age = 25 } ,
                new Employee() {EmployeeId = 4, Name = "Ram" , Age = 20 } ,
                new Employee() { EmployeeId = 5, Name = "Ron" , Age = 31 } ,
                new Employee() {EmployeeId = 4,Name = "Chris" , Age = 17 } ,
                new Employee() {EmployeeId = 4, Name = "Rob" , Age = 19 },
                new Employee() {EmployeeId = 4, Name = "Rob" , Age = 19 }
            };

        public ActionResult Index()
        {
           
            return View(EmployeeList);
           
        }

        public ActionResult Create()
        {
          
            return View();
        }

        [HttpPost]

        public ActionResult Create(FormCollection formCollection)
        {
            if (ModelState.IsValid)
            {
                Employee employee = new Employee();
                employee.Name = formCollection["Name"];
                employee.Gender = formCollection["Gender"];
                employee.Age = Convert.ToInt32(formCollection["Age"]);
                employee.Position = formCollection["Position"];
                employee.Office = formCollection["Office"];
                employee.HireDate = Convert.ToDateTime(formCollection["HireDate"]);
                employee.Salary = Convert.ToInt32(formCollection["Salary"]);
                employee.Description = formCollection["Description"];
                employee.Skills = formCollection["Skills"];

                



                RedirectToAction("Index");
            }
            return View();
        }
    }
}
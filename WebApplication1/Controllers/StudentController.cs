using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;




namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
         IList<Student> studentList = new List<Student>{
                new Student() { StudentId = 1, Name = "John", Age = 18, Gender = "Male", Office="indore", HireDate = new DateTime(), Salary=1000,Position="trainee",Description="Workpulse",Skill="C"} ,
                new Student() { StudentId = 2, Name = "Steve",  Age = 21, Gender = "Male",   HireDate = new DateTime(),Salary=1000,Position="trainee",Office="indore",Description="Workpulse",Skill="php"} ,
                new Student() { StudentId = 3, Name = "Bill",  Age = 25, Gender = "Male", HireDate = new DateTime(), Salary=1000,Position="trainee",Office="indore",Description="Workpulse",Skill="C"} ,
                new Student() { StudentId = 4, Name = "Ram" , Age = 20, Gender = "Male",  HireDate = new DateTime(), Salary=1000,Position="trainee",Office="indore",Description="Workpulse",Skill="php"} ,
                new Student() { StudentId = 5, Name = "Ron" , Age = 31, Gender = "Female",  HireDate = new DateTime(), Salary=1000,Position="trainee",Office="indore",Description="Workpulse",Skill="C"} ,
                new Student() { StudentId = 5, Name = "Ron" , Age = 31, Gender = "Female",  HireDate = new DateTime(),Salary=1000,Position="trainee",Office="indore",Description="Workpulse",Skill="php" } ,
                new Student() { StudentId = 6, Name = "Chris" , Age = 17, Gender = "Male", HireDate = new DateTime(), Salary=1000,Position="trainee",Office="indore",Description="Workpulse",Skill="C"} ,
                new Student() { StudentId = 7, Name = "Rob" , Age = 19, Gender = "Male",  HireDate = new DateTime(), Salary=1000,Position="trainee",Office="indore",Description="Workpulse",Skill="php" }
            };

        // GET: Student
        public ActionResult Index()
        {
            return View(studentList);
        }



        public ActionResult Edit(int id)
        {
            var std = studentList.Where(s => s.StudentId == id).FirstOrDefault();
            return View(std);
        }



        [HttpPost]
        public ActionResult EditStudent(Student std)
        {
            if (ModelState.IsValid)
            { //checking model state





                var student = studentList.Where(s => s.StudentId == std.StudentId).FirstOrDefault();
                studentList.Remove(student);
                studentList.Add(std);





                return RedirectToAction("Index");
            }
            return View("edit", std);
        }

        public ActionResult Details(int id)
        {

            var stddet = studentList.Where(s => s.StudentId == id).FirstOrDefault();
            ViewBag.student = stddet;
            return View();



        
}

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var student = studentList.Where(s => s.StudentId == id).FirstOrDefault();
            studentList.Remove(student);
            return View("Index");
        }
        

        
        public ActionResult Add()
        {
            
            return View();
        }



        [HttpPost]
        public ActionResult Edit(FormCollection formCollection)
        {
            if (ModelState.IsValid)
            {
                Student student = new Student();
                student.Name = formCollection["Name"];
                student.Gender = formCollection["Gender"];
                student.Age = Convert.ToInt32(formCollection["Age"]);
                student.HireDate = Convert.ToDateTime(formCollection["HireDate"]); 
                student.Position = formCollection["position"];
                student.Salary = Convert.ToInt32(formCollection["salary"]);
                student.Office = formCollection["position"];
                student.Description = formCollection["Description"];
                student.Skill = formCollection["Skill"];






                RedirectToAction("Index");
            }
            return View();
           
            }
    }
}

        
        
        
    

                
               
               
       
    



















       
    

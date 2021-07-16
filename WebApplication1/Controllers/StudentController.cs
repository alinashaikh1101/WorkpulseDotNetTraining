using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTaskTwo.Models;


namespace WebTaskTwo.Controllers
{​​​​​​​
    public class StudentController : Controller
    {​​​​​​​
        static IList<Student> studentList = new List<Student>{​​​​​​​
                new Student() {​​​​​​​ StudentId = 1, Name = "John",  Gender = "Male", }​​​​​​​ ,
                new Student() {​​​​​​​ StudentId = 1, Name = "John",  Gender = "Male", }​​​​​​​ ,
                new Student() {​​​​​​​ StudentId = 1, Name = "John",  Gender = "Male", }​​​​​​​ ,
                new Student() {​​​​​​​ StudentId = 1, Name = "John",  Gender = "Male", }​​​​​​​ ,
                new Student() {​​​​​​​ StudentId = 1, Name = "John",  Gender = "Male", }​​​​​​​ ,
                new Student() {​​​​​​​ StudentId = 1, Name = "John",  Gender = "Male", }​​​​​​​ ,
            }​​​​​​​;

        // GET: Student
        public ActionResult Index()
        {​​​​​​​
            return View(studentList);
        }​​​​​​​


        public ActionResult Edit(int id)
        {​​​​​​​
            var std = studentList.Where(s => s.StudentId == id).FirstOrDefault();
            return View(std);
        }​​​​​​​


        [HttpPost]
        public ActionResult EditStudent(Student std)
        {​​​​​​​
            if (ModelState.IsValid)
            {​​​​​​​ //checking model state
                 

                var student = studentList.Where(s => s.StudentId == std.StudentId).FirstOrDefault();
                studentList.Remove(student);
                studentList.Add(std);


                return RedirectToAction("Index");
            }​​​​​​​
            return View("edit", std);


        }​​​​​​​
        public ActionResult Details()
        {​​​​​​​
            return View(studentList);

        }​​​​​​​
        [HttpDelete]
        public ActionResult Delete(int Id)
        {​​​​​​​
             var student = studentList.Where(s => s.StudentId == int.Id).FirstOrDefault();
            studentList.Remove(student);
            return View(Index);

        }​​​​​​​
        
        
        



        [HttpPost]
        public ActionResult Edit(FormCollection formCollection)
        {​​​​​​​
            if (ModelState.IsValid) 
            {​​​​​​​
                
        
          
            {
                Student student = new Student();
                student.Profession = formCollection["Profession"];
                student.Name = formCollection["Name"];
                student.Gender = formCollection["Gender"];
                student.Age = Convert.ToInt32(formCollection["Age"]);
                student.Address = formCollection["Address"];
                student.AddmissionDate = Convert.ToDateTime(formCollection["AddmissionDate"]);
                student.Fees = Convert.ToInt32(formCollection["Fees"]);
                student.feesDone = formCollection["feesDone"];
                RedirectToAction("Index");
            }
            return View();
        }
    }
}
                
               
               
        }
    }​​​​​​​
}​​​​​​


















       
    

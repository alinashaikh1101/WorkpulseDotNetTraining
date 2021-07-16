using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace WebTaskTwo.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter student name.")]
       
        public string Age { get; set; }
        [Required(ErrorMessage = "Please select gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please enter student age.")]
        public int profession { get; set; }
        [Required(ErrorMessage = "Please enter student Proffesion.")]
        public string HireDate { get; set; }



        [Required(ErrorMessage = "Please select a date ")]
        [DataType(DataType.Date)]
        public DateTime? skills { get; set; }
        public int Salary { get; set; }
        [Required(ErrorMessage = "Please enter salary.")]
        




    }
}

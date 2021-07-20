using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace WebApplication1.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Please enter student name.")]

        public string Name { get; set; }
        [Required]
       

        
        public int Age { get; set; }
        [Required(ErrorMessage = "Please enter student age.")]
        
        public string Gender { get; set; }
        

        [Required(ErrorMessage = "Please enter student Position.")]
        public string Position { get; set; }

        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
        public string Skill { get; set; }
        [Required]
        public string Subject { get; set; }
        public string Office { get; set; }
        public string Description { get; set; }

        public bool isActive { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public int Salary { get; set; }

        
    }

}

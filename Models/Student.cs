using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace nm854615_MIS4200.Models
{
    public class Student
    {
        public int studentID { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string lastName { get; set; }

        [Display(Name = "Student Name")]
        [Required]
        public string fullName { get {return lastName + ", " + firstName; } }

        [Display(Name = "Student Email")]
        [Required]
        public string email { get; set; }

        public ICollection<CourseDetail> CourseDetail { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace nm854615_MIS4200.Models
{
    public class CourseDetail
    {
        public int coursedetailID { get; set; }

        [Display(Name ="Course Description")]
        [Required]
        public int courseDescription { get; set; }

        [Display(Name = "Price of Textbook")]
        [Required]
        public decimal textbookPrice { get; set; }
        public int courseID { get; set; }
        public virtual Course Courses { get; set; }

        [Display(Name = "Student Name")]
        [Required]
        public int studentID { get; set; }
        public virtual Student Student { get; set; }
    }
}
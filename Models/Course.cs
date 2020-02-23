using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace nm854615_MIS4200.Models
{
    public class Course
    {
        public int courseID { get; set; }

        [Display (Name ="Course Description")]
        [Required(ErrorMessage ="Please input description")]
        [StringLength(100)]
        public string description { get; set; }

        [Display(Name ="Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:d}", ApplyFormatInEditMode =true)]
        public DateTime startDate { get; set; }
        public ICollection<CourseDetail> CourseDetails { get; set; }

        [Display(Name ="Professor ID: Subject to Change")]

        public int professorID { get; set; }
        public virtual Professor Professor { get; set; }
    }
}
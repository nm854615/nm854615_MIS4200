using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nm854615_MIS4200.Models
{
    public class Course
    {
        public int courseID { get; set; }
        public string description { get; set; }
        public DateTime startDate { get; set; }
        public ICollection<CourseDetail> CourseDetails { get; set; }
        public int professorID { get; set; }
        public virtual Professor Professor { get; set; }
    }
}
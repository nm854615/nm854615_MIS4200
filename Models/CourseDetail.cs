using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nm854615_MIS4200.Models
{
    public class CourseDetail
    {
        public int coursedetailID { get; set; }
        public int courseDescription { get; set; }
        public decimal textbookPrice { get; set; }
        public int courseID { get; set; }
        public virtual Course Courses { get; set; }
        public int studentID { get; set; }
        public virtual Student Student { get; set; }
    }
}
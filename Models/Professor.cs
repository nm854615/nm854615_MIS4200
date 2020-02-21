using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nm854615_MIS4200.Models
{
    public class Professor
    {
        public int professorID { get; set; }
        public string professorName { get; set; }
        public string professorEmail { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
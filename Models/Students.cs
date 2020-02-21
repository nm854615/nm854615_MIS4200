using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nm854615_MIS4200.Models
{
    public class Students
    {
        public int studentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime customerSince { get; set; }

        public ICollection<Courses> Courses { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace nm854615_MIS4200.Models
{
    public class Professor
    {
        public int professorID { get; set; }

        [Display(Name = "Professor")]
        [Required]
        public string professorName { get; set; }

        [Display(Name = "Professor's Email")]
        [Required]
        public string professorEmail { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
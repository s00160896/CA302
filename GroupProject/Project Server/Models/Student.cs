using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_Server.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
      

        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<StudentAttendance> StudentAttendances { get; set; }
    }
}
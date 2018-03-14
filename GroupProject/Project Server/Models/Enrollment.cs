﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Server.Models
{
    public enum Grade
    { A, B, C, D, F }
    public class Enrollment
    {
        
        public int EnrollmentID { get; set; }
        public int ModuleID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Modules> Moduless { get; set; }

    }
}
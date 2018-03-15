using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_Server.Models
{
    public class StudentAttendance
    {
        [Key]
        public int AttendanceID { get; set; }
       public int ModuleID { get; set; }
        public int StudentID { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public bool Value { get; set; }

        public virtual Modules Modules { get; set; }
        public virtual Student Student { get; set; }
        
    }
}
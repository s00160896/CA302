using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project_Server.Models
{
    public class Department
    {

        public int DepartmentID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Budget { get; set; }

        

        public int? LecturerID { get; set; }

        public virtual Lecturer Lecturers { get; set; }
        public virtual ICollection<Modules> Moduless
        {
            get; set;
        }
    }
}
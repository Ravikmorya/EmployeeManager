using System;
using System.Collections.Generic;

namespace EmployeeManagerProject.Models.Entities
{
    public partial class AttendanceTbl
    {
        public int AttendanceId { get; set; }
        public bool? Present { get; set; }
        public bool? HalfDay { get; set; }
        public bool? Leave { get; set; }
        public int? EmpId { get; set; }
        public DateTime? AttendanceDate { get; set; }

        public virtual EmployeeData Emp { get; set; }
    }
}

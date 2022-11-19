using System;
using System.Collections.Generic;

namespace EmployeeManagerProject.Models.Entities
{
    public partial class EmployeeData
    {
        public EmployeeData()
        {
            AttendanceTbl = new HashSet<AttendanceTbl>();
        }

        public int EmpId { get; set; }
        public string StaffName { get; set; }
        public int? MobileNumber { get; set; }

        public virtual ICollection<AttendanceTbl> AttendanceTbl { get; set; }
    }
}

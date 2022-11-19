using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace EmployeeManagerProject.Models
{
    public class AttendanceViewModel
	{
		public int AttendanceId { get; set; }
		public bool Present { get; set; }
		public bool HalfDay { get; set; } 
		public bool Leave { get; set; } 
		public int EmpId { get; set; }
		public DateTime? AttendanceDate { get; set; }
		
	}
}

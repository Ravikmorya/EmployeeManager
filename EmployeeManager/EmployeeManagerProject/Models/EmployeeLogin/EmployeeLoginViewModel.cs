using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagerProject.Models
{
	public class EmployeeLoginViewModel
	{
		public int EmpId { get; set; }
	
		public string StaffName { get; set; }

		public int MobileNumber { get; set; }
		
		public List<SelectListItem> EmployeeList { get; set; }
	}
}

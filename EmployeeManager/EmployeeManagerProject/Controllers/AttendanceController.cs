using EmployeeManagerProject.Models;
using EmployeeManagerProject.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagerProject.Controllers
{
    public class AttendanceController : Controller
    {
		[HttpGet]
        public IActionResult Index()
        {
			var model = new AttendanceViewModel { AttendanceDate = DateTime.Now };
			return View(model);
			
        }
		[HttpPost]
		public IActionResult Index(AttendanceViewModel employeeDetailsViewModel)
		{
			//This is to Attendance Report save in Database
			AttendanceViewModel employeeDetailsView = new AttendanceViewModel()
			{
				AttendanceId = employeeDetailsViewModel.AttendanceId,
				Present = employeeDetailsViewModel.Present,
				HalfDay = employeeDetailsViewModel.HalfDay,
				Leave = employeeDetailsViewModel.Leave,
				EmpId = employeeDetailsViewModel.EmpId,
				AttendanceDate = employeeDetailsViewModel.AttendanceDate,
			};
			
			EmployeeContext _employeeContext = new EmployeeContext();			
				//_employeeContext.AttendanceTbl.Add(employeeDetailsView);
				_employeeContext.SaveChanges();
				
			ModelState.Clear();
			return View(employeeDetailsViewModel);
			
		}
	}
}

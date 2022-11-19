using EmployeeManagerProject.Models;
using EmployeeManagerProject.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagerProject.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public IActionResult Index()
		{
			//This Code for Bind contact list in Dropdown
			EmployeeLoginViewModel employeeModel = new EmployeeLoginViewModel();
			employeeModel.EmployeeList = new List<SelectListItem>();
			employeeModel.EmployeeList.Add(new SelectListItem
			{
				Value = "",
				Text = "Select Employee"
			});

			 
			EmployeeContext testDBContext = new EmployeeContext();
			var data = testDBContext.EmployeeData;
			foreach (var item in data)
			{
				employeeModel.EmployeeList.Add(new SelectListItem
				{
					Value = Convert.ToString(item.MobileNumber),
					Text = item.StaffName
				});
			}
			
			return View(employeeModel);
		}

		[HttpPost]
		public IActionResult Index(EmployeeLoginViewModel _empoyeeModel)
		{
			//This is code for check Mobile Number and StafName 
			EmployeeContext _employeeContext = new EmployeeContext();
			var status = _employeeContext.EmployeeData.Where(m => m.StaffName == _empoyeeModel.StaffName && m.MobileNumber == _empoyeeModel.MobileNumber).FirstOrDefault();

			//That code is to select dropdown list and bind value in Both input box
			if (_empoyeeModel.EmpId != 0)
			{
				try
				{
					_empoyeeModel.EmployeeList = new List<SelectListItem>();
					_empoyeeModel.EmployeeList.Add(new SelectListItem
					{
						Value = "",
						Text = "Select Employee"
					});
					var data = _employeeContext.EmployeeData;
					ViewBag.SelectedValue = _empoyeeModel.EmpId;
					ViewBag.SelectedText = data.Where(m => m.MobileNumber == _empoyeeModel.EmpId).FirstOrDefault().StaffName;
					return View(_empoyeeModel);
					ModelState.Clear();
				}
				catch (Exception ex)
				{

					throw ex;
				}
			}
				
			if (status == null)
			{
				ViewBag.LoginStatus = 0;
			}
			else
			{
				ModelState.Clear();
				return RedirectToAction("Index", "Attendance");
			}
			return View();
		}
	}
}

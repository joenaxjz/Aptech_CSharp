using DemoSession_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession_1.Controllers;
[Route("emplopyee")]
public class EmployeeController : Controller
{
	//[Route("~/")]
	[Route("")]
	[Route("index")]
	public IActionResult Index()
	{
		return View("Index", new Employee());
	}

	[HttpPost]
	[Route("save")]
	public IActionResult save(Employee employee)
	{
		//Custom Validation
		if(employee.username != null && employee.username == "abc")
		{
			ModelState.AddModelError("username", "username existed");
		}

		if (ModelState.IsValid)
		{
			return View("Success");
		}
		else
		{
			return View("Index");
		}
	}
}

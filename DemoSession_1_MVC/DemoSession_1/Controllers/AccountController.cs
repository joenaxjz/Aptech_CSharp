using BCrypt.Net;
using DemoSession_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoSession_1.Controllers;
[Route("account")]

public class AccountController : Controller
{
    //[Route("~/")]
    [Route("")]
    [Route("index")]
    public IActionResult Index()
    {
        var account = new Account()
        {
            username = "admin1",
            description = "czxcxzcxzczxcxcxzcxzczczxcxzcxzc",
            gender = "female",
            certId = "2",
            roleId = 4,
            Id = 123,
            status = true,
            Dob = DateTime.Now,
        };
        var cerModel = new CertModel();
        var LanguageModel = new LanguageModel();
        var roleModel = new RoleModel();
        ViewBag.certs = cerModel.findAll();
        ViewBag.languages = LanguageModel.findAll();
        ViewBag.roles = roleModel.findAll();
        return View("Index", account);
    }

    // save function
    [HttpPost]
    [Route("save")]
    public IActionResult Save(Account account, int[] langIds)
    {
        Debug.WriteLine("Account info");
        Debug.WriteLine("Username: " + account.username);
        Debug.WriteLine("Password: " + account.password);
        var hash = BCrypt.Net.BCrypt.HashPassword(account.password);
        Debug.WriteLine("Password Hash: " + hash);
        var pwDB = "$2b$10$4UFpGpGWAy6b7JHkGn9tu.woxXmVJ6yAn/1/0fNbgp3X6tAqZd9le";
        if (BCrypt.Net.BCrypt.Verify(account.password, pwDB)){
            Debug.WriteLine("Matched pw");
        }
        else
        {
            Debug.WriteLine("not match pw");
        }
        Debug.WriteLine("Description: " + account.description);
        Debug.WriteLine("Detail: " + account.detail);
        Debug.WriteLine("Gender " + account.gender);
        Debug.WriteLine("Certificate ID: " + account.certId);
        //account.langIds = langIds;
        if(account.langIds.Length > 0)
        {
            Debug.WriteLine("Choosed: " + account.langIds.Length);
			foreach (var langid in account.langIds)
			{
				Debug.WriteLine("Languages ID: " + langid);
			}
		}
        Debug.WriteLine("Role is " + account.roleId);
        Debug.WriteLine("Account Id: " + account.Id);
        Debug.WriteLine("Address information");
        Debug.WriteLine("Street: " + account.address.Street);
		Debug.WriteLine("Ward: " + account.address.Ward);
		Debug.WriteLine("District: " + account.address.District);
        Debug.WriteLine("DoB: " + account.Dob.ToString("MM/dd/yyyy"));

		Debug.WriteLine("Status: " + account.status);
        return RedirectToAction("Index", "account");
    }
}

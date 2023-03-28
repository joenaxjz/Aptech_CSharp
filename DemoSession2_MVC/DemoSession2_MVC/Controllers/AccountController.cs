using DemoSession2_MVC.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DemoSession2_MVC.Controllers;
[Route("account")]
public class AccountController : Controller
{
    private AccountService _accountService;
    public AccountController (AccountService accountService)
    {
        _accountService = accountService;
    }


    [Route("")]
    [Route("index")]
    //[Route("~/")]
    public IActionResult Index()
    {
      
        return View("Index");
    }

    [HttpPost]
    [Route("login")]
    public IActionResult login(string username, string password)
    {
        if(_accountService.login(username, password))
        {
            HttpContext.Session.SetString("username", username);
            return RedirectToAction("welcome");
        }
        else
        {
            //ViewBag.msg = "Invalid";
            TempData["msg"] = "Invalid";
            return RedirectToAction("Index");
        }
    }

    [Route("welcome")]
    public IActionResult welcome()
    {
        ViewBag.username = HttpContext.Session.GetString("username");
        return View("welcome");
    }

    [Route("logout")]

    public IActionResult logout()
    {
        HttpContext.Session.Remove("username");
        return RedirectToAction("Index");
    }

    [Route("profile")]
    public IActionResult profile()
    {
       var account = _accountService.find(HttpContext.Session.GetString("username"));
        return View("profile", account);
    }
}

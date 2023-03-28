using Microsoft.AspNetCore.Mvc;

namespace FlowerShop.Controllers;
[Route("account")]
public class AccountController : Controller
{
    [Route("")]
    [Route("myaccount")]
    public IActionResult Index()
    {
        return View("MyAccount");
    }

    [Route("register")]
    public IActionResult Register()
    {
        return View("Register");
    }
}

using Microsoft.AspNetCore.Mvc;

namespace LayoutTest_MVC.Controllers;
[Route("home")]
public class HomeController : Controller
{
    [Route("")]
    [Route("~/")]

    [Route("index")]
    public IActionResult Index()
    {
        return View();
    }
}

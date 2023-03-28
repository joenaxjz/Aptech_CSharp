using Microsoft.AspNetCore.Mvc;

namespace LayoutTest_MVC.Controllers;
[Route("news")]
public class NewsController : Controller
{
    [Route("index")]
    [Route("")]
    public IActionResult Index()
    {
        return View();
    }
}

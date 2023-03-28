using Microsoft.AspNetCore.Mvc;

namespace FlowerShop.Controllers;
[Route("aboutus")]
public class AboutUsController : Controller
{
    [Route("")]
    [Route("index")]
    public IActionResult Index()
    {
        return View();
    }
}

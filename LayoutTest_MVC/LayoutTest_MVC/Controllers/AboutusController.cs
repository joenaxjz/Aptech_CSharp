using Microsoft.AspNetCore.Mvc;

namespace LayoutTest_MVC.Controllers;
[Route("aboutus")]
public class AboutusController : Controller
{
    [Route("")]
    [Route("index")]
    [Route("aboutus1")]
    public IActionResult Aboutus1()
    {
        return View("Aboutus1");
    }
    [Route("aboutus2")]
    public IActionResult Aboutus2()
    {
        return View("Aboutus2");
    }
}

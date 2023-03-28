using Microsoft.AspNetCore.Mvc;

namespace LayoutTest_MVC.Controllers;
[Route("contact")]
public class ContactController : Controller
{
    [Route("")]
    [Route("index")]
    [Route("contact1")]
    public IActionResult contact1()
    {
        return View("contact1");
    }

    [Route("contact2")]
    public IActionResult contact2()
    {
        return View("contact2");
    }

}

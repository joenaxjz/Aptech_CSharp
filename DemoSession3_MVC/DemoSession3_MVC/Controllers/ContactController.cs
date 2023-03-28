using Microsoft.AspNetCore.Mvc;

namespace DemoSession3_MVC.Controllers;
[Route("contact")]
public class ContactController : Controller
{
    [Route("")]
    [Route("index")]

    [Route("contact1")]
    public IActionResult contact1()
    {
        return View("Contact1");
    }

    [Route("contact2")]
    public IActionResult contact2()
    {
        return View("Contact2");
    }
}

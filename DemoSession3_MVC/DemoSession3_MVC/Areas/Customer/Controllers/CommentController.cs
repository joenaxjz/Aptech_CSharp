using Microsoft.AspNetCore.Mvc;

namespace DemoSession3_MVC.Areas.Customer.Controllers;
[Area("customer")]
[Route("customer/comment")]
public class CommentController : Controller
{
    [Route("")]
    [Route("index")]
    public IActionResult Index()
    {
        return View();
    }
}

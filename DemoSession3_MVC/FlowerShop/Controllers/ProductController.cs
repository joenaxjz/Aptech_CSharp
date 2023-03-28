using Microsoft.AspNetCore.Mvc;

namespace FlowerShop.Controllers;
[Route("product")]
public class ProductController : Controller
{
	[Route("flowers")]
	public IActionResult flowers()
	{
		return View("Flowers");
	}

    [Route("gifts")]
    public IActionResult gifts()
    {
        return View("Gifts");
    }

    [Route("prices")]
    public IActionResult prices()
    {
        return View("Prices");
    }
}

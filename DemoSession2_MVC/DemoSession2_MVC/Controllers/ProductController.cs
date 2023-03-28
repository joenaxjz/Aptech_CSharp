using DemoSession2_MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession2_MVC.Controllers;
[Route("product")]
public class ProductController : Controller
{
    private ProductService productService;

    public ProductController (ProductService _productSevice)
    {
        productService = _productSevice;
    }

    [Route("")]
    [Route("~/")]
    [Route("index")]
    public IActionResult Index()
    {
        ViewBag.products = productService.findAll();
        return View();
    }

    [Route("searchByKeyWord")]
    public IActionResult searchByKeyWord(string keyWord)
    {
        ViewBag.products = productService.search(keyWord);
        ViewBag.keyword = keyWord;
        return View("Index");
    }

    [Route("searchPrices")]
    public IActionResult searchByPrices(double min, double max)
    {
        ViewBag.products = productService.searchPrices(min, max);
        ViewBag.min = min;
        ViewBag.max = max;
        return View("Index");
    }

    [Route("searchByCreated")]
    public IActionResult searchByCreated(string date1, string date2)
    {
        ViewBag.products = productService.searchCreated(date1, date2);
        return View("Index");
    }
}

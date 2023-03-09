using DemoSession_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace DemoSession_1.Controllers;
[Route("product")]
public class ProductController : Controller
{
    [Route("")]
    [Route("index")]
    
    public IActionResult Index()
    {
        var productModel = new ProductModel();
        ViewBag.products = productModel.findAll();
        return View();
    }

    [Route("Detail/{id}")]
    public IActionResult Detail(int id) {
        var productModel = new ProductModel();
        ViewBag.products = productModel.find(id);
        return View("Detail"); }

    [Route("searchByKeyword")]
    public IActionResult searchByKeyword(string keyword)
    {
        var productModel = new ProductModel();
        ViewBag.products = productModel.search(keyword);
        ViewBag.keyword = keyword;
        return View("Index");
    }

    [Route("searchByPrices")]
    public IActionResult searchByPrices(double min, double max)
    {
        var productModel = new ProductModel();
        ViewBag.products = productModel.searchPrices(min, max);
        ViewBag.min = min;
        ViewBag.max = max;
        return View("Index");
    }
}

using DemoSession2_MVC.Models;
using DemoSession2_MVC.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace DemoSession2_MVC.Controllers;
[Route("demo2")]
public class Demo2Controller : Controller
{


    private ProductService productService;
    public Demo2Controller(ProductService _productService) {
        productService = _productService;
    }


    [Route("")]
    [Route("index")]
    //[Route("~/")]

    public IActionResult Index()
    {
        Debug.WriteLine(BCrypt.Net.BCrypt.HashPassword("123"));
        Debug.WriteLine(BCrypt.Net.BCrypt.HashPassword("123"));
        Debug.WriteLine(BCrypt.Net.BCrypt.HashPassword("123"));

        HttpContext.Session.SetInt32("id", 123);
        HttpContext.Session.SetString("name", "Tuan Anh");

        var product = productService.findId(1);
        string s = JsonConvert.SerializeObject(product);
        Debug.WriteLine(s);
        HttpContext.Session.SetString("product", s);

        var products = productService.findAll();
        string s2 = JsonConvert.SerializeObject(products);
        Debug.WriteLine(s2);

        // cancel session
        HttpContext.Session.Remove("id");

        return RedirectToAction("Index2");
    }

    [Route("index2")]
    public ActionResult Index2()
    {
        if(HttpContext.Session.GetInt32("id") != null || HttpContext.Session.GetString("name") != null)
        {
            var id = HttpContext.Session.GetInt32("id");
            var name = HttpContext.Session.GetString("name");
            Debug.WriteLine("Id: " + id);
            Debug.WriteLine("name: " + name);
        }
        if (HttpContext.Session.GetString("product") != null)
        {
            Product pro = JsonConvert.DeserializeObject<Product>(HttpContext.Session.GetString("product"));
            Debug.WriteLine("Product Info");
            Debug.WriteLine("Id: " + pro.Id);
        }
        if (HttpContext.Session.GetString("products") != null)
        {
            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(HttpContext.Session.GetString("products"));
            Debug.WriteLine("Product List");
            products.ForEach(pro =>
            {
                Debug.WriteLine("Id: " + pro.Id);
                Debug.WriteLine("Name: " + pro.Name);
                Debug.WriteLine("Price:" + pro.Price);
                Debug.WriteLine("Image: " + pro.Image);
                Debug.WriteLine("Created: " + pro.Created);
            });
        }
        return View("Index");
    }
}

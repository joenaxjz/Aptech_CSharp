using DemoSession_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace DemoSession_1.Controllers;
public class DemoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Index2()
    {
        // gõ tên View vào trong ( ) để gọi trực tiếp
        return View("HomePage");
    }

    public IActionResult Index3()
    {
        // gõ tên View vào trong ( ) để gọi trực tiếp
        ViewBag.id = 123;
        ViewBag.username = "abc";
        ViewBag.price = 10.3;
        ViewBag.quantity = 2;
        ViewBag.photo = "pic1.jpg";
        ViewBag.pro = new Product
        {
            Id = 2,
            Name = "Product 2",
            Photo = "pic2.jpg",
            Price = 7.5,
            Quantity = 14,
            Created = DateTime.Now
        };
        ViewBag.names = new List<string>
        {
            "name 1", "name 2", "name 3", "name 4", "name 5"
        };
        ViewBag.pros = new List<Product>{
           new Product {
                Id = 1,
                Name = "Product 1",
                Photo = "pic1.jpg",
                Price = 8.9,
                Quantity = 2,
                Created = DateTime.Now
           },

           new Product {
                Id = 2,
                Name = "Product 2",
                Photo = "pic2.jpg",
                Price = 7.5,
                Quantity = 14,
                Created = DateTime.Now
           },

           new Product {
                Id = 3,
                Name = "Product 3",
                Photo = "pic3.jpg",
                Price = 8.3,
                Quantity = 4,
                Created = DateTime.Now
           }

            };

        return View("Index3");
    }
}

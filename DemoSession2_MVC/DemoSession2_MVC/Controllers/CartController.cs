using DemoSession2_MVC.Models;
using DemoSession2_MVC.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics.Eventing.Reader;

namespace DemoSession2_MVC.Controllers;
public class CartController : Controller
{
    private ProductService productService;
    public CartController(ProductService _productService) { 
        productService = _productService;
    }

    public IActionResult Index()
    {
        if (HttpContext.Session.GetString("cart") != null)
        {
            var cart = JsonConvert.DeserializeObject<List<Item>>(HttpContext.Session.GetString("cart"));
            ViewBag.cart = cart;
            ViewBag.sum = cart.Sum(c => c.Product.Price * c.Quantity);
        }
        return View("Index");
    }

    [Route("buy/{id}")]
    public IActionResult buy(int id)
    {
        var product = productService.findId(id);
        if (HttpContext.Session.GetString("cart") == null)
        {
            var cart = new List<Item>();
            cart.Add(new Item
            {
                Product = product,
                Quantity = 1,
            });
            HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
        }
        else
        {
            var cart = JsonConvert.DeserializeObject<List<Item>>(HttpContext.Session.GetString("cart"));
            var index = Exists(id, cart);
            if(index == -1)
            {
                cart.Add(new Item
                {
                    Product = product,
                    Quantity = 1,
                }) ;
            }else
            {
                cart[index].Quantity++;
            }
            HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
        }
        
        return RedirectToAction("Index");
    }

    [Route("remove/{id}")]
    public IActionResult remove(int id)
    {
        var cart = JsonConvert.DeserializeObject<List<Item>>(HttpContext.Session.GetString("cart"));
        var index = Exists(id, cart);
        cart.RemoveAt(index);
        HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
        return RedirectToAction("index");
    }

    [HttpPost]
    [Route("update")]
    public IActionResult update(int[] quantities)
    {
        var cart = JsonConvert.DeserializeObject<List<Item>>(HttpContext.Session.GetString("cart"));
        for(var i = 0; i < cart.Count; i++)
        {
            cart[i].Quantity = quantities[i];
        }
        HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
        return RedirectToAction("index");
    }


    private int Exists( int id, List<Item> cart )
    {
        for (var i = 0 ; i < cart.Count; i++)
        {
            if (cart[i].Product.Id == id)
            {
                return i;
            }
        }
        return -1;
    }
}

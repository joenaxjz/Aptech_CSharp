using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoSession_1.Controllers;
[Route("demo2")]
public class Demo2Controller : Controller
{
    // đặt đường dẫn tùy ý
    // ở dưới là vd: localhost/demo2 hoặc localhost/abc đều dẫn đến page index demo 2\
    [Route("index")]
    [Route("def")]
    [Route("")]
    public IActionResult Index()
    {
        return View();
    }

    [Route("index2/{id}")]
    public IActionResult Index2(int id)
    {
        Debug.WriteLine("ID: " + id);
        return View("Index2");
    }

    [Route("index3/{id}/{username}")]
    public IActionResult Index3(int id, string username)
    {
        Debug.WriteLine("ID: " + id);
        Debug.WriteLine("Username: " + username);
        return View("Index3");
    }

    [Route("index4")]
    public IActionResult Index4()
    {
        return View("Index4");
    }

    [Route("index5")]
    public IActionResult Index5(int id, string username)
    {
        Debug.WriteLine("ID: " + id);
        Debug.WriteLine("Username: " + username);
        return View("Index5");
    }

    [Route("index6")]
    public IActionResult Index6()
    {
       return RedirectToAction("Index4","demo2");
    }
}
 
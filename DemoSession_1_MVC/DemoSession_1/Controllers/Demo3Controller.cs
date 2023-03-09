using DemoSession_1.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace DemoSession_1.Controllers;
[Route("demo3")]
public class Demo3Controller : Controller
{
    private IWebHostEnvironment webHostEnvironment;
    // Injection => DI

    public Demo3Controller (IWebHostEnvironment _webHostEnvironment)
    {
        webHostEnvironment = _webHostEnvironment;
    }

    [Route("")]
    [Route("index")]
    
    public IActionResult Index()
    {
        var name = Guid.NewGuid().ToString().Replace("-", "");
        Debug.WriteLine(name);
        return View();
    }

    [Route("searchByKeyword")]
    public IActionResult searchByKeyword(string keyword)
    {
        Debug.WriteLine(keyword);
        return View("index");
    }

    [Route("searchByPrices")]
    public IActionResult searchByPrices(double min, double max)
    {
        Debug.WriteLine("Min: " + min);
        Debug.WriteLine("Max: " + max);
        return View("index");
    }

    // dùng line bên dưới để dùng post method
    [HttpPost]
    [Route("login")]
    public IActionResult login(string username, string password)
    {
        Debug.WriteLine("Username " + username);
        Debug.WriteLine("Password " + password);
        return View("index");
    }

    [HttpPost]
    [Route("update")]
    public IActionResult update(string[] mails, int[] quantities)
    {
        Debug.WriteLine("Mails: " + mails.Length);
        Debug.WriteLine("Quantities: " + quantities.Length);
        foreach (var mail in mails)
        {
            Debug.WriteLine(mail);
        }

        foreach (var quantity in quantities)
        {
            Debug.WriteLine(quantity);
        }
        
        return View("index");
    }

    [HttpPost]
    [Route("upload")]
    public IActionResult upload(IFormFile file)
    {
        Debug.WriteLine("Name: " + file.FileName);
        Debug.WriteLine("Size(byte): " + file.Length);
        Debug.WriteLine("Type: " + file.ContentType);
        var fileName = FileHelper.generateFileName(file.FileName);
        var path = Path.Combine(webHostEnvironment.WebRootPath, "upload", fileName);
        using (var fileStream = new FileStream(path, FileMode.Create))
        {
            file.CopyTo(fileStream);
        }
        return RedirectToAction("index", "demo3");
    }

    [HttpPost]
    [Route("uploads")]
    public IActionResult upload(IFormFile[] files)
    {
        Debug.WriteLine(files.Length);
        foreach(var file in files) {
            Debug.WriteLine("Name: " + file.FileName);
            Debug.WriteLine("Size(byte): " + file.Length);
            Debug.WriteLine("Type: " + file.ContentType);
            var fileName = FileHelper.generateFileName(file.FileName);
            var path = Path.Combine(webHostEnvironment.WebRootPath, "upload", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
        }
        return RedirectToAction("index", "demo3");
    }
}

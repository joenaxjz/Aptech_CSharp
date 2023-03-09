using DemoSession_1.Helpers;
using DemoSession_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoSession_1.Controllers;
[Route("student")]
public class StudentController : Controller
{
    private IWebHostEnvironment webHostEnvironment;
    // Injection => DI

    public StudentController (IWebHostEnvironment _webHostEnvironment)
    {
        webHostEnvironment = _webHostEnvironment;
    }
    [Route("")]
    [Route("index")]
    [Route("~/")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [Route("import")]
    public IActionResult import(IFormFile file)
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
        var lines =  System.IO.File.ReadAllLines(path);
        foreach (var line in lines)
        {
            var rs = line.Split(new char[] { ';' }) ;
            var stu = new StudentModel()
            {
                Id = rs[0],
                Name = rs[1],
                Age = int.Parse(rs[2].Trim()),
                Score = double.Parse(rs[3].Trim()),
            };
            Debug.WriteLine("ID: " + stu.Id);
            Debug.WriteLine("Name: " + stu.Name);
            Debug.WriteLine("Age: " + stu.Age);
            Debug.WriteLine("Score: " + stu.Score);
        }
        return RedirectToAction("index", "student");
    }
}

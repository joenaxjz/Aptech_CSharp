using DemoSession2_MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession2_MVC.Controllers;
[Route("demo")]

public class DemoController : Controller
{
    private DemoSerVice demoService;
    private CaculateService caculateService;
    private RectangleService rectangleService;

    public DemoController (DemoSerVice _demoService, CaculateService _caculateService, RectangleService _regactangleService) {
        demoService = _demoService;
        caculateService = _caculateService;
        rectangleService = _regactangleService;
    }

    [Route("")]
    //[Route("~/")]
    [Route("index")]
    public IActionResult Index()
    {
        var name = "Tuấn Anh";
        ViewBag.msg2 = demoService.Hi(name);
        ViewBag.msg1 = demoService.Hello();
        ViewBag.sum = caculateService.Add(5, 6);
        ViewBag.mul = caculateService.Mul(5, 6);
        ViewBag.area = rectangleService.area(5, 6);
        ViewBag.peri = rectangleService.perimeter(5, 6);
        return View();
    }


}

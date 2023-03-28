namespace DemoSession2_MVC.Services;

public class RegactangleServiceImp : RectangleService
{

    private CaculateService caculateService;
    public RegactangleServiceImp(CaculateService _caculateService) {
        caculateService = _caculateService;
    }

    public int area(int x, int y)
    {
        return caculateService.Mul(x, y);
    }

    public int perimeter(int x, int y)
    {
       return caculateService.Mul(caculateService.Add(x, y), 2);
    }
}

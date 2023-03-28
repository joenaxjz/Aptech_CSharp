namespace DemoSession2_MVC.Services;

public class CaculateServiceImp : CaculateService
{
    public int Add(int a, int b)
    {
        var sum = a + b;
        return sum;
    }

    public int Mul(int a, int b)
    {
        var mul = a * b;
        return mul;
    }
}

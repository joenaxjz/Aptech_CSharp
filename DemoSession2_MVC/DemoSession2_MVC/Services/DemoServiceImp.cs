namespace DemoSession2_MVC.Services;

public class DemoServiceImp : DemoSerVice
{
    public string Hello()
    {
        return "Hello World";
    }

    public string Hi(string name)
    {
        return "Hi " + name;
    }
}

namespace Ref_Out_Regex_TryParse;
internal class Regex_TryParse
{
    public void CheckStrByRegex()
    {
        // string được phép null
        string? str = null;
        Console.WriteLine("vui lòng nhập con số:");
        str = Console.ReadLine();

        // bắt lỗi = regex
        //Regex formula = new Regex("^[0-9]+$");
        // đối tượng sử dụng 1 lần
        if(new Regex("^[0-9]+$").IsMatch(str))
        {
            int rs = int.Parse(str);
            Console.WriteLine("result = {0}", rs);
        }else
        {
            Console.WriteLine("Vui lòng nhập lại");
        }    
    }
    // ---------------------------------------------
    public void CheckStringByTryParse()
    {
        string? str = null;
        Console.WriteLine("vui lòng nhập con số:");
        str = Console.ReadLine();

        // có thể đổi kiểu dữ liệu để bắt bằng cách thay kiểu dữ liệu bên trong, vd thay int = double
        if(int.TryParse(str, out int i))
        {
            Console.WriteLine("Result = {0}", i);
        }
        else
        {
            Console.WriteLine("vui lòng nhập lại");
        }
    }
    //-----------------------------------------------
    public void TryCathBug()
    {
        Console.WriteLine("vui lòng nhập số lượng");
        string? amount = Console.ReadLine();
        try 
        {
            int total = int.Parse(amount);
            if(total <= 0)
            {
                throw new Exception("Phải lớn hơn 0");
            }
            Console.WriteLine("amout = {0}", total);
        }
        // Exception tự tạo
        catch (Exception) when (amount.Contains("$"))
        {
            Console.WriteLine("không được chứa dấu $");
        }
        // Exception sẵn
        catch (Exception e)
        {
            Console.WriteLine(e.GetType() + ":" +e.Message);
        }
    }

}

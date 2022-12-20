using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismOverloading;
internal class BasicMath
{

    public int Num1 { get; set; }
    public int Num2 { get; set; }

    //public BasicMath(int num1, int num2)
    //{
    //    Num1 = num1;
    //    Num2 = num2;
    //}

    // overloading cùng tên chỉ khác tham số hay kiểu của tham số.
    // thể hiện ở 2 nơi: constructor và methods

    //public void Sum (int numberone, int number2)
    //{
    //    Num1 = numberone;
    //    Num2 = number2;
    //    Console.WriteLine(Num1 + Num2);
    //}

    public void Sum() { 
        Num1 = 0;
        Num2 = 0;
        Console.WriteLine(Num1 + Num2);
    }

    // thay vì overload phương thức
    // optional argument => đối số truyền cho tham số (parameter) mean is đối số lựa chọn
    public void Sum(int numberone = 0, int number2 = default)
    {
        Num1 = numberone;
        Num2 = number2;
        Console.WriteLine(Num1 + Num2);
    }
}

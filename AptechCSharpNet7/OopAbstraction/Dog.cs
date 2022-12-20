using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAbstraction;
internal class Dog : Animal
{
    // thực thi lại abstract method của Animal
    // buộc phải dùng override vào
    public override void showInfo()
    {
        Console.WriteLine("this is a dog");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAbstraction;

//kế thừa dùng dấu : trong C#
internal abstract class Cat : Animal
{
    // con kế thừa cha, mà cha là abstract thì con phải thực thi lại các abstract method, nếu KHÔNG thì con cũng là abstract

    private bool gender;
    public void showCat() => Console.WriteLine("this is a pussy cat");
}

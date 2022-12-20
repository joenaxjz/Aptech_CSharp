using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAbstraction;
// thêm abstract vào class vì có phương thức abstract showInfo()
internal abstract class Animal
{
    // các field ( các biến toàn cục của riêng class Animal )
    private string name;
    private int age;

    // 1 phương thức mà ko có thân {} thì nó là 1 pthuc abstract
    // 1 abstract method kéo theo class cũng là abstract
    public abstract void showInfo();
}

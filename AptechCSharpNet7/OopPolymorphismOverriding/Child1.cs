using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismOverriding;
internal class Child1 : Parent
{
    // viết lại phương thức của cha
    public override void Display() => Console.WriteLine("Child 1 display");
    
    // phương thức Show() mới của con (Child 1)
    public new void Show() => Console.WriteLine("child 1 show");
}

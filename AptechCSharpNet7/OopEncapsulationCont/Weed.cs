using OopEncapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapsulationCont;
internal class Weed : Plant
{
    // cần phải tham chiếu tới project OopEncapsulation để Weed kế thừa Plant
    // right click on OopEncapsulationCont -> add -> project reference.
    static void Main(string[] args)
    {
        Weed weed = new();
        weed.Protected();
        weed.ProtectedInternal();
        weed.Public();
        //weed.PrivateProtected(); => trong cùng đồ án mới xài được. 
    }
}

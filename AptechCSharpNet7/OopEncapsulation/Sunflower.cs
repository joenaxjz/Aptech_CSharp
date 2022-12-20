using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapsulation;
internal class Sunflower : Plant
{
    static void Main(string[] args)
    {
        Sunflower sf = new();
        sf.Protected();  // do Sunflower kế thừa Plane
        sf.Internal(); // trong cùng 1 project nên xài được
        sf.PrivateProtected(); // hoặc là prive, hoặc là protected 
        sf.ProtectedInternal();
        sf.Public();
        // sf.Private => lỗi vì chỉ xài được khi đứng tại class đó
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapsulation;
public class Plant
{
    // access modifier: các bổ từ truy cập
    private             void Private() =>          Console.WriteLine("Private");
    protected           void Protected() =>        Console.WriteLine("Protected");
    internal            void Internal() =>         Console.WriteLine("Internal");
    private protected   void PrivateProtected() => Console.WriteLine("Private Protected");
    protected internal  void ProtectedInternal()=> Console.WriteLine("Protected Internal");
    public              void Public() =>           Console.WriteLine("Public");

    static void Main(string[] args)
    {
        Plant pnt = new();
        pnt.Private();
        pnt.Protected();
        pnt.Internal();
        pnt.PrivateProtected();
        pnt.ProtectedInternal();
        pnt.Public();
    }
}

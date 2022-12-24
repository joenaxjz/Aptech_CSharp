using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod;
internal static class ExtentionMethod
{
    // một class là static thì toàn bộ trên trong class thì phải là static
    public static void CheckIsGreaterThan(this int i , int value)
    {
        if (i > value)
        {
            Console.WriteLine("{0} is greater than {1}", i, value);
        }
    }
    //====================================================================
    public static void Hi(this Program pro)
    {
        Console.WriteLine("Chào bạn, ahihi <3");
    }
}

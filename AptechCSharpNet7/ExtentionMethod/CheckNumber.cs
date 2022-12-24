using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod;
internal class CheckNumber
{
    public static void CheckIsGreaterThan(int value, int i)
    {
        if (i > value)
        {
            Console.WriteLine("{0} đúng là lớn hơn {1}", i, value);
        }
    }
}

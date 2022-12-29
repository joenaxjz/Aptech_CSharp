using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass;
internal class ClassUT<U,T>
{
    public U Fld1 { get; set; }
    public T Fld2 { get; set; }

    public void Show() => Console.WriteLine("Field 1: {0}\nField 2: {1}", Fld1, Fld2);
}

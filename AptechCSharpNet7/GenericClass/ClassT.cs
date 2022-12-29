using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass;
internal class ClassT<V>
{
    public V Field { get; set; }
    public void ShowInfo() => Console.WriteLine("Field: {0}", Field);
}

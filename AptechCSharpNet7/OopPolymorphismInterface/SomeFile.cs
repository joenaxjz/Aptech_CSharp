using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismInterface;
internal class SomeFile : IBinaryFile, ITestFile
{
    // bắt buộc access modifi phải là public
    public void ReadFile() => Console.WriteLine("Read File");
    public void WriteBinaryFile() => Console.WriteLine("Write Binary File");
    public void WriteTestFile() => Console.WriteLine("Write Test File");
}

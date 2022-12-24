using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismInterface;
internal class ManyFile : IBinaryFile, ITestFile
{
    // bỏ đi bổ từ truy cập, sau đó thêm interface
    public void ReadFile() => Console.WriteLine("Read File");
    public void WriteBinaryFile() => Console.WriteLine("Write Binary File");
    public void WriteTestFile() => Console.WriteLine("Write Test File");

    // bỏ đi bổ từ truy cập, sau đó thêm interface, để dùng riêng lẻ interface
    void IBinaryFile.ReadFile() => Console.WriteLine("Read Binary File");
    void ITestFile.ReadFile() => Console.WriteLine("Read Test File");
}

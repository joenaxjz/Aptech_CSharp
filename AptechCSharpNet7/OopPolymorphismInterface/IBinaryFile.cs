using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismInterface;
internal interface IBinaryFile
{
    void WriteBinaryFile();
    void ReadFile();
    // có phương thức mặc định tồn tại trong Interface
    void ShowInfo() => Console.WriteLine("This Is Binary");

    // không dùng bổ từ truy cập (access modify) trong Interface Files.
    // không có override
}

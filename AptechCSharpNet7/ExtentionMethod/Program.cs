using ExtentionMethod;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("vui lòng nhập giá trị cho biến i: ");
// câu lệnh dưới dùng để parse về số.
int i = int.TryParse(Console.ReadLine(), out int result)?result:0;

CheckNumber.CheckIsGreaterThan(15, i);
//====================================

i.CheckIsGreaterThan(19);

//====================================
Program pro = new();
pro.Hi();
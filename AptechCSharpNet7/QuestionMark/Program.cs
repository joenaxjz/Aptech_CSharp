using System.Text;

Console.InputEncoding = Encoding.Unicode;
int num = 10;
string name = "Tuấn anh";
Console.OutputEncoding = Encoding.Unicode;

// trong C# thường có 2 dạng kiểu chính
// 1 là value type ( số thì KHÔNG được null )
// 2 là reference type ( chuỗi, đối tượng CHO PHÉP null )

string name1 = null;

// code cũ, dùng để ép value type được phép null
Nullable<int> a = null;

// code mới => cho phép value type
int? b = null;
bool? flag = null;

//
//if(name1  != null)
//{
//    Console.WriteLine(true);
//}    else
//{
//    Console.WriteLine(false);
//}    

// ?: => ternary operation ( toán tử 3 ngôi )
Console.WriteLine(name1 != null ? true : false);
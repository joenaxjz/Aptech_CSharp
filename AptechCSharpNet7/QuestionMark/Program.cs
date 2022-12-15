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
// type 1
Console.WriteLine(name1 != null ? true : false);
// type 2
// is not ( != )
// is ( == )
Console.WriteLine(name1 is not null ? true : false);

// ? => null conditional operator
// ? dùng sau tên biến hay đối tượng
// ? tương tự != , nếu cái gì đó khác null thì lấy vế sau


// HAI CÁCH GIỐNG NHAU, nên xài cách 1.
// cách 1
int? length = name?.Length;
// cách 2
//if(name1 is not null)
//{
//    length = name.Length;
//}else
//{
//    length = null;
//}

// ?? => null coalescing operator
// ?? tương tự dấu ==
// nếu cái gì đó is null thì lấy vế sau
int? length1 = name?.Length ?? 10;
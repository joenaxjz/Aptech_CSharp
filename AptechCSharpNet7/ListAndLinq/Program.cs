using ListAndLinq;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
List<Student> students = new List<Student>()
{
    new Student(){Id=1 ,Name= "Tuấn Anh" , Gender = true, Dob= new DateTime(2003,02,05)},
    new Student(){Id=2 ,Name= "Hoàng Khải" , Gender = true, Dob= new DateTime(2003,01,01)},
    new Student(){Id=3 ,Name= "Thái Anh" , Gender = true, Dob= new DateTime(2003,02,07)}
};

// duyệt qua phần tử trong list bằng vòng lặp foreach
//foreach (var stu in students)
//{
//    Console.WriteLine(stu);
//}

//Console.WriteLine("====================================");

//// vòng lặp foreach sẽ chuyển thành
//IEnumerator<Student> enu = students.GetEnumerator();
//while (enu.MoveNext())
//{
//    Console.WriteLine(enu.Current.ToString());
//}

// duyệt qua list, cách này chậm nhất
//students.ForEach(Console.WriteLine);

// linq => language integrated query.
// linq to sql => thay thế cú pháp sql trong c#.
// linq to object => làm bên dưới console
// c# => from -> where -> group by -> having -> order by -> select

// linq có 2 dạng:
// style 1 => query syntax => dựa theo cú pháp của sql, dễ học, dễ dùng
// style 2 => method syntax => dựa theo lambda => khó học, khó dùng, but faster.

// hiển thị toàn bộ thông tin sinh viên trong list, với điều kiện id > 2
//foreach (var stu in students)
//{
//    if (stu.Id > 2)
//    {
//        Console.WriteLine(stu);
//    }
//}


// style 1 của linq : query syntax
// từ biến stu ( tự đặt ) trong list students lấy ra stu.Id lớn hơn 2 từ biến stu ( giống tên biến đầu tiên tự đặt ).
//var t = from stu in students 
//        where stu.Id > 2 
//        select stu;

//foreach (var i in t)
//{ 
//    Console.WriteLine(i); 
//}


// style 2 của linq : method syntax
//var s = students.Where(stu => stu.Id > 2);
//foreach ( var i in s)
//{
//    Console.WriteLine(i);
//}

// kết hợp với foreach của list
students.Where(stu => stu.Id > 2).ToList().ForEach(Console.WriteLine);
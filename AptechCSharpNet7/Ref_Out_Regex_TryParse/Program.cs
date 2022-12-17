//int a = 10;
//int b = 12;

//Ref_Out.Display(ref a,ref b);

//Ref_Out.Display(out int a, out int b);
//Console.WriteLine("a = {0} \nb = {1}",a,b);

// trong C# có 2 dạng: value tpye và reference type
// ref phải khai báo trước

Console.InputEncoding= Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

//// cách 1: pure OOP ( thuần OOP, nằm trong C# cũ )
//Regex_TryParse ps = new Regex_TryParse();

//// cách 2: dùng từ var để thay thế
//var pars = new Regex_TryParse();

// cách 3: target-type C# new
Regex_TryParse prs = new();

// 3 cách trên có tác dụng giống nhau, nhưng khuyên dùng cách 2,3.

// BUILD

//prs.CheckStrByRegex();
//prs.CheckStringByTryParse();
prs.TryCathBug();

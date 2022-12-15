using System.Collections;
using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

int num1 = Random.Shared.Next(0,9);
int num2 = Random.Shared.Next(0, 9);
Console.WriteLine("number1 = {0} và number 2 = {1}",num1,num2);
Console.WriteLine("vui lòng nhập dấu của phép toán:");
string dau = Console.ReadLine();    
//switch (dau)
//{
//    case "+" when num1 > 0 && num2 > 0 : 
//        Console.WriteLine("number 1 + number 2 = {0}", num1 + num2 );break;
//    case "-" when num1 >= num2: 
//        Console.WriteLine("number 1 - number 2 = {0}", num1 - num2); break;
//    case "*": 
//        Console.WriteLine("number 1 * number 2 = {0}", num1 * num2); break;
//    case "/" when num2 is not 0: 
//        Console.WriteLine("number 1 / number 2 = {0}", num1 / num2); break;
//    default: 
//        Console.WriteLine("không thể thực hiện");break;
//}
// biểu thức switch ( switch expression )
Console.WriteLine(
        dau switch
        {
            "+" when num1 > 0 && num2 > 0 => num1 + num2,
            "-" when num1 >= num2 => num1 - num2,
            "*" => num1*num2,
            "/" when num2 is not 0 => num1 / num2,
            _=> "không thể thực hiện"
        }
);


string[] arrs = { "khải", "tuân", "tuấn anh", "thịnh" };

// foreach loop
Console.WriteLine("foreach loop");
foreach (var name in arrs)
{
    Console.WriteLine(name);
}

//while loop
Console.WriteLine("while loop");
IEnumerator e = arrs.GetEnumerator();
while (e.MoveNext())
{
    string s = e.Current.ToString();
    Console.WriteLine(s);
}
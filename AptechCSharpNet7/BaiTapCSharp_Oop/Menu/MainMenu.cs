using BaiTapCSharp_Oop.Dal;
using BaiTapCSharp_Oop.Extention_Method;
using BaiTapCSharp_Oop.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCSharp_Oop.Menu;
internal class MainMenu
{
    public static void Show()
    {
        DalProduct dalProduct = new();
        while(true)
        {
            dalProduct.ChangeColor(ConsoleColor.Gray, ConsoleColor.Red);
            Console.WriteLine("1: Add Product");
            Console.WriteLine("2: Show List Product");
            Console.WriteLine("3: Exit");
            var n = Validate<int>.Input("Your Choise Is: ");
            switch(n)
            {
                case 1:
                    dalProduct.ChangeColor(ConsoleColor.Cyan, ConsoleColor.Red);
                    dalProduct.Add();break;
                case 2:
                    dalProduct.ChangeColor(ConsoleColor.Blue, ConsoleColor.Yellow);
                    dalProduct.Show(); break;
                default:
                    Console.WriteLine("Exiting the program");
                    return;
            }
        }
    }
}

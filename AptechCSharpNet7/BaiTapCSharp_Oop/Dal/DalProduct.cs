using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaiTapCSharp_Oop.entity;
using BaiTapCSharp_Oop.Helper;
using BaiTapCSharp_Oop.Services;

namespace BaiTapCSharp_Oop.Dal;
internal class DalProduct : IProduct
{
    public List<Product> list { get; set; } = new();
    public void Add()
    {
        var n = Validate<int>.Input("Pls enter the num of list");
        for (int i = 0; i < n; i++)
        {
            Product pro = new();
            pro.ProId = Validate<string>.Input("Pls enter id: ");
            pro.ProName = Validate<string>.Input("Pls enter the name: ");
            pro.ProPrice = Validate<Double>.Input("Pls enter the price: ");
            pro.Quantity = Validate<int>.Input("pls enter the quantity: ");
            pro.Mfg = Validate<DateTime>.Input("Enter the Mfg: ");
            list.Add(pro);
        }
    }

    public void Show()
    {
        list.ForEach(Console.WriteLine);
    }
}

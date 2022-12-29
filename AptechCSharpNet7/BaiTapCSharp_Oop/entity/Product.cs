using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCSharp_Oop.entity;
internal class Product
{
    public string ProId { get; set; }
    public string ProName { get; set; }
    public double ProPrice { get; set; }
    public int Quantity { get; set; }
    public DateTime Mfg { get; set; }

    public override string ToString()
    {
        return $"{{{nameof(ProId)}={ProId}, {nameof(ProName)}={ProName}, {nameof(ProPrice)}={ProPrice.ToString()}, {nameof(Quantity)}={Quantity.ToString()}, {nameof(Mfg)}={Mfg.ToString("dd/MM/yyyy hh:mm:ss")}}}";
    }
}

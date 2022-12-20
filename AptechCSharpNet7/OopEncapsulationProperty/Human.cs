using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapsulationProperty;
internal class Human
{
    // filed ( phải là private )
    private string fn;
    // properties phải là public, khác với phương thức khi khai báo, properties không có cặp () khi khai báo.

    // dùng cho mobile
    public string Fn { get => fn; set => fn = value; }

    // auto-properties, gộp field thành properties.
    public string Address { get; set; }

}

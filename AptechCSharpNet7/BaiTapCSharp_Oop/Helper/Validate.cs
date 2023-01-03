using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCSharp_Oop.Helper;
internal class Validate<T>
{
    public static T Input(string msg)
    {
        var typecode = Type.GetTypeCode(typeof(T));
        var obj = new object();
        bool flag;

        do
        {
            flag = true;
            try
            {
                Console.WriteLine(msg);
                var str = Console.ReadLine();
                if (string.IsNullOrEmpty(str))
                {
                    throw new Exception("Error, null or empty");
                }
                switch(typecode)
                {
                    case TypeCode.String: obj = str; break;
                    case TypeCode.Int32: obj = Convert.ToInt32(str);
                        if((int)obj < 0) 
                        {
                            throw new Exception("Value nust be greater than 0");
                        }break;
                    case TypeCode.Double: obj = Convert.ToDouble(str);
                        if ((double)obj < 0)
                        {
                            throw new Exception("Value nust be greater than 0");
                        }break;
                    case TypeCode.DateTime:
                        var date = DateTime.TryParseExact(str, new[]{"d/M/yyyy", "d-M-yyyy"}, new CultureInfo("vi-VN"), DateTimeStyles.None, out var t)?t:throw new Exception("Sai roi ban oi <3");
                        obj = date.Add(DateTime.Now.TimeOfDay);
                        break;
                    default: obj = null; break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.GetType()}: {e.Message}, enter again");
                flag = false;      
            }
        } while(!flag);

        return (T)obj;
    }
}

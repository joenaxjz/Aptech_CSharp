namespace Ref_Out_Regex_TryParse;
internal class Ref_Out
{
    //public static void Display (ref int a,ref int b)
    //{
    //    // đổi giá trị của 2 biến a => b , b =>a
    //    var tam = a;
    //    a = b;
    //    b = tam;
    //}
    public static void Display(out int a, out int b)
    {
        // đổi giá trị của 2 biến a => b , b =>a
        a = 10;
        b = 12;
        var tam = a;
        a = b;
        b = tam;
    }
}

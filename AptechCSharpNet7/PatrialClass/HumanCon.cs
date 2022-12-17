namespace PatrialClass;
internal partial class Human
{
    // 1 phương thức mà chỉ có 1 câu lệnh
    // c# sẽ không sd phương thức mà dùng expression body biến nó thành biểu thức dưới dạng phương thức
    public void Show() => Console.WriteLine("Fullname is : {0}", fn);
    public void Check() => Console.WriteLine(10>5 ? true: false);
}

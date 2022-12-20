// được thể hiện ở 3 nơi: override, overload,
using OopPolymorphismOverloading;

// object initializer
BasicMath basic = new();
//BasicMath basic1 = new()
//{
//    Num1 = 10
//};

//BasicMath basic2 = new()
//{
//    Num2 = 12
//};

//BasicMath basic3 = new()
//{
//    Num2 = 5
//};

//BasicMath basic4 = new()
//{
//    Num1 = 15,
//    Num2 = 14
//};

basic.Sum();
basic.Sum(6, 9);
basic.Sum(5);

// named argument
basic.Sum(number2: 5);
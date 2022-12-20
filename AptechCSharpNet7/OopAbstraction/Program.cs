using OopAbstraction;

// 1 class abstract thì không đc phép khởi tạo đối tượng.
// Animal ani = new Animal(); => lỗi
// Cat cat = new Cat(); => lỗi

// pure oop => oop nguyên thủy
// thường dùng khi có Interface
Dog dog1 = new Dog();

// C# new
// thường dùng nhanh
var dog2 = new Dog();

// C# ver up to 10
// target-type new
// thường dùng cho mobile or code platforms
Dog dog3 = new();

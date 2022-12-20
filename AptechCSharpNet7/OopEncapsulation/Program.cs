using OopEncapsulation;

Sunflower sf = new();
//sf.Protected(); // lỗi vì không có quan hệ btw các class
sf.Internal();
//sf.PrivateProtected(); // hoặc private hoặc protected mới xài được
sf.ProtectedInternal();
sf.Public();

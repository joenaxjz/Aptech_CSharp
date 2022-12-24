using OopPolymorphismOverriding;

// khởi tạo đối tượng cho Parent
Parent par = new();
par.Show();
par.Display();

// khởi tạo đối tượng cho Child1
Child1 ch1 = new();
ch1.Show();
ch1.Display();

Parent p = new Child1();
p.Show(); // pthuc Show() của cha chứ ko phải của con
p.Display();
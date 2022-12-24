using OopPolymorphismInterface;

SomeFile sf = new();
sf.WriteBinaryFile();
sf.WriteTestFile();
sf.ReadFile();
(sf as IBinaryFile).ShowInfo();

Console.WriteLine("--------------------------------");

//================================
ManyFile many = new();
many.WriteBinaryFile();
many.WriteTestFile();
(many as IBinaryFile).ReadFile();
(many as IBinaryFile).ShowInfo();

//================================
Console.WriteLine("--------------------------------");
IBinaryFile bifi = new SomeFile();
bifi.WriteBinaryFile();
bifi.ShowInfo();
bifi.ReadFile();

Console.WriteLine("--------------------------------");
bifi = new ManyFile();
bifi.WriteBinaryFile();
bifi.ShowInfo();
bifi.ReadFile();


using GenericClass;

ClassT<string> clT = new();
clT.Field = "Tuan Anh";
clT.ShowInfo();

ClassT<int> clT1 = new();
clT1.Field= 1;
clT1.ShowInfo();

ClassT<bool> clT2 = new();
clT2.Field = true;
clT2.ShowInfo();

Console.WriteLine("=========================================");

ClassUT<string, int> Cut = new();
Cut.Fld1 = "Tuan Anh";
Cut.Fld2 = 12;
Cut.Show();

ClassUT<string, int> Cut1 = new();
Cut1.Fld1 = "Hoang Khai";
Cut1.Fld2 = 11;
Cut.Show();

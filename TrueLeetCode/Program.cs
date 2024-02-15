using TrueLeetCode.Common.List.SetTheory;

UnionFind f = new UnionFind();

f.Make(1);
f.Make(2);
f.Make(3);
f.Make(4);
f.Make(5);

Console.WriteLine(f.Find(4));

f.Unite(1, 4);

Console.WriteLine(f.Find(4));
Console.WriteLine(f.Find(1));
f.Unite(3, 5);
Console.WriteLine(f.Find(2));

f.Unite(5, 2);
Console.WriteLine(f.Find(5));
Console.WriteLine(f.Find(3));

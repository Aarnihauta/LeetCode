int a = int.MaxValue;
int b = int.MaxValue - 1;

a = a + b;
b = a - b;
a = a - b;

Console.WriteLine(a);
Console.WriteLine(b);
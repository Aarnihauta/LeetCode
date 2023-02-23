using TrueLeetCode.Leetcode;

var a = L231.IsPowerOfTwo(0);
var b = L231.IsPowerOfTwo(3);
var c = L231.IsPowerOfTwo(32);
var d = L231.IsPowerOfTwo(-16);
var f = L231.IsPowerOfTwo(1);


Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(f);


var q = M(1);
Console.WriteLine(q);

static bool M(int n)
{
    return n > 0 && (n & (n - 1)) == 0;
}
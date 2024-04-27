using TrueLeetCode.Common.Maths;

var l = new LongNumber();
l.ReadLong("888888888888888\n");

var r = new LongNumber();
r.ReadLong("888888888888888\n");


var q = l.CompareTo(r);
Console.WriteLine(q);
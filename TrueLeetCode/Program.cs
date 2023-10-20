using TrueLeetCode.Leetcode.Trees;


List<NestedInteger> list = new List<NestedInteger>();

list.Add(new TreeNestedInteger(new List<NestedInteger>() { new FlatNestedInt(1), new FlatNestedInt(1)}));
list.Add(new FlatNestedInt(2));
list.Add(new TreeNestedInteger(new List<NestedInteger>() { new FlatNestedInt(1), new FlatNestedInt(1) }));

NestedIterator n = new NestedIterator(list);

var res = new List<int>();

while(n.HasNext())
{
    res.Add(n.Next());
}
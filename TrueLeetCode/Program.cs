using TrueLeetCode.Leetcode.Trees;

var l = new L100();

var p = new TreeNode
{
    val = 1,
    left = new(2)
};

var q = new TreeNode
{
    val = 1,
    right = new(2)
};

var s = l.IsSameTree(p, q);
Console.WriteLine(s);
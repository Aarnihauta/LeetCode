using TrueLeetCode.Leetcode.Trees;

var tree = new TreeNode
{
    val = 10,
    left = new TreeNode
    {
        val = 5,
        left = new TreeNode(3),
        right = new TreeNode(7)
    },
    right = new TreeNode
    {
        val = 15,
        right = new TreeNode(18)
    }
};

var l = new L938();
var r = l.RangeSumBST(tree, 7, 15);
Console.WriteLine();
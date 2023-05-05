using TrueLeetCode.Leetcode.Trees;

var tree = new TreeNode
{
    val = 2,
    left = new TreeNode(1),
    right = new TreeNode
    {
        val = 3,
        left = new TreeNode(0),
        right = new TreeNode(1)
    }
};

var l = new L2331();
var r = l.EvaluateTree(tree);
Console.WriteLine();
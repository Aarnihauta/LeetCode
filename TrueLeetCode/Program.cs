using TrueLeetCode.Leetcode.Trees;

var tree = new TreeNode
{
    left = new TreeNode(9),
    right = new TreeNode(20)
    {
        left = new TreeNode(15),
        right = new TreeNode(7)
    }
};

var l = new L104();
var r = l.MaxDepth(tree);
Console.WriteLine();
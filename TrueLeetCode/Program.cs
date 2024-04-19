using TrueLeetCode.Leetcode.Trees;

var root = new TreeNode
{
    val = 1,
    left = new TreeNode(2)
    {
        left = new TreeNode(4),
        right = new TreeNode(5)
    },
    right = new TreeNode(3)
};

var l = new L102();
var q = l.LevelOrder(root);
Console.WriteLine(q);
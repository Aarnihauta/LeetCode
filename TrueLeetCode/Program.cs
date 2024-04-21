using TrueLeetCode.Leetcode.Trees;

var l = new L124();

var root = new TreeNode
{
    val = -10,
    left = new TreeNode(9),
    right = new TreeNode(20, 15, 7)
};

var r2 = new TreeNode(1, -2, 3);

l.MaxPathSum(root);
using TrueLeetCode.Leetcode.Trees;

var l = new L98();

var root = new TreeNode
{
    val = 5,
    left = new TreeNode(4),
    right = new TreeNode(6, 3, 7)
};

bool valid = l.IsValidBST(root);
Console.WriteLine(valid);
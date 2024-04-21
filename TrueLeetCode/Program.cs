using TrueLeetCode.Leetcode.Trees;

var l = new Codec();

var root = new TreeNode
{
    val = 1,
    left = new TreeNode(2),
    right = new TreeNode(3, 4, 5)
};

string str = l.serialize(root);

var tree = l.deserialize(str);

TreeNode.InorderTraversal(root);
Console.WriteLine();
TreeNode.InorderTraversal(tree);
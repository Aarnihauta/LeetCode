using TrueLeetCode.Leetcode.Trees;

var l = new L1325();

l.RemoveLeafNodes(new TreeNode
{
    val = 1,
    left = new TreeNode(2)
    {
        left = new TreeNode(2)
    },
    right = new TreeNode(3)
    {
        left = new TreeNode(2),
        right = new TreeNode(4)
    }
}, 2);
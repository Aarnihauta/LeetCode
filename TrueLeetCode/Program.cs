using TrueLeetCode.Leetcode.Trees;

var l647 = new L637();

var tree = new TreeNode
{
    val = 3,
    left = new TreeNode(9),
    right = new TreeNode
    {
        val = 20,
        left = new TreeNode(15),
        right = new TreeNode(7)
    }
};

l647.AverageOfLevels(tree);
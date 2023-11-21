using TrueLeetCode.Leetcode.Trees;


var root = new TreeNode
{
    val = 4,
    left = new TreeNode
    {
        val = 8,
        left = new TreeNode
        {
            val = 0
        },
        right = new TreeNode
        {
            val = 1
        }
    },
    right = new TreeNode
    {
        val = 5,
        right = new TreeNode
        {
            val = 6
        }
    }
};

var l = new L2265();

var q = l.AverageOfSubtree(root);

Console.WriteLine(q);
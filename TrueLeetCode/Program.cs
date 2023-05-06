using TrueLeetCode.Leetcode.Trees;


var root1 = new TreeNode
{
    val = 1,
    left = new TreeNode
    {
        val = 3,
        left = new TreeNode
        {
            val = 5
        }
    },
    right = new TreeNode
    {
        val = 2
    }
};

var root2 = new TreeNode
{
    val = 2,
    left = new TreeNode
    {
        val = 1,
        right = new TreeNode
        {
            val = 4
        }
    },
    right = new TreeNode
    {
        val = 3,
        right = new TreeNode
        {
            val = 7
        }
    }
};


var l = new L617();
var r = l.MergeTrees(root1, root2);


Console.WriteLine();
using TrueLeetCode.Leetcode.Trees;

var tree = new TreeNode
{
    val = 1,
    left = null,
    right = new TreeNode
    {
        val = 2,
        left = new TreeNode
        {
            val = 3
        }
    }
};

var l = new L145();

l.PostorderTraversal(tree);

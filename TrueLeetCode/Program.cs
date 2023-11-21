using TrueLeetCode.Leetcode.Trees;

var l = new L671();

var root = new TreeNode
{
    val = 2,
    left = new TreeNode
    {
        val = 2
    },
    right = new TreeNode
    {
        val = 5,
        left = new TreeNode
        {
            val = 5
        },
        right = new TreeNode
        {
            val = 7
        }
    }
};

l.FindSecondMinimumValue(root);
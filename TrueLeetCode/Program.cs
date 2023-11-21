using TrueLeetCode.Leetcode.Trees;

var l = new L111();

var root = new TreeNode
{
    val  = 2,
    right = new TreeNode
    {
        val = 3,
        right = new TreeNode
        {
            val = 4,
            right = new TreeNode
            {
                val = 5,
                right = new TreeNode
                {
                    val = 6,
                }
            }
        }
    }
};

var q= l.MinDepth(root);
Console.WriteLine(q);
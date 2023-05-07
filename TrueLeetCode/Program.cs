using TrueLeetCode.Leetcode.Trees;

var root1 = new TreeNode
{
    val = 18,
    left = new TreeNode(2),
    right = new TreeNode
    {
        val = 22,
        right = new TreeNode(63)
        {
            right = new TreeNode(84)
        }
    }
};

var q = new L700();
var c = q.SearchBST(root1, 63);
Console.WriteLine(c);
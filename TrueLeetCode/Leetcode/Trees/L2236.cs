namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/root-equals-sum-of-children/
public class L2236
{
    public bool CheckTree(TreeNode root)
    {
        return root.val == root.left.val + root.right.val;
    }
}

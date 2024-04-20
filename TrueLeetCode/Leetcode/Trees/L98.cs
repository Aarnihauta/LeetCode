namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/validate-binary-search-tree
public class L98
{
    public bool IsValidBST(TreeNode root)
    {
        return IsBST(root, long.MinValue, long.MaxValue);
    }

    private bool IsBST(TreeNode root, long min, long max)
    {
        if (root == null)
        {
            return true;
        }
        if (root.val <= min || root.val >= max)
        {
            return false;
        }
        return IsBST(root.left, min, root.val) && IsBST(root.right, root.val, max);
    }
}

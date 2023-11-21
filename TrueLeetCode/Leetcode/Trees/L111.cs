namespace TrueLeetCode.Leetcode.Trees;
public class L111
{
    public int MinDepth(TreeNode root, int depth)
    {
        if (root?.left == null && root?.right == null)
        {
            return depth;
        }

        int left = -1;
        int right = -1;
        if(root.left != null)
        {
            left = MinDepth(root.left, depth + 1);
        }

        if(root.right != null)
        {
            right = MinDepth(root.right, depth + 1);
        }

        if(left < 0 && right < 0)
        {
            return depth;
        }
        else if(left < 0)
        {
            return right;
        }
        else if(right < 0)
        {
            return left;
        }
        else
        {
            return Math.Min(left, right);
        }
    }

    public int MinDepth(TreeNode root)
    {
        if(root == null)
        {
            return 0;
        }
        return MinDepth(root, 1);
    }
}

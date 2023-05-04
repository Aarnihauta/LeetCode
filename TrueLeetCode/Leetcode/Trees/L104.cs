namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/maximum-depth-of-binary-tree/
public class L104
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        int answer = 0;
        return Inorder(root, answer);
    }

    private int Inorder(TreeNode root, int currentDepth)
    {
        if (root != null)
        {
            currentDepth++;
            int left = Inorder(root.left, currentDepth);
            int right = Inorder(root.right, currentDepth);

            return Math.Max(left, right);
        }
        return currentDepth;
    }
}

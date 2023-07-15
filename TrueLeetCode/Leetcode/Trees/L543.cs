namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/diameter-of-binary-tree/
public class L543
{
    private int _max = 0;
    public int DiameterOfBinaryTree(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        DFS(root);

        return _max;
    }

    private int DFS(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        var left = DFS(root.left);
        var right = DFS(root.right);

        _max = Math.Max(_max, left + right);
        return Math.Max(left, right) + 1;
    }
}

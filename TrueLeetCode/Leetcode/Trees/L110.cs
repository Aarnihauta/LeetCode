namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/balanced-binary-tree/
public class L110
{
    public bool IsBalanced(TreeNode root)
    {
        return DFS(root).Balanced;
    }

    private (bool Balanced, int Height) DFS(TreeNode root)
    {
        if (root == null)
        {
            return (true, 0);
        }

        var left = DFS(root.left);
        var right = DFS(root.right);

        bool balanced = left.Balanced && right.Balanced && (Math.Abs(left.Height - right.Height) <= 1);
        int height = Math.Max(left.Height, right.Height) + 1;
        return (balanced, height);
    }
}

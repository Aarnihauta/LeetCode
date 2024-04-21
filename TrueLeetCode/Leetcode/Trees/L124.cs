namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/binary-tree-maximum-path-sum/
public class L124
{
    public int MaxPathSum(TreeNode root)
    {
        int maxSum = int.MinValue;
        Traverse(root, ref maxSum);
        return maxSum;
    }

    private int Traverse(TreeNode node, ref int maxSum)
    {
        if (node == null)
            return 0;

        int leftSum = Math.Max(0, Traverse(node.left, ref maxSum));
        int rightSum = Math.Max(0, Traverse(node.right, ref maxSum));

        int pathSum = leftSum + rightSum + node.val;
        maxSum = Math.Max(maxSum, pathSum);

        return Math.Max(leftSum, rightSum) + node.val;
    }
}

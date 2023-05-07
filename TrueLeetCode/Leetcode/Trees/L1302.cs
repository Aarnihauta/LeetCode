namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/deepest-leaves-sum/
public class L1302
{
    private int _maxDepth = 0;
    private int _sum = 0;

    public int DeepestLeavesSum(TreeNode root)
    {
        Traverse(root, 0);
        return _sum;
    }

    private void Traverse(TreeNode node, int depth)
    {
        if (node == null)
        {
            return;
        }

        if (depth > _maxDepth)
        {
            _sum = node.val;
            _maxDepth = depth;
        }
        else if (depth == _maxDepth)
        {
            _sum += node.val;
        }

        Traverse(node.left, depth + 1);
        Traverse(node.right, depth + 1);
    }
}

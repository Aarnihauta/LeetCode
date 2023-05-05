namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/range-sum-of-bst/
public class L938
{
    public int RangeSumBST(TreeNode root, int low, int high)
    {
        int sum = 0;
        var stack = new Stack<TreeNode>();

        var current = root;

        while (current != null || stack.Count > 0)
        {
            while (current != null)
            {
                stack.Push(current);
                current = current.left;
            }

            current = stack.Pop();
            if (current.val >= low && current.val <= high)
            {
                sum += current.val;
            }
            current = current?.right;
        }

        return sum;
    }
}

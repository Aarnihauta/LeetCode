namespace TrueLeetCode.Leetcode.Trees;
public class L671
{
    public int FindSecondMinimumValue(TreeNode root)
    {
        long min = long.MaxValue;
        
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Any())
        {
            var item = queue.Dequeue();
            if (item.val != root.val && item.val < min)
            {
                min = item.val;
            }

            if (item.left != null)
            {
                queue.Enqueue(item.left);
            }
            if (item.right != null)
            {
                queue.Enqueue(item.right);
            }
        }

        if(min == long.MaxValue)
        {
            return -1;
        }
        return (int)min;
    }
}

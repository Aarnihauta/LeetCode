namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/count-nodes-equal-to-average-of-subtree/
public class L2265
{
    public int AverageOfSubtree(TreeNode root)
    {
        var top = new Queue<TreeNode>();
        var bfs = new Queue<TreeNode>();

        top.Enqueue(root);

        int result = 0;
        while(top.Any())
        {
            var item = top.Dequeue();
            int sum = 0;
            int count = 0;
            bfs.Enqueue(item);

            while (bfs.Any())
            {
                var curr = bfs.Dequeue();

                TryEnqueueChildren(bfs, curr);

                count++;
                sum += curr.val;
            }

            if (sum / count == item.val)
            {
                result++;
            }

            TryEnqueueChildren(top, item);
        }

        return result;
    }

    private void TryEnqueueChildren(Queue<TreeNode> queue, TreeNode root)
    {
        if(root == null)
        {
            return;
        }

        if (root.left != null)
        {
            queue.Enqueue(root.left);
        }

        if (root.right != null)
        {
            queue.Enqueue(root.right);
        }
    }
}

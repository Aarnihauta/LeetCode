namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/average-of-levels-in-binary-tree/
public class L637
{
    public IList<double> AverageOfLevels(TreeNode root)
    {
        List<double> result = new List<double>();

        if (root == null)
        {
            return result;
        }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int count = queue.Count;
            double sum = 0;
            for(int i = 0; i < count; i++)
            {
                var current = queue.Dequeue();
                sum += current.val;
                if(current.left != null)
                {
                    queue.Enqueue(current.left);
                }

                if(current.right != null)
                {
                    queue.Enqueue(current.right);
                }
            }

            result.Add(sum / count);
        }

        return result;
    }
}

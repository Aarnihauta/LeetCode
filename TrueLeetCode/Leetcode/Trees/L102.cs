namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/binary-tree-level-order-traversal/
public class L102
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var list = new List<IList<int>>();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Any())
        {
            int currentNodes = queue.Count;
            var currList = new List<int>();
            for(int i = 0; i < currentNodes; i++)
            {
                var temp = queue.Dequeue();
                currList.Add(temp.val);
                if (temp.left != null)
                {
                    queue.Enqueue(temp.left);
                }

                if (temp.right != null)
                {
                    queue.Enqueue(temp.right);
                }
            }

            list.Add(currList);
        }
        list.RemoveAt(list.Count - 1);
        return list;
    }
}

using System.Text;

namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/serialize-and-deserialize-binary-tree
public class Codec
{
    public string serialize(TreeNode root)
    {
        if (root == null)
        {
            return "";
        }
        StringBuilder sb = new StringBuilder();

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        sb.Append($"{root.val},");
        while (queue.Any())
        {
            var node = queue.Dequeue();

            if (node.left != null)
            {
                queue.Enqueue(node.left);
                sb.Append(node.left.val + ",");
            }
            else
            {
                sb.Append("null,");
            }
            if (node.right != null)
            {
                queue.Enqueue(node.right);
                sb.Append(node.right.val + ",");
            }
            else
            {
                sb.Append("null,");
            }
        }

        return sb.ToString().Remove(sb.Length - 1);
    }

    public TreeNode deserialize(string data)
    {
        var root = new TreeNode();

        if (string.IsNullOrEmpty(data))
        {
            return root;
        }

        string[] arr = data.Split(',');

        root = deserialize(arr);
        return root;
    }
    
    private TreeNode deserialize(string[] arr)
    {
        var root = new TreeNode(Convert.ToInt32(arr[0]));
        int i = 0;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(i < arr.Length / 2)
        {
            int l = i * 2 + 1;
            int r = i * 2 + 2;
            i++;

            var node = queue.Dequeue();

            if(l < arr.Length)
            {
                var left = arr[l];
                if (left != "null")
                {
                    node.left = new TreeNode(Convert.ToInt32(left));
                    queue.Enqueue(node.left);
                }
            }

            if(r < arr.Length)
            {
                var right = arr[r];
                if (right != "null")
                {
                    node.right = new TreeNode(Convert.ToInt32(right));
                    queue.Enqueue(node.right);
                }
            }
        }
        return root;
    }
}

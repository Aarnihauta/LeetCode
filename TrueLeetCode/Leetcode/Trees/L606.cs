using System.Text;

namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/construct-string-from-binary-tree/
public class L606
{
    public string Tree2str(TreeNode root)
    {
        StringBuilder sb = new StringBuilder();
        Convert(root, sb);
        int length = sb.Length - 1;
        return sb.ToString()[1..length];
    }

    private void Convert(TreeNode root, StringBuilder sb)
    {
        if (root != null)
        {
            sb.Append('(');
            sb.Append(root.val);

            if (root.left == null && root.right != null)
            {
                sb.Append("()");
            }

            Convert(root.left, sb);
            Convert(root.right, sb);
            sb.Append(')');
        }
    }
}

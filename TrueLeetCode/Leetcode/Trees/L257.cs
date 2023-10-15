namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/binary-tree-paths/
public class L257
{
    private List<string> _result = new List<string>();
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        Traverse(root, "");
        return _result;
    }

    private void Traverse(TreeNode root, string str)
    {
        if (root.left == null && root.right == null)
        {
            _result.Add(str + root.val);
        }
        else
        {
            if (root.left != null)
            {
                Traverse(root.left, str + $"{root.val}->");
            }
            if (root.right != null)
            {
                Traverse(root.right, str + $"{root.val}->");
            }
        }
    }
}
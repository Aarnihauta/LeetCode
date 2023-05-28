namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/binary-tree-preorder-traversal
public class L144
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
        var list = new List<int>();
        Preorder(root, list);
        return list;
    }

    private void Preorder(TreeNode root, List<int> list)
    {
        if (root == null)
        {
            return;
        }

        list.Add(root.val);
        Preorder(root.left, list); 
        Preorder(root.right, list);
    }
}

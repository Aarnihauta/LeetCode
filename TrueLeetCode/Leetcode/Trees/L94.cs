namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/binary-tree-inorder-traversal/
public class L94
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        var list = new List<int>();
        Inorder(root, list);
        return list;
    }

    private void Inorder(TreeNode root, List<int> list)
    {
        if(root == null)
        {
            return;
        }
        Inorder(root.left, list);
        list.Add(root.val);
        Inorder(root.right, list);
    }
}

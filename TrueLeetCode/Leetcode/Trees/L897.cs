namespace TrueLeetCode.Leetcode.Trees;
public class L897
{
    public TreeNode IncreasingBST(TreeNode root)
    {
        var set = new HashSet<int>();
        Inorder(root, set);

        set = set.OrderBy(x => x).ToHashSet();
         
        var node = new TreeNode();
        CreateTreeNode(node, set);
        return node;
    }

    private void Inorder(TreeNode root, HashSet<int> set)
    {
        if(root == null)
        {
            return;
        }
        if(!set.Contains(root.val))
        {
            set.Add(root.val);
        }
        Inorder(root.left, set);
        Inorder(root.right, set);
    }

    private TreeNode CreateTreeNode(TreeNode root, HashSet<int> set)
    {
        foreach(var item in set)
        {
            if(root == null)
            {
                root = new TreeNode();
            }
            root.val = item;
            set.Remove(root.val);
            root.right = CreateTreeNode(root.right, set);
        }
        return root;
    }
}

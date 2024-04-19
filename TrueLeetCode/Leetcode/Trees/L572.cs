namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/subtree-of-another-tree/
public class L572
{
    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        if(subRoot == null)
        {
            return true;
        }

        if(root == null)
        {
            return false;
        }

        if(NodeEquals(root, subRoot))
        {
            return true;
        }

        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    private bool NodeEquals(TreeNode root, TreeNode subRoot)
    {
        if(root == null && subRoot == null)
        {
            return true;
        }

        if(
            root != null 
            && subRoot != null
            && root.val == subRoot.val
            && NodeEquals(root.left, subRoot.left) && NodeEquals(root.right, subRoot.right))
        {
            return true;
        }
        
        return false;
    }
}

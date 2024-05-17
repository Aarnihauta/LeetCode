namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/delete-leaves-with-a-given-value/
public class L1325
{
    public TreeNode RemoveLeafNodes(TreeNode root, int target)
    {
        if (root == null)
        {
            return null;
        }

        root.left = RemoveLeafNodes(root.left, target);
        root.right = RemoveLeafNodes(root.right, target);
        
        if (root.left == null && root.right == null && root.val == target)
        {
            return null;
        }

        return root;
    }
}

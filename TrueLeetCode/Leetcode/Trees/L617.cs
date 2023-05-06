namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/merge-two-binary-trees/
public class L617
{
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
    {
        if(root1 == null)
        {
            return root2;
        }
        if(root2 == null)
        {
            return root1;
        }

        return new TreeNode
        {
            val = root1.val + root2.val,
            left = MergeTrees(root1.left, root2.left),
            right = MergeTrees(root1.right, root2.right)
        };
    }
}

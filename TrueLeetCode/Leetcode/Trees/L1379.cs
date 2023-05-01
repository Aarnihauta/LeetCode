namespace TrueLeetCode.Leetcode.Trees;
public class L1379
{
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
    {
        return Preorder(cloned, target.val);
    }

    private TreeNode Preorder(TreeNode tree, int value)
    {
        TreeNode result = default;

        if(tree != null)
        {
            if (tree.val == value)
            {
                return tree;
            }

            if (tree.left != null)
            {
                if(tree.left.val == value)
                {
                    return tree.left;
                }
                result = Preorder(tree.left, value);
            }

            if (result != null)
            {
                return result;
            }

            if (tree.right != null)
            {
                if (tree.right.val == value)
                {
                    return tree.right;
                }
                result = Preorder(tree.right, value);
            }
        }

        return result;
    }
}

namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/sum-of-root-to-leaf-binary-numbers/
public class L1022
{
    private int _sum;
    public int SumRootToLeaf(TreeNode root)
    {
        if(root == null)
        {
            return 0;
        }
        Traverse(root, 0);
        return _sum;
    }

    private void Traverse(TreeNode root, int value)
    {
        if (root == null)
        {
            return;
        }
        
        value = (value << 1) | root.val;
        if (root.left == null && root.right == null)
        {
            _sum += value;
        }

        Traverse(root.left, value);
        Traverse(root.right, value);
    }
}

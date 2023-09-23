namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/same-tree/
public class L100
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (q == null && p == null)
        {
            return true;
        }

        bool equal = p?.val == q?.val;

        if(!equal)
        {
            return false;
        }

        bool left = IsSameTree(p.left, q.left);
        bool right = IsSameTree(p.right, q.right);

        return equal && left && right;
    }
}

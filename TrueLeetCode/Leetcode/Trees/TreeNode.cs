namespace TrueLeetCode.Leetcode.Trees;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public TreeNode(int val, int val2, int val3)
    {
        this.val = val;
        left = new TreeNode(val2);
        right = new TreeNode(val3);
    }

    public override string ToString()
    {
        return val.ToString();
    }
}


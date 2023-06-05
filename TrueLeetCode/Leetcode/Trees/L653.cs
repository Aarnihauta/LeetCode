namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/two-sum-iv-input-is-a-bst/
public class L653
{
    private HashSet<int> _data = new HashSet<int>();
    private bool _result = false;
    public bool FindTarget(TreeNode root, int k)
    {
        Traverse(root, k);
        return _result;
    }

    private void Traverse(TreeNode root, int k)
    {
        if(root == null)
        {
            return;
        }

        int complement = root.val;

        if(_data.Contains(complement))
        {
            _result = true;
            return;
        }

        _data.Add(root.val);
        Traverse(root.left, k);
        Traverse(root.right, k);
    }
}

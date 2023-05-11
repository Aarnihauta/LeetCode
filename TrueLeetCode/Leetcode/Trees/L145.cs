namespace TrueLeetCode.Leetcode.Trees;
public class L145
{
    public IList<int> PostorderTraversal(TreeNode root)
    {
        var stack = new Stack<TreeNode>();
        Stack<int> result = new Stack<int>();

        stack.Push(root);
        result.Push(root.val);

        while(stack.Count > 0)
        {
            var current = stack.Pop();
            if(current.left != null)
            {
                stack.Push(current.left);
            }

            if(current.right != null)
            {
                stack.Push(current.right);
            }
           
            if(stack.Count > 0)
            {
                var peek = stack.Peek();
                result.Push(peek.val);
            }
        }

        return result.ToList();
    }
}

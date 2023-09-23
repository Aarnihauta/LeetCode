namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/evaluate-boolean-binary-tree/
public class L2331
{
    public bool EvaluateTree(TreeNode root)
    {
        int result = EvaluateRecursive(root);
        return Convert.ToBoolean(result);
    }

    private int EvaluateRecursive(TreeNode root)
    {
        if(CanEvaluateExpression(root))
        {
            root.val = Convert.ToInt32(EvaluateExpression(root));
            return root.val;
        }
        int left = EvaluateRecursive(root.left);
        int right = EvaluateRecursive(root.right);
        var op = GetOperator(root);
        root.val = Convert.ToInt32(EvaluateOperator(op, left, right));
        return root.val;
    }

    private bool EvaluateExpression(TreeNode root)
    {
        if(root.val == 0)
        {
            return false;
        }
        else if(root.val == 1)
        {
            return true;
        }

        if(CanEvaluateExpression(root))
        {
            return EvaluateOperator(GetOperator(root), root.left.val, root.right.val);
        }

        return false;
    }

    private bool CanEvaluateExpression(TreeNode root)
    {
        if(root.left == null && root.right == null)
        {
            return true;
        }

        if (!IsOperator(root) || IsOperator(root.left) || IsOperator(root.right))
        {
            return false;
        }

        return true;
    }

    private bool IsOperator(TreeNode root)
    {
        return root?.val == 2 || root?.val == 3;
    }

    private Operator GetOperator(TreeNode root)
    {
        return (Operator)root?.val;
    }
    private bool EvaluateOperator(Operator op, int left, int right)
    {
        return op switch
        {
            Operator.Or => Or(left, right),
            Operator.And => And(left, right),
        };
    }

    private bool Or(int left, int right)
    {
        return Convert.ToBoolean(left) || Convert.ToBoolean(right);
    }

    private bool And(int left, int right)
    {
        return Convert.ToBoolean(left) && Convert.ToBoolean(right);
    }

    enum Operator
    {
        Or = 2,
        And = 3
    }
}

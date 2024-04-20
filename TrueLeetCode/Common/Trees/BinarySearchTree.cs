namespace TrueLeetCode.Common.Trees;
public static class BinarySearchTree
{
    public static void PreorderTraversal(BinaryTreeNode root)
    {
        if (root != null)
        {
            Console.Write(root + " ");
            PreorderTraversal(root.Left);
            PreorderTraversal(root.Right);
        }
    }

    public static void InorderTraversal(BinaryTreeNode root)
    {
        if(root != null)
        {
            InorderTraversal(root.Left);
            Console.Write(root + " ");
            InorderTraversal(root.Right);
        }
    }

    public static void PostorderTraversal(BinaryTreeNode root)
    {
        if(root != null) 
        {
            PostorderTraversal(root.Left);
            PostorderTraversal(root.Right);
            Console.Write(root + " ");
        }
    }

    public static BinaryTreeNode Find(BinaryTreeNode root, int value)
    {
        if(root == null || root.Value == value)
        {
            return root;
        }

        if(value > root.Value)
        {
            return Find(root.Right, value);
        }
        else
        {
            return Find(root.Left, value);
        }
    }

    public static BinaryTreeNode Min(BinaryTreeNode root)
    {
        if(root.Left == null)
        {
            return root;
        }
        return Min(root.Left);
    }

    public static BinaryTreeNode Max(BinaryTreeNode root)
    {
        if(root.Right == null)
        {
            return root;
        }

        return Max(root.Right);
    }

    public static BinaryTreeNode Parent(BinaryTreeNode root, int value)
    {
        var current = root;
        var successor = current;

        while(current != null)
        {
            if(current.Value > value)
            {
                successor = current;
                current = current.Left;
            }
            else
            {
                current = current.Right;
            }
        }

        return successor;
    }
}

public class BinaryTreeNode
{
    public int Value { get; set; }
    public BinaryTreeNode Left { get; set; }
    public BinaryTreeNode Right { get; set; }

    public BinaryTreeNode(int value = 0, BinaryTreeNode left = null, BinaryTreeNode right = null)
    {
        Value = value;
        Left = left;
        Right = right;
    }

    public BinaryTreeNode(int value, int left, int right)
    {
        Value = value;
        Left = new BinaryTreeNode(left);
        Right = new BinaryTreeNode(right);
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}

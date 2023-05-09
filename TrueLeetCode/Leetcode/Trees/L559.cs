namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/maximum-depth-of-n-ary-tree/
public class L559
{
    private int _max;
    public int MaxDepth(Node root)
    {
       return MaxDepth(root, 1);
    }

    private int MaxDepth(Node root, int depth)
    {
        if (root == null)
        {
            return depth;
        }

        depth++;

        if (root.children != null)
        {
            foreach (var item in root.children)
            {
                MaxDepth(item, depth);
            }
        }

        if(_max < depth)
        {
            _max = depth;
        }

        return depth;
    }
}

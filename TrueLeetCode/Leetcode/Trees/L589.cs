namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/n-ary-tree-preorder-traversal/
public class L589
{
    public IList<int> Preorder(Node root)
    {
        var list = new List<int>();
        Preorder(root, list);
        return list;
    }

    private void Preorder(Node root, List<int> list)
    {
        if (root != null)
        {
            list.Add(root.val);
            if(root.children != null)
            {
                foreach (var child in root.children)
                {
                    Preorder(child, list);
                }
            }
        }
    }
}

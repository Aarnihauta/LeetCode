namespace TrueLeetCode.Leetcode.Trees;
public class L589
{
    public IList<int> Preorder(Node root)
    {
        var list = new List<int>();
        PreorderTraversal(root, list);
        return list;
    }

    private void PreorderTraversal(Node root, List<int> list)
    {
        if (root != null)
        {
            list.Add(root.val);
            if(root.children != null)
            {
                foreach (var child in root.children)
                {
                    PreorderTraversal(child, list);
                }
            }
        }
    }
}

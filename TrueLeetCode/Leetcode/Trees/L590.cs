using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/n-ary-tree-postorder-traversal/
public class L590
{
    public IList<int> Postorder(Node root)
    {
        var list = new List<int>();

        Postorder(root, list);
        list.Add(root.val);
        return list;
    }

    private void Postorder(Node root, List<int> list)
    {
        if(root?.children != null)
        {
            foreach(var child in root.children)
            {
                Postorder(child, list);
                list.Add(child.val);
            }
        }
    }
}

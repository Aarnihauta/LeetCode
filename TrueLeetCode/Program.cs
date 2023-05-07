using TrueLeetCode.Leetcode.Trees;

var root = new TreeNode
{
    val = 1,
    right = new TreeNode
    {
        val = 2,
        left = new TreeNode
        {
            val =3
        }
    }
};

L94 l = new L94();

l.InorderTraversal(root);
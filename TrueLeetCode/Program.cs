using TrueLeetCode.Leetcode.Trees;

var node = new Node
{
    val = 1,
    children = new List<Node>
    {
        new Node(3, new List<Node>
        {
            new Node(5),
            new Node(6)
        }),
        new Node(2),
        new Node(4)
    }
};

L590 l= new L590();
l.Postorder(node);
using TrueLeetCode.Leetcode.Trees;

var l = new L559();

var node = new Node
{
    val = 1,
    children = new List<Node>
    {
        new Node
        {
            val = 2,
            children = new List<Node>
            {
                new Node(5),
                new Node
                {
                    val = 6,
                    children = new List<Node>
                    {
                        new Node(7),
                        new Node(8),
                        new Node(9)
                        {
                            children = new List<Node>
                            {
                                new Node(13),
                                new Node(14)
                                {
                                    children = new List<Node>
                                    {
                                        new Node(15)
                                    }
                                }
                            }
                        }
                    }
                }
            }
        },
        new Node
        {
            val = 3,
            children = new List<Node>
            {
                new Node(10),
                new Node(11)
                {
                    children = new List<Node>
                    {
                        new Node(12),
                    }
                }
            }
        },
        new Node(4),
    }
};

l.MaxDepth(node);
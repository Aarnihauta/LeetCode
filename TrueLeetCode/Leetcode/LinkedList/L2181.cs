namespace TrueLeetCode.Leetcode;

//https://leetcode.com/problems/merge-nodes-in-between-zeros/
public class L2181
{
    public ListNode MergeNodes(ListNode head)
    {
        var node = new ListNode();
        var result = node;

        if(head.val == 0)
        {
            head = head.next;
        }

        while(head != null)
        {
            if(head.val == 0 && head.next != null)
            {
                node.next = new ListNode();
                node = node.next;
            }

            node.val += head.val;
            head = head.next;
        }

        return result;
    }
}

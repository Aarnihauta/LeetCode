using TrueLeetCode.Leetcode.Trees;

namespace TrueLeetCode.Leetcode.LinkedList;

//https://leetcode.com/problems/double-a-number-represented-as-a-linked-list/k
public class L2816
{
    public ListNode DoubleIt(ListNode head)
    {
        if (head.val > 4)
        {
            head = new ListNode(0, head);
        }

        var current = head;

        while(current != null)
        {
            current.val = current.val * 2 % 10;
            if (current.next != null && current.next.val > 4)
            {
                current.val++;
            }
            current = current.next;
        }

        return head;
    }
}

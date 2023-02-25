namespace TrueLeetCode.Leetcode;

//https://leetcode.com/problems/reverse-linked-list/
public class L206
{
    public ListNode ReverseList(ListNode head)
    {
        var current = head;
        ListNode previous = null;
        while(current != null)
        {
            ListNode? next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }
        return head = previous;
    }
}

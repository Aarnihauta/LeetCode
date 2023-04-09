namespace TrueLeetCode.Leetcode;

//https://leetcode.com/problems/reverse-linked-list/
public class L206
{
    public ListNode ReverseList(ListNode head)
    {
        var curr = head;
        var prev = default(ListNode);

        while(curr != null)
        {
            var temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        return prev;
    }
    public ListNode ReverseListRecoursive(ListNode head)
    {
        if (head == null)
            return null;

        var newHead = head;

        if (head.next != null)
        {
            newHead = ReverseListRecoursive(head.next);
            head.next.next = head;
        }
        head.next = null;
        return newHead;
    }
}

namespace TrueLeetCode.Leetcode;

//https://leetcode.com/problems/reverse-linked-list/
public class L206
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        var curr = head;

        while (curr != null)
        {
            var temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        return prev;
    }
}

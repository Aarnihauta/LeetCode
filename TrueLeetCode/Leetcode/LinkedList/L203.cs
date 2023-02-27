namespace TrueLeetCode.Leetcode;

//https://leetcode.com/problems/remove-linked-list-elements/
public class L203
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        while(head != null && head.val == val)
        {
            head = head.next;
        }

        var result = head;
        while (head != null)
        {
            if (head.next?.val == val)
            {
                head.next = head.next.next;
            }
            else
            {
                head = head.next;
            }
        }
        return result;
    }
}

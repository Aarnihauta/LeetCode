namespace TrueLeetCode.Leetcode;

//https://leetcode.com/problems/remove-duplicates-from-sorted-list/
public class L83
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        var result = head;

        while (head != null && head.next != null)
        {
            if (head.val == head.next.val)
            {
                head.next = head.next.next;
                continue;
            }

            head = head.next;
        }

        return result;
    }
}

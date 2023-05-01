namespace TrueLeetCode.Leetcode;

//https://leetcode.com/problems/remove-duplicates-from-sorted-list/
public class L83
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        var current = head;
        
        while(current != null)
        {
            while(current.next != null && current.next.val == current.val)
            {
                current.next = current.next.next;
            }
            current = current.next;
        }
        return head;
    }
}

namespace TrueLeetCode.Leetcode;

//https://leetcode.com/problems/middle-of-the-linked-list
public class L876
{
    public ListNode MiddleNode(ListNode head)
    {
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            head = head.next;
            fast = fast.next.next;
        }

        return head;
    }
}

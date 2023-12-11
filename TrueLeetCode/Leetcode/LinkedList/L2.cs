namespace TrueLeetCode.Leetcode.LinkedList;

//https://leetcode.com/problems/add-two-numbers/
public class L2
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var dummy = new ListNode();
        var current = dummy;
        int carry = 0;

        while (l1 != null || l2 != null)
        {
            int x = l1 == null ? 0 : l1.val;
            int y = l2 == null ? 0 : l2.val;

            int sum = x + y + carry;
            carry = sum / 10;

            current.next = new ListNode(sum % 10);
            current = current.next;

            if (l1 != null)
            {
                l1 = l1.next;
            }
            if (l2 != null)
            {
                l2 = l2.next;
            }
        }

        if (carry > 0)
        {
            current.next = new ListNode(carry);
        }

        return dummy.next;
    }
}

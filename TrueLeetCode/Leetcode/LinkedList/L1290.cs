namespace TrueLeetCode.Leetcode;

//https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/
public class L1290
{
    public int GetDecimalValue(ListNode head)
    {
        int result = 0;
        while (head != null)
        {
            result = result << 1 | head.val;
            head = head.next;
        }
        return result;
    }
}
namespace TrueLeetCode.Leetcode;

//https://leetcode.com/problems/merge-nodes-in-between-zeros/
public class L2181
{
    public ListNode MergeNodes(ListNode head)
    {
        return null;
    }

    private ListNode CreateNode(ListNode node)
    {
        int sum = 0;
        var current = node;
        while(current?.val != 0)
        {
            sum += current.val;
            current = current.next;
        }
        return new ListNode(sum, current);
    }
}

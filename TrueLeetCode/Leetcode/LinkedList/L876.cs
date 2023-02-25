namespace TrueLeetCode.Leetcode;
public class L876
{
    //https://leetcode.com/problems/middle-of-the-linked-list
    public ListNode MiddleNode(ListNode head)
    {
        List<ListNode> list = new List<ListNode>();

        while(head != null)
        {
            list.Add(head);
            head = head.next;
        }
        return list[list.Count / 2];
    }
}

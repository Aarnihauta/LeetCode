namespace TrueLeetCode.Leetcode;
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public override string ToString()
    {
        return val.ToString();
    }

    public static ListNode Create(params int[] vals)
    {
        var head = new ListNode();
        var current = head;
        foreach(var item in vals)
        {
            current.val = item;
            current.next = new ListNode();
            current = current.next;
        }

        return head;
    }
}